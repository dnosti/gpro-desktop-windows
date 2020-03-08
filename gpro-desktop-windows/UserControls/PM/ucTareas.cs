using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gpro_desktop_windows.Models;
using System.Net.Http;
using gpro_desktop_windows.Utils;
using Newtonsoft.Json;
using MetroFramework;
using gpro_desktop_windows.Forms;
using gpro_desktop_windows.Properties;

namespace gpro_desktop_windows.UsersControls
{
  public partial class ucTareas : MetroFramework.Controls.MetroUserControl
  {
    public ucTareas()
    {
      InitializeComponent();
      mgTareas.Visible = false;
      /* Botón Editar en DataGrid */
      DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
      btnEditar.Name = "Editar";
      mgTareas.Columns.Add(btnEditar);
      mgTareas.Columns[11].HeaderText = "";

      /* Botón Ver en DataGrid */
      DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
      btnVer.Name = "Ver";
      mgTareas.Columns.Add(btnVer);
      mgTareas.Columns[12].HeaderText = "";
    }

    private void mgTareas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgTareas.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonEditar = this.mgTareas.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
        Icon icoEditar = Properties.Resources.editar;
        e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 4, e.CellBounds.Top + 4);

        this.mgTareas.Rows[e.RowIndex].Height = icoEditar.Height + 8;
        this.mgTareas.Columns[e.ColumnIndex].Width = icoEditar.Width + 8;

        DataGridViewCell cell = this.mgTareas.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Editar";

