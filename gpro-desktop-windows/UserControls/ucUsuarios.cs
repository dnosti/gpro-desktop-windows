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
  public partial class ucUsuarios : MetroFramework.Controls.MetroUserControl
  {
    public ucUsuarios()
    {
      InitializeComponent();
      mgUsuarios.Visible = false;

      /* Botón Editar en DataGrid */
      DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
      btnEditar.Name = "Editar";
      mgUsuarios.Columns.Add(btnEditar);
      mgUsuarios.Columns[7].HeaderText = "";

      /* Botón Ver en DataGrid */
      DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
      btnVer.Name = "Ver";
      mgUsuarios.Columns.Add(btnVer);
      mgUsuarios.Columns[8].HeaderText = "";

    }

    private void mgEmpleados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgUsuarios.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonEditar = this.mgUsuarios.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
        Icon icoEditar = Properties.Resources.editar;
        e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

        this.mgUsuarios.Rows[e.RowIndex].Height = icoEditar.Height + 8;
        this.mgUsuarios.Columns[e.ColumnIndex].Width = icoEditar.Width + 8;

        DataGridViewCell cell = this.mgUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Editar";

        e.Handled = true;
      }

      if (e.ColumnIndex >= 0 && this.mgUsuarios.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonVer = this.mgUsuarios.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
        Icon icoVer = Properties.Resources.ver;
        e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

        this.mgUsuarios.Rows[e.RowIndex].Height = icoVer.Height + 8;
        this.mgUsuarios.Columns[e.ColumnIndex].Width = icoVer.Width + 8;

        DataGridViewCell cell = this.mgUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Ver";

        e.Handled = true;
      }
    }

    private void mgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgUsuarios.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      {
        string IdEmpleado = mgUsuarios.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString();
        EditarEmpleadoForm editarEmpleadoForm = new EditarEmpleadoForm(IdEmpleado);
        DataGridViewRow editarEmpleado = mgUsuarios.Rows[e.RowIndex];
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
          buscarUsuario("/empleado/documento/", dni, true);
      }
      if (e.ColumnIndex >= 0 && this.mgUsuarios.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
      {
        VerUsuarioForm verUsuarioForm = new VerUsuarioForm();
        DataGridViewRow verUsuario = mgUsuarios.Rows[e.RowIndex];

        /*
        verEmpleadoForm.textBoxApellidoEmpl.Text = verEmpleado.Cells["apellidoEmpleado"].Value.ToString();
        verEmpleadoForm.textBoxNombreEmpl.Text = verEmpleado.Cells["nombreEmpleado"].Value.ToString();
        verEmpleadoForm.textBoxFechaIngEmpl.Text = verEmpleado.Cells["fechaIngreso"].Value.ToString();
        verEmpleadoForm.textBoxDniEmpl.Text = verEmpleado.Cells["Dni"].Value.ToString();
        verEmpleadoForm.textBoxTelefonoEmpl.Text = verEmpleado.Cells["Telefono"].Value.ToString();
        verEmpleadoForm.textBoxDomicilioEmpl.Text = verEmpleado.Cells["Domicilio"].Value.ToString();
        verEmpleadoForm.textBoxLocalidadEmpl.Text = verEmpleado.Cells["Localidad"].Value.ToString();
        verEmpleadoForm.textBoxProvinciaEmpl.Text = verEmpleado.Cells["Provincia"].Value.ToString();
        verEmpleadoForm.textBoxNacionalidadEmpl.Text = verEmpleado.Cells["Nacionalidad"].Value.ToString();ç
        */
        verUsuarioForm.Show();
      }
    }

    private void btnCrearUsuario_Click(object sender, EventArgs e)
    {
      CrearUsuarioForm crearUsuarioForm = new CrearUsuarioForm();
      crearUsuarioForm.ShowDialog();
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
        buscarUsuario(path, payload, getbydni);
      }
      else
      {
        path = "/usuarios/dni/";
        payload = textBoxDNI.Text;
        if (!payload.All(char.IsDigit))
        {
          MessageBox.Show("En DNI solo ingrese números.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }
        getbydni = true;
        buscarUsuario(path, payload, getbydni);
      }
    }

    private void buscarUsuario(string path, string payload, bool getbydni)
    {
      UsuarioResponse usuarioResponse = null;
      List<UsuarioResponse> usuarioResponses = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getUsuario(client, path, payload);

      string stringER = response.Content.ReadAsStringAsync().Result;

      usuarioResponses = JsonConvert.DeserializeObject<List<UsuarioResponse>>(stringER);
      /*
      if (getbydni)
      {
        usuarioResponse = JsonConvert.DeserializeObject<Usuario>(stringER);
        usuarioResponses = new List<Usuario>();
        usuarioResponses.Add(usuarioResponse);
      }
      else
      {
        usuarioResponses = JsonConvert.DeserializeObject<List<Usuario>>(stringER);
      }
      */
      if (response.IsSuccessStatusCode)
      {
        mgUsuarios.Visible = true;
        mgUsuarios.DataSource = usuarioResponses;
        /*
        if (getbydni) { mgUsuarios.DataSource = usuarioResponses; }
        else { mgUsuarios.DataSource = usuarioResponses; }
        */
      }
      else
      {
        MessageBox.Show("No se encontró el usuario.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textBoxDato.Clear(); textBoxDNI.Clear();
      }
    }
  }
}


