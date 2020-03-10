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
      mgUsuarios.Columns[8].HeaderText = "";

      /* Botón Ver en DataGrid */
      DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
      btnVer.Name = "Ver";
      mgUsuarios.Columns.Add(btnVer);
      mgUsuarios.Columns[9].HeaderText = "";

      /* Botón Eliminar en DataGrid */
      DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
      btnEliminar.Name = "Eliminar";
      mgUsuarios.Columns.Add(btnEliminar);
      mgUsuarios.Columns[10].HeaderText = "";
    }

    private void mgEmpleados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgUsuarios.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonEditar = this.mgUsuarios.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
        Icon icoEditar = Properties.Resources.editar;
        e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 4, e.CellBounds.Top + 4);

        this.mgUsuarios.Rows[e.RowIndex].Height = icoEditar.Height + 8;
        this.mgUsuarios.Columns[e.ColumnIndex].Width = icoEditar.Width + 8;

        DataGridViewCell cell = this.mgUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Editar";

        e.Handled = true;
      }

      if (e.ColumnIndex >= 0 && this.mgUsuarios.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonVer = this.mgUsuarios.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
        Icon icoVer = Properties.Resources.ver;
        e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 4, e.CellBounds.Top + 4);

        this.mgUsuarios.Rows[e.RowIndex].Height = icoVer.Height + 8;
        this.mgUsuarios.Columns[e.ColumnIndex].Width = icoVer.Width + 8;

        DataGridViewCell cell = this.mgUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Ver";

        e.Handled = true;
      }

      if (e.ColumnIndex >= 0 && this.mgUsuarios.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonVer = this.mgUsuarios.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
        Icon icoEliminar = Properties.Resources.eliminar;
        e.Graphics.DrawIcon(icoEliminar, e.CellBounds.Left + 5, e.CellBounds.Top + 4);

        this.mgUsuarios.Rows[e.RowIndex].Height = icoEliminar.Height + 8;
        this.mgUsuarios.Columns[e.ColumnIndex].Width = icoEliminar.Width + 10;

        DataGridViewCell cell = this.mgUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Eliminar";

        e.Handled = true;
      }
    }

    private void mgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgUsuarios.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      {
        string IdUsuario = mgUsuarios.Rows[e.RowIndex].Cells["Id"].Value.ToString();
        string IdEmpleado = mgUsuarios.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString();
        string Role = mgUsuarios.Rows[e.RowIndex].Cells["DescripcionRole"].Value.ToString();
        string dni = mgUsuarios.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
        EditarUsuarioForm editarUsuarioForm = new EditarUsuarioForm(IdUsuario, IdEmpleado, Role);
        DataGridViewRow editarUsuario = mgUsuarios.Rows[e.RowIndex];

        editarUsuarioForm.textBoxEmpleado.Text = editarUsuario.Cells["apellidoEmpleado"].Value.ToString() + ", " + editarUsuario.Cells["nombreEmpleado"].Value.ToString();
        editarUsuarioForm.textBoxUsuario.Text = editarUsuario.Cells["Username"].Value.ToString();
        editarUsuarioForm.ShowDialog();
        if (editarUsuarioForm.okUpdate)
          buscarUsuario("/usuarios/dni/", dni, true);
      }
      if (e.ColumnIndex >= 0 && this.mgUsuarios.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
      {
        VerUsuarioForm verUsuarioForm = new VerUsuarioForm();
        DataGridViewRow verUsuario = mgUsuarios.Rows[e.RowIndex];

        verUsuarioForm.textBoxApellido.Text = verUsuario.Cells["apellidoEmpleado"].Value.ToString();
        verUsuarioForm.textBoxNombre.Text = verUsuario.Cells["nombreEmpleado"].Value.ToString();
        verUsuarioForm.textBoxDni.Text = verUsuario.Cells["Dni"].Value.ToString();
        verUsuarioForm.textBoxUsername.Text = verUsuario.Cells["Username"].Value.ToString();
        verUsuarioForm.textBoxRole.Text = verUsuario.Cells["DescripcionRole"].Value.ToString();
        verUsuarioForm.Show();
      }
      if (e.ColumnIndex >= 0 && this.mgUsuarios.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
      {
        int IdUsuario = int.Parse(mgUsuarios.Rows[e.RowIndex].Cells["Id"].Value.ToString());

        DialogResult result = MessageBox.Show("¿Está seguro de eliminar el usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
          if (deleteUsuario(IdUsuario)) mgUsuarios.Visible = false;
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
        MessageBox.Show(this, "Complete el formulario para realizar la búsqueda.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (string.IsNullOrEmpty(textBoxDNI.Text))
      {
        path = "/usuarios/apynom/";
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
      List<UsuarioResponse> usuarioResponses = null;

      HttpResponseMessage response = HttpUtils.getUsuario(Settings.Default.Client, path, payload);

      string stringER = response.Content.ReadAsStringAsync().Result;

      usuarioResponses = JsonConvert.DeserializeObject<List<UsuarioResponse>>(stringER);

      if (response.IsSuccessStatusCode)
      {
        mgUsuarios.Visible = true;
        mgUsuarios.DataSource = usuarioResponses;
      }
      else
      {
        MessageBox.Show("No se encontró el usuario.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textBoxDato.Clear(); textBoxDNI.Clear();
      }
    }

    private bool deleteUsuario(int id)
    {
      string path = "/usuarios/";
      HttpResponseMessage response = HttpUtils.deleteUsuario(Settings.Default.Client, path, id);

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        MessageBox.Show("Usuario eliminado con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return true;
      }
      else
      {
        MessageBox.Show("No se pudo eliminar el usuario.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
    }

    private void btnVerTodosUsuarios_Click(object sender, EventArgs e)
    {
      getUsuarios();
    }

    private void getUsuarios()
    {
      List<UsuarioResponse> usuarioResponses = null;

      HttpResponseMessage response = HttpUtils.getUsuarios(Settings.Default.Client, "/usuarios/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        mgUsuarios.Visible = true;
        usuarioResponses = JsonConvert.DeserializeObject<List<UsuarioResponse>>(stringCR);
        mgUsuarios.DataSource = usuarioResponses;
      }
      else
      {
        MessageBox.Show("No se encontraron usuarios.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}