        e.Handled = true;
      }

      if (e.ColumnIndex >= 0 && this.mgTareas.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonVer = this.mgTareas.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
        Icon icoVer = Properties.Resources.ver;
        e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 4, e.CellBounds.Top + 4);

        this.mgTareas.Rows[e.RowIndex].Height = icoVer.Height + 8;
        this.mgTareas.Columns[e.ColumnIndex].Width = icoVer.Width + 8;

        DataGridViewCell cell = this.mgTareas.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Ver";

        e.Handled = true;
      }
    }

    private void btnCrearTarea_Click(object sender, EventArgs e)
    {
      CrearTareaForm crearTareaForm = new CrearTareaForm();
      crearTareaForm.ShowDialog();
    }

    private void btnVerTodasTareas_Click(object sender, EventArgs e)
    {
      getTareas();
    }

    private void getTareas()
    {
      List<Tarea> tareaResponses = null;
      List<ProyectoResponse> proyectoResponses = null;
      List<Perfil> perfilResponses = null;
      List<Empleado> empleadoResponses = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage responseTarea = HttpUtils.getTareas(client, "/tarea/");
      HttpResponseMessage responseProyecto = HttpUtils.getProyectos(client, "/proyectos/");
      HttpResponseMessage responsePerfil = HttpUtils.getPerfiles(client, "/perfiles/");
      HttpResponseMessage responseEmpleado = HttpUtils.getEmpleados(client, "/empleado/");

      string stringTR = responseTarea.Content.ReadAsStringAsync().Result;
      string stringPR = responseProyecto.Content.ReadAsStringAsync().Result;
      string stringPER = responsePerfil.Content.ReadAsStringAsync().Result;
      string stringER = responseEmpleado.Content.ReadAsStringAsync().Result;

      if (responseTarea.IsSuccessStatusCode)
      {
        mgTareas.Visible = true;
        tareaResponses = JsonConvert.DeserializeObject<List<Tarea>>(stringTR);
        proyectoResponses = JsonConvert.DeserializeObject<List<ProyectoResponse>>(stringPR);
        perfilResponses = JsonConvert.DeserializeObject<List<Perfil>>(stringPER);
        empleadoResponses = JsonConvert.DeserializeObject<List<Empleado>>(stringER);

        var listaTareas =
          from t in tareaResponses
          join p in proyectoResponses on t.ProyectoIdProyecto equals p.IdProyecto
          join pr in perfilResponses on t.PerfilEmpleadoIdPerfil equals pr.IdPerfil
          join e in empleadoResponses on t.PerfilEmpleadoIdEmpleado equals e.IdEmpleado
          select new
          {
            t.ProyectoIdProyecto,
            p.TituloProyecto,
            p.IdEmpleadoPm,
            t.IdTarea,
            t.PerfilEmpleadoIdPerfil,
            pr.DescripcionPerfil,
            t.PerfilEmpleadoIdEmpleado,
            Fullname = e.ApellidoEmpleado + ", " + e.NombreEmpleado,
            t.DescripcionTarea,
            t.HorasEstimadasTarea,
            t.HorasOverbudgetTarea
          };

        mgTareas.DataSource = listaTareas.Where(x => x.IdEmpleadoPm == Settings.Default.IdEmpleado).ToList();
      }
      else
      {
        MessageBox.Show("No se encontró la tarea.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void mgTareas_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgTareas.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      {
        string Id = mgTareas.Rows[e.RowIndex].Cells["IdTarea"].Value.ToString();
        string IdProyecto = mgTareas.Rows[e.RowIndex].Cells["IdProyecto"].Value.ToString();
        string IdEmpleado = mgTareas.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString();
        string IdPerfil = mgTareas.Rows[e.RowIndex].Cells["IdEmpleadoPerfil"].Value.ToString();
        EditarTareaForm editarTareaForm = new EditarTareaForm(Id, IdProyecto, IdEmpleado, IdPerfil);
        DataGridViewRow editarTarea = mgTareas.Rows[e.RowIndex];
        editarTareaForm.textBoxDescTarea.Text = editarTarea.Cells["DescripciónTarea"].Value.ToString();
        editarTareaForm.horasEstimadas.Value = int.Parse(editarTarea.Cells["HorasEstimadasTarea"].Value.ToString());
        editarTareaForm.ShowDialog();
        if (editarTareaForm.okUpdate)
          getTareaId("/tarea/", editarTareaForm.id);
      }
      if (e.ColumnIndex >= 0 && this.mgTareas.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
      {
        VerTareaForm verTareaForm = new VerTareaForm();
        DataGridViewRow verTarea = mgTareas.Rows[e.RowIndex];
        verTareaForm.textBoxProyecto.Text = verTarea.Cells["TituloProyecto"].Value.ToString();
        verTareaForm.textBoxEmpleado.Text = verTarea.Cells["Fullname"].Value.ToString();
        verTareaForm.textBoxTarea.Text = verTarea.Cells["DescripciónTarea"].Value.ToString();
        verTareaForm.textBoxHorasEstimadas.Text = verTarea.Cells["HorasEstimadasTarea"].Value.ToString();
        //verTareaForm.textBoxHorasOverbudget.Text = verTarea.Cells["HorasOverbudgetTarea"].Value.ToString();

        if (verTarea.Cells["HorasOverbudgetTarea"].Value == null)
          verTareaForm.textBoxHorasOverbudget.Text = "0";
        else
          verTareaForm.textBoxHorasOverbudget.Text = verTarea.Cells["HorasOverbudgetTarea"].Value.ToString();

        verTareaForm.Show();
      }
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      if (ComboBoxProyecto.SelectedIndex == -1 && ComboBoxEmpleado.SelectedIndex == -1)
      {
        MessageBox.Show(this, "Complete el formulario para realizar la búsqueda.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (ComboBoxEmpleado.SelectedIndex != -1)
      {
        List<Tarea> tareaResponses = null;
        List<ProyectoResponse> proyectoResponses = null;
        List<Perfil> perfilResponses = null;
        List<Empleado> empleadoResponses = null;

        HttpClient client = HttpUtils.configHttpClient();
        HttpResponseMessage responseTarea = HttpUtils.getTareas(client, "/tarea/");
        HttpResponseMessage responseProyecto = HttpUtils.getProyectos(client, "/proyectos/");
        HttpResponseMessage responsePerfil = HttpUtils.getPerfiles(client, "/perfiles/");
        HttpResponseMessage responseEmpleado = HttpUtils.getEmpleados(client, "/empleado/");

        string stringTR = responseTarea.Content.ReadAsStringAsync().Result;
        string stringPR = responseProyecto.Content.ReadAsStringAsync().Result;
        string stringPER = responsePerfil.Content.ReadAsStringAsync().Result;
        string stringER = responseEmpleado.Content.ReadAsStringAsync().Result;

        if (responseTarea.IsSuccessStatusCode)
        {
          mgTareas.Visible = true;
          tareaResponses = JsonConvert.DeserializeObject<List<Tarea>>(stringTR);
          proyectoResponses = JsonConvert.DeserializeObject<List<ProyectoResponse>>(stringPR);
          perfilResponses = JsonConvert.DeserializeObject<List<Perfil>>(stringPER);
          empleadoResponses = JsonConvert.DeserializeObject<List<Empleado>>(stringER);

          var listaTareas =
            from t in tareaResponses
            join p in proyectoResponses on t.ProyectoIdProyecto equals p.IdProyecto
            join pr in perfilResponses on t.PerfilEmpleadoIdPerfil equals pr.IdPerfil
            join er in empleadoResponses on t.PerfilEmpleadoIdEmpleado equals er.IdEmpleado
            select new
            {
              t.ProyectoIdProyecto,
              p.TituloProyecto,
              p.IdEmpleadoPm,
              t.IdTarea,
              t.PerfilEmpleadoIdPerfil,
              pr.DescripcionPerfil,
              t.PerfilEmpleadoIdEmpleado,
              Fullname = er.ApellidoEmpleado + ", " + er.NombreEmpleado,
              t.DescripcionTarea,
              t.HorasEstimadasTarea,
              t.HorasOverbudgetTarea
            };

          var filtroIdPM = listaTareas.Where(x => x.IdEmpleadoPm == Settings.Default.IdEmpleado).ToList();
          var filtroIdEmpleado = filtroIdPM.Where(x => x.PerfilEmpleadoIdEmpleado == int.Parse(ComboBoxEmpleado.SelectedValue.ToString())).ToList();
          mgTareas.DataSource = filtroIdEmpleado;
        }
      }
      else
      {
        List<Tarea> tareaResponses = null;
        List<ProyectoResponse> proyectoResponses = null;
        List<Perfil> perfilResponses = null;
        List<Empleado> empleadoResponses = null;

        HttpClient client = HttpUtils.configHttpClient();
        HttpResponseMessage responseTarea = HttpUtils.getTareas(client, "/tarea/");
        HttpResponseMessage responseProyecto = HttpUtils.getProyectos(client, "/proyectos/");
        HttpResponseMessage responsePerfil = HttpUtils.getPerfiles(client, "/perfiles/");
        HttpResponseMessage responseEmpleado = HttpUtils.getEmpleados(client, "/empleado/");

        string stringTR = responseTarea.Content.ReadAsStringAsync().Result;
        string stringPR = responseProyecto.Content.ReadAsStringAsync().Result;
        string stringPER = responsePerfil.Content.ReadAsStringAsync().Result;
        string stringER = responseEmpleado.Content.ReadAsStringAsync().Result;

        if (responseTarea.IsSuccessStatusCode)
        {
          mgTareas.Visible = true;
          tareaResponses = JsonConvert.DeserializeObject<List<Tarea>>(stringTR);
          proyectoResponses = JsonConvert.DeserializeObject<List<ProyectoResponse>>(stringPR);
          perfilResponses = JsonConvert.DeserializeObject<List<Perfil>>(stringPER);
          empleadoResponses = JsonConvert.DeserializeObject<List<Empleado>>(stringER);

          var listaTareas =
            from t in tareaResponses
            join p in proyectoResponses on t.ProyectoIdProyecto equals p.IdProyecto
            join pr in perfilResponses on t.PerfilEmpleadoIdPerfil equals pr.IdPerfil
            join er in empleadoResponses on t.PerfilEmpleadoIdEmpleado equals er.IdEmpleado
            select new
            {
              t.ProyectoIdProyecto,
              p.TituloProyecto,
              p.IdEmpleadoPm,
              t.IdTarea,
              t.PerfilEmpleadoIdPerfil,
              pr.DescripcionPerfil,
              t.PerfilEmpleadoIdEmpleado,
              Fullname = er.ApellidoEmpleado + ", " + er.NombreEmpleado,
              t.DescripcionTarea,
              t.HorasEstimadasTarea,
              t.HorasOverbudgetTarea
            };

          var filtroIdPM = listaTareas.Where(x => x.IdEmpleadoPm == Settings.Default.IdEmpleado).ToList();
          var filtroIdProyecto = filtroIdPM.Where(x => x.ProyectoIdProyecto == int.Parse(ComboBoxProyecto.SelectedValue.ToString())).ToList();
          mgTareas.DataSource = filtroIdProyecto;
        }
      }
    }

    private void getTareaId(string path, string payload)
    {
      Tarea tareaResponse = null;
      List<Tarea> tareaResponses = null;
      List<ProyectoResponse> proyectoResponses = null;
      List<Perfil> perfilResponses = null;
      List<Empleado> empleadoResponses = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage responseTarea = HttpUtils.getTarea(client, path, payload);
      HttpResponseMessage responseProyecto = HttpUtils.getProyectos(client, "/proyectos/");
      HttpResponseMessage responsePerfil = HttpUtils.getPerfiles(client, "/perfiles/");
      HttpResponseMessage responseEmpleado = HttpUtils.getEmpleados(client, "/empleado/");

      string stringTR = responseTarea.Content.ReadAsStringAsync().Result;
      string stringPR = responseProyecto.Content.ReadAsStringAsync().Result;
      string stringPER = responsePerfil.Content.ReadAsStringAsync().Result;
      string stringER = responseEmpleado.Content.ReadAsStringAsync().Result;

      if (responseTarea.IsSuccessStatusCode)
      {
        mgTareas.Visible = true;
        tareaResponse = JsonConvert.DeserializeObject<Tarea>(stringTR);
        tareaResponses = new List<Tarea>();
        tareaResponses.Add(tareaResponse);
        proyectoResponses = JsonConvert.DeserializeObject<List<ProyectoResponse>>(stringPR);
        perfilResponses = JsonConvert.DeserializeObject<List<Perfil>>(stringPER);
        empleadoResponses = JsonConvert.DeserializeObject<List<Empleado>>(stringER);

        var listaTareas =
          from t in tareaResponses
          join p in proyectoResponses on t.ProyectoIdProyecto equals p.IdProyecto
          join pr in perfilResponses on t.PerfilEmpleadoIdPerfil equals pr.IdPerfil
          join e in empleadoResponses on t.PerfilEmpleadoIdEmpleado equals e.IdEmpleado
          select new
          {
            t.ProyectoIdProyecto,
            p.TituloProyecto,
            p.IdEmpleadoPm,
            t.IdTarea,
            t.PerfilEmpleadoIdPerfil,
            pr.DescripcionPerfil,
            t.PerfilEmpleadoIdEmpleado,
            Fullname = e.ApellidoEmpleado + ", " + e.NombreEmpleado,
            t.DescripcionTarea,
            t.HorasEstimadasTarea,
            t.HorasOverbudgetTarea
          };

        mgTareas.DataSource = listaTareas.Where(x => x.IdEmpleadoPm == Settings.Default.IdEmpleado).ToList();
      }
    }

    private void getEmpleados()
    {
      List<Empleado> empleadoResponses = null;
      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getEmpleados(client, "/empleado/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        empleadoResponses = JsonConvert.DeserializeObject<List<Empleado>>(stringCR);
        ComboBoxEmpleado.DataSource = empleadoResponses.OrderBy(x => x.FullName).ToList();
        ComboBoxEmpleado.DisplayMember = "FullName";
        ComboBoxEmpleado.ValueMember = "IdEmpleado";
        ComboBoxEmpleado.SelectedValue = "";
      }
    }

    private void getProyectos()
    {
      List<ProyectoResponse> proyectoResponses = null;
      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getProyectos(client, "/proyectos/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        proyectoResponses = JsonConvert.DeserializeObject<List<ProyectoResponse>>(stringCR);
        ComboBoxProyecto.DataSource = proyectoResponses.OrderBy(x => x.TituloProyecto).ToList();
        ComboBoxProyecto.DisplayMember = "TituloProyecto";
        ComboBoxProyecto.ValueMember = "IdProyecto";
        ComboBoxProyecto.SelectedValue = "";
      }
    }

    private void ucTareas_Load(object sender, EventArgs e)
    {
      getProyectos();
      getEmpleados();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      ComboBoxEmpleado.SelectedValue = "";
      ComboBoxProyecto.SelectedValue = "";
    }
  }
}


