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
  public partial class ucMiPanel : MetroFramework.Controls.MetroUserControl
  {
    public ucMiPanel()
    {
      InitializeComponent();

      mgTarea.Visible = false;
      tareaLabel.Visible = false;

      /* Botón Ver Tarea en DataGrid */
      DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
      btnVer.Name = "Ver Tarea";
      mgProyectos.Columns.Add(btnVer);
      mgProyectos.Columns[5].HeaderText = "";

      /* Botón Agregar Horas Trabajadas en DataGrid */
      DataGridViewButtonColumn btnAgregar = new DataGridViewButtonColumn();
      btnAgregar.Name = "Agregar";
      mgTarea.Columns.Add(btnAgregar);
      mgTarea.Columns[7].HeaderText = "";

      /* Botón Ver Horas Trabajadas en DataGrid */
      DataGridViewButtonColumn btnVerHoras = new DataGridViewButtonColumn();
      btnVerHoras.Name = "Horas Trabajadas";
      mgTarea.Columns.Add(btnVerHoras);
      mgTarea.Columns[8].HeaderText = "";

      
    }

    private void mgProyectos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgProyectos.Columns[e.ColumnIndex].Name == "Ver Tarea" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonVer = this.mgProyectos.Rows[e.RowIndex].Cells["Ver Tarea"] as DataGridViewButtonCell;
        Icon icoVer = Properties.Resources.ver;
        e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 4, e.CellBounds.Top + 4);

        this.mgProyectos.Rows[e.RowIndex].Height = icoVer.Height + 8;
        this.mgProyectos.Columns[e.ColumnIndex].Width = icoVer.Width + 8;

        DataGridViewCell cell = this.mgProyectos.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Ver Tarea";

        e.Handled = true;
      }
    }

    private void getProyectos()
    {
      List<EmpleadoProyecto> empleadoProyectos = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getProyecto(client, "/empleado/proyectos/", Settings.Default.IdEmpleado.ToString());

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        empleadoProyectos = JsonConvert.DeserializeObject<List<EmpleadoProyecto>>(stringCR);
        mgProyectos.DataSource = empleadoProyectos;
      }
    }

    private void mgProyectos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgProyectos.Columns[e.ColumnIndex].Name == "Ver Tarea" && e.RowIndex >= 0)
      {
        string IdEmpleado = mgProyectos.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString();
        string IdProyecto = mgProyectos.Rows[e.RowIndex].Cells["IdProyecto"].Value.ToString();
        getTarea(IdEmpleado, IdProyecto);
      }
    }

    private void mgTarea_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgTarea.Columns[e.ColumnIndex].Name == "Agregar" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonVer = this.mgTarea.Rows[e.RowIndex].Cells["Agregar"] as DataGridViewButtonCell;
        Icon icoAgregar = Properties.Resources.agregar;
        e.Graphics.DrawIcon(icoAgregar, e.CellBounds.Left + 4, e.CellBounds.Top + 4);

        this.mgTarea.Rows[e.RowIndex].Height = icoAgregar.Height + 8;
        this.mgTarea.Columns[e.ColumnIndex].Width = icoAgregar.Width + 8;

        DataGridViewCell cell = this.mgTarea.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Cargar Horas Trabajadas";

        e.Handled = true;
      }

      if (e.ColumnIndex >= 0 && this.mgTarea.Columns[e.ColumnIndex].Name == "Horas Trabajadas" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonVer = this.mgTarea.Rows[e.RowIndex].Cells["Horas Trabajadas"] as DataGridViewButtonCell;
        Icon icoVer = Properties.Resources.ver;
        e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 4, e.CellBounds.Top + 4);

        this.mgTarea.Rows[e.RowIndex].Height = icoVer.Height + 8;
        this.mgTarea.Columns[e.ColumnIndex].Width = icoVer.Width + 8;

        DataGridViewCell cell = this.mgTarea.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Ver Horas Trabajadas";

        e.Handled = true;
      }
    }

    private void getTarea(string IdEmpleado, string IdProyecto)
    {
      List<Tarea> tareas = null;

      string payload = IdEmpleado + "/" + IdProyecto;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getTarea(client, "/empleado/tareas/", payload);

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        tareas = JsonConvert.DeserializeObject<List<Tarea>>(stringCR);
        mgTarea.Visible = true;
        tareaLabel.Visible = true;
        mgTarea.DataSource = tareas;
      }
    }

    private void mgTarea_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgTarea.Columns[e.ColumnIndex].Name == "Agregar" && e.RowIndex >= 0)
      {
        CargarHorasForm cargarHorasForm = new CargarHorasForm();
        cargarHorasForm.IdTarea = int.Parse(mgTarea.Rows[e.RowIndex].Cells["IdTarea"].Value.ToString());
        cargarHorasForm.IdProyecto = int.Parse(mgTarea.Rows[e.RowIndex].Cells["ProyectoIdProyecto"].Value.ToString());
        cargarHorasForm.IdPerfil = int.Parse(mgTarea.Rows[e.RowIndex].Cells["PerfilEmpleadoIdPerfil"].Value.ToString());
        cargarHorasForm.ShowDialog();
      }

      if (e.ColumnIndex >= 0 && this.mgTarea.Columns[e.ColumnIndex].Name == "Horas Trabajadas" && e.RowIndex >= 0)
      {
        int IdPerfilEmpl = int.Parse(mgTarea.Rows[e.RowIndex].Cells["PerfilEmpleadoIdPerfil"].Value.ToString());
        int IdProyecto = int.Parse(mgTarea.Rows[e.RowIndex].Cells["ProyectoIdProyecto"].Value.ToString());
        VerHorasForm verHorasForm = new VerHorasForm(IdPerfilEmpl, IdProyecto);
        verHorasForm.ShowDialog();
      }
    }

    private void ucMiPanel_Load(object sender, EventArgs e)
    {
      getProyectos();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
      getProyectos();
    }
  }
}


