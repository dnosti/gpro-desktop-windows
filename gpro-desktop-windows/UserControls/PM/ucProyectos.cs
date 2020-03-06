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
  public partial class ucProyectos : MetroFramework.Controls.MetroUserControl
  {
    public ucProyectos()
    {
      InitializeComponent();
      mgProyectos.Visible = false;
      /* Botón Editar en DataGrid */
      DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
      btnEditar.Name = "Editar";
      mgProyectos.Columns.Add(btnEditar);
      mgProyectos.Columns[9].HeaderText = "";

      /* Botón Ver en DataGrid */
      DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
      btnVer.Name = "Ver";
      mgProyectos.Columns.Add(btnVer);
      mgProyectos.Columns[10].HeaderText = "";
    }

    private void mgProyectos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgProyectos.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonEditar = this.mgProyectos.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
        Icon icoEditar = Properties.Resources.editar;
        e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

        this.mgProyectos.Rows[e.RowIndex].Height = icoEditar.Height + 8;
        this.mgProyectos.Columns[e.ColumnIndex].Width = icoEditar.Width + 8;

        DataGridViewCell cell = this.mgProyectos.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Editar";

        e.Handled = true;
      }

      if (e.ColumnIndex >= 0 && this.mgProyectos.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonVer = this.mgProyectos.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
        Icon icoVer = Properties.Resources.ver;
        e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

        this.mgProyectos.Rows[e.RowIndex].Height = icoVer.Height + 8;
        this.mgProyectos.Columns[e.ColumnIndex].Width = icoVer.Width + 8;

        DataGridViewCell cell = this.mgProyectos.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Ver";

        e.Handled = true;
      }
    }

    private void mgProyectos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgProyectos.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      {
        string Id = mgProyectos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
        string IdCliente = mgProyectos.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString();
        string Estado = mgProyectos.Rows[e.RowIndex].Cells["EstadoProyecto"].Value.ToString();
        EditarProyectoForm editarProyectoForm = new EditarProyectoForm(Id, IdCliente, Estado);
        DataGridViewRow editarProyecto = mgProyectos.Rows[e.RowIndex];
        editarProyectoForm.textBoxTitulo.Text = editarProyecto.Cells["TituloProyecto"].Value.ToString();
        editarProyectoForm.textBoxDescProyecto.Text = editarProyecto.Cells["DescripciónProyecto"].Value.ToString();
        editarProyectoForm.ShowDialog();
        if (editarProyectoForm.okUpdate)
          buscarProyecto("/proyectos/porTitulo/", editarProyectoForm.tituloProyecto, false);
      }
      if (e.ColumnIndex >= 0 && this.mgProyectos.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
      {
        VerProyectoForm verProyectoForm = new VerProyectoForm();
        DataGridViewRow verProyecto = mgProyectos.Rows[e.RowIndex];

        verProyectoForm.textBoxProyecto.Text = verProyecto.Cells["TituloProyecto"].Value.ToString();
        verProyectoForm.textBoxDescripcion.Text = verProyecto.Cells["DescripciónProyecto"].Value.ToString();
        verProyectoForm.textBoxEstado.Text = verProyecto.Cells["EstadoProyecto"].Value.ToString();
        verProyectoForm.textBoxRSocial.Text = verProyecto.Cells["RazonSocialCliente"].Value.ToString();
        verProyectoForm.textBoxCliente.Text = verProyecto.Cells["ApellidoCliente"].Value.ToString() + ", " + verProyecto.Cells["NombreCliente"].Value.ToString();
        verProyectoForm.Show();
      }
    }

    private void btnCrearProyecto_Click(object sender, EventArgs e)
    {
      CrearProyectoForm crearProyectoForm = new CrearProyectoForm();
      crearProyectoForm.ShowDialog();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      textBoxProyecto.Clear();
      textBoxEstado.Clear();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      string path = "";
      string payload = "";
      bool getbyestado = false;

      if (string.IsNullOrEmpty(textBoxProyecto.Text) && string.IsNullOrEmpty(textBoxEstado.Text))
      {
        MessageBox.Show(this, "Complete el formulario para realizar la búsqueda.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (string.IsNullOrEmpty(textBoxEstado.Text))
      {
        path = "/proyectos/porTitulo/";
        payload = textBoxProyecto.Text;
        buscarProyecto(path, payload, getbyestado);
      }
      else
      {
        path = "/proyectos/porEstado/";
        payload = textBoxEstado.Text;
        getbyestado = true;
        buscarProyecto(path, payload, getbyestado);
      }
    }

    private void buscarProyecto(string path, string payload, bool getbyestado)
    {
      List<ProyectoResponse> proyectoResponses = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getProyecto(client, path, payload);

      string stringCR = response.Content.ReadAsStringAsync().Result;

      proyectoResponses = JsonConvert.DeserializeObject<List<ProyectoResponse>>(stringCR);


      if (response.IsSuccessStatusCode)
      {
        mgProyectos.Visible = true;
        mgProyectos.DataSource = proyectoResponses;
      }
      else
      {
        MessageBox.Show("No se encontró el proyecto.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textBoxProyecto.Clear(); textBoxEstado.Clear();
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
        mgProyectos.Visible = true;
        proyectoResponses = JsonConvert.DeserializeObject<List<ProyectoResponse>>(stringCR);
        mgProyectos.DataSource = proyectoResponses.Where(x => x.IdEmpleadoPm == Settings.Default.IdEmpleado).ToList();
      }
      else
      {
        MessageBox.Show("No se encontró el proyecto.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textBoxProyecto.Clear(); textBoxEstado.Clear();
      }
    }

    private void btnVerTodosProyectos_Click(object sender, EventArgs e)
    {
      getProyectos();
    }
  }
}


