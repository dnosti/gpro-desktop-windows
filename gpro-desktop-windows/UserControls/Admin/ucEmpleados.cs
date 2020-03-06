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


namespace gpro_desktop_windows.UsersControls
{
  public partial class ucEmpleados : MetroFramework.Controls.MetroUserControl
  {
    public ucEmpleados()
    {
      InitializeComponent();
      mgEmpleados.Visible = false;

      /* Botón Editar en DataGrid */
      DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
      btnEditar.Name = "Editar";
      mgEmpleados.Columns.Add(btnEditar);
      mgEmpleados.Columns[11].HeaderText = "";

      /* Botón Ver en DataGrid */
      DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
      btnVer.Name = "Ver";
      mgEmpleados.Columns.Add(btnVer);
      mgEmpleados.Columns[12].HeaderText = "";

    }

    private void mgEmpleados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgEmpleados.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonEditar = this.mgEmpleados.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
        Icon icoEditar = Properties.Resources.editar;
        e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

        this.mgEmpleados.Rows[e.RowIndex].Height = icoEditar.Height + 8;
        this.mgEmpleados.Columns[e.ColumnIndex].Width = icoEditar.Width + 8;

        DataGridViewCell cell = this.mgEmpleados.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Editar";

        e.Handled = true;
      }

      if (e.ColumnIndex >= 0 && this.mgEmpleados.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonVer = this.mgEmpleados.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
        Icon icoVer = Properties.Resources.ver;
        e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

        this.mgEmpleados.Rows[e.RowIndex].Height = icoVer.Height + 8;
        this.mgEmpleados.Columns[e.ColumnIndex].Width = icoVer.Width + 8;

        DataGridViewCell cell = this.mgEmpleados.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Ver";

        e.Handled = true;
      }
    }

    private void mgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgEmpleados.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      {
        string IdEmpleado = mgEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString();
        EditarEmpleadoForm editarEmpleadoForm = new EditarEmpleadoForm(IdEmpleado);
        DataGridViewRow editarEmpleado = mgEmpleados.Rows[e.RowIndex];
        editarEmpleadoForm.textBoxApellidoEmpl.Text = editarEmpleado.Cells["apellidoEmpleado"].Value.ToString();
        editarEmpleadoForm.textBoxNombreEmpl.Text = editarEmpleado.Cells["nombreEmpleado"].Value.ToString();
        editarEmpleadoForm.textBoxFechaIngEmpl.Text = editarEmpleado.Cells["fechaIngreso"].Value.ToString();
        editarEmpleadoForm.textBoxDniEmpl.Text = editarEmpleado.Cells["Dni"].Value.ToString();
        editarEmpleadoForm.textBoxTelefonoEmpl.Text = editarEmpleado.Cells["Telefono"].Value.ToString();
        editarEmpleadoForm.textBoxDomicilioEmpl.Text = editarEmpleado.Cells["Domicilio"].Value.ToString();
        editarEmpleadoForm.textBoxLocalidadEmpl.Text = editarEmpleado.Cells["Localidad"].Value.ToString();
        editarEmpleadoForm.textBoxProvinciaEmpl.Text = editarEmpleado.Cells["Provincia"].Value.ToString();
        editarEmpleadoForm.textBoxNacionalidadEmpl.Text = editarEmpleado.Cells["Nacionalidad"].Value.ToString();
        editarEmpleadoForm.ShowDialog();
        string dni = editarEmpleadoForm.dni;
        if (!string.IsNullOrEmpty(dni))
          buscarEmpleado("/empleado/documento/", dni, true);
      }
      if (e.ColumnIndex >= 0 && this.mgEmpleados.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
      {
        VerEmpleadoForm verEmpleadoForm = new VerEmpleadoForm();
        DataGridViewRow verEmpleado = mgEmpleados.Rows[e.RowIndex];

        verEmpleadoForm.textBoxApellidoEmpl.Text = verEmpleado.Cells["apellidoEmpleado"].Value.ToString();
        verEmpleadoForm.textBoxNombreEmpl.Text = verEmpleado.Cells["nombreEmpleado"].Value.ToString();
        verEmpleadoForm.textBoxFechaIngEmpl.Text = verEmpleado.Cells["fechaIngreso"].Value.ToString();
        verEmpleadoForm.textBoxDniEmpl.Text = verEmpleado.Cells["Dni"].Value.ToString();
        verEmpleadoForm.textBoxTelefonoEmpl.Text = verEmpleado.Cells["Telefono"].Value.ToString();
        verEmpleadoForm.textBoxDomicilioEmpl.Text = verEmpleado.Cells["Domicilio"].Value.ToString();
        verEmpleadoForm.textBoxLocalidadEmpl.Text = verEmpleado.Cells["Localidad"].Value.ToString();
        verEmpleadoForm.textBoxProvinciaEmpl.Text = verEmpleado.Cells["Provincia"].Value.ToString();
        verEmpleadoForm.textBoxNacionalidadEmpl.Text = verEmpleado.Cells["Nacionalidad"].Value.ToString();
        verEmpleadoForm.Show();
      }
    }

    private void btnCrearEmpleado_Click(object sender, EventArgs e)
    {

      CrearEmpleadoForm crearEmpleadoForm = new CrearEmpleadoForm();
      crearEmpleadoForm.ShowDialog();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      textBoxDato.Clear();
      textBoxDNI.Clear();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      string path = "";
      string payload = "";
      bool getbydni = false;

      if (string.IsNullOrEmpty(textBoxDato.Text) && string.IsNullOrEmpty(textBoxDNI.Text))
      {
        MessageBox.Show(this,"Complete el formulario para realizar la búsqueda.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (string.IsNullOrEmpty(textBoxDNI.Text))
      {
        path = "/empleado/empleados/";
        payload = textBoxDato.Text;
        buscarEmpleado(path, payload, getbydni);
      }
      else
      {
        path = "/empleado/documento/";
        payload = textBoxDNI.Text;
        if (!payload.All(char.IsDigit))
        {
          MessageBox.Show("En DNI solo ingrese números.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }
        getbydni = true;
        buscarEmpleado(path, payload, getbydni);
      }
    }

    private void buscarEmpleado(string path, string payload, bool getbydni)
    {
      Empleado empleadoResponse = null;
      List<Empleado> empleadoResponses = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getEmpleado(client, path, payload);

      string stringER = response.Content.ReadAsStringAsync().Result;

      if (getbydni)
      {
        empleadoResponse = JsonConvert.DeserializeObject<Empleado>(stringER);
        empleadoResponses = new List<Empleado>();
        empleadoResponses.Add(empleadoResponse);
      }
      else
      {
        empleadoResponses = JsonConvert.DeserializeObject<List<Empleado>>(stringER);
      }

      if (response.IsSuccessStatusCode)
      {
        mgEmpleados.Visible = true;
        if (getbydni) { mgEmpleados.DataSource = empleadoResponses; }
        else { mgEmpleados.DataSource = empleadoResponses; }
      }
      else
      {
        MessageBox.Show("No se encontró el empleado.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textBoxDato.Clear(); textBoxDNI.Clear();
      }
    }

    private void btnVerTodosEmpleados_Click(object sender, EventArgs e)
    {
      getEmpleados();
    }

    private void getEmpleados()
    {
      List<Empleado> empleadoResponses = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getEmpleados(client, "/empleado/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        mgEmpleados.Visible = true;
        empleadoResponses = JsonConvert.DeserializeObject<List<Empleado>>(stringCR);
        mgEmpleados.DataSource = empleadoResponses;
      }
      else
      {
        MessageBox.Show("No se encontraron empleados.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}


