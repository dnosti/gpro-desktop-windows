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
        e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

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
        e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

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
      //if (e.ColumnIndex >= 0 && this.mgProyectos.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      //{
      //  string Id = mgProyectos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
      //  EditarClienteForm editarClienteForm = new EditarClienteForm(Id);
      //  DataGridViewRow editarCliente = mgProyectos.Rows[e.RowIndex];
      //  editarClienteForm.textBoxidCliente.Text = editarCliente.Cells["idCliente"].Value.ToString();
      //  editarClienteForm.textBoxRSocial.Text = editarCliente.Cells["razonSocialCliente"].Value.ToString();
      //  editarClienteForm.textBoxApellido.Text = editarCliente.Cells["apellidoCliente"].Value.ToString();
      //  editarClienteForm.textBoxNombre.Text = editarCliente.Cells["nombreCliente"].Value.ToString();
      //  editarClienteForm.textBoxDomicilio.Text = editarCliente.Cells["direccionCliente"].Value.ToString();
      //  editarClienteForm.textBoxTelefono.Text = editarCliente.Cells["telefonoCliente"].Value.ToString();
      //  editarClienteForm.textBoxEMail.Text = editarCliente.Cells["emailCliente"].Value.ToString();
      //  editarClienteForm.ShowDialog();
      //  string cuit = editarClienteForm.cuit;
      //  if (!string.IsNullOrEmpty(cuit))
      //    buscarCliente("/cliente/cuit/", cuit, true);
      //}
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
      //buscarTarea por Proyecto y por Tarea o Empleado ... ver
    }
  }
}


