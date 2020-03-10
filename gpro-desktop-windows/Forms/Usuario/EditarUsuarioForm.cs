using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using gpro_desktop_windows.Models;
using gpro_desktop_windows.Utils;
using System.Text.RegularExpressions;
using MetroFramework;
using MetroFramework.Controls;
using System.Collections.Generic;
using Newtonsoft.Json;
using gpro_desktop_windows.Properties;

namespace gpro_desktop_windows.Forms
{
  public partial class EditarUsuarioForm : MetroFramework.Forms.MetroForm
  {
    private int id;
    private int idEmpleado;
    private string role = "";
    public bool okUpdate = false;

    public EditarUsuarioForm(string id, string idEmpleado, string role)
    {
      InitializeComponent();
      this.id = int.Parse(id);
      this.idEmpleado = int.Parse(idEmpleado);
      this.role = role;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }

    private void btnConfirmar_Click(object sender, EventArgs e)
    {
      BorrarMensajeError();
      if (ValidarCampos())
      {
        DialogResult result = MessageBox.Show("¿Está seguro de actualizar los datos?", "Editar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes) {; }
        putUsuario(id);
      }

    }

    private bool ValidarCampos()
    {
      bool ok = true;

      if (string.IsNullOrEmpty(textBoxUsuario.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxUsuario, "Ingresar Username.");
      }

      if (string.IsNullOrEmpty(textBoxPassword.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxPassword, "Ingresar Password.");
      }
      return ok;
    }

    private void BorrarMensajeError()
    {
      errorProvider1.SetError(textBoxUsuario, "");
      errorProvider1.SetError(textBoxPassword, "");
    }

    private void GetRoles()
    {
      List<Role> roleResponses = null;
      HttpResponseMessage response = HttpUtils.getEmpleados(Settings.Default.Client, "/rols/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        roleResponses = JsonConvert.DeserializeObject<List<Role>>(stringCR);
        ComboBoxRole.DataSource = roleResponses.OrderBy(x => x.Descripcion).ToList();
        ComboBoxRole.ValueMember = "Id";
        ComboBoxRole.DisplayMember = "Descripcion";
        //ComboBoxRole.SelectedValue = this.role;
      }
    }

    private void putUsuario(int id)
    {
      UsuarioRequest usuarioRequest = new UsuarioRequest()
      {
        Username = textBoxUsuario.Text,
        IdEmpleado = this.idEmpleado,
        IdRol = int.Parse(ComboBoxRole.SelectedValue.ToString()),
        Password = textBoxPassword.Text
      };

      HttpResponseMessage response = HttpUtils.putUsuario(Settings.Default.Client, id, usuarioRequest);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        DialogResult result = MessageBox.Show("Usuario actualizado con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (result == DialogResult.OK) { 
          okUpdate = true;
          this.Dispose();
        }
      }
      else
      {
        MessageBox.Show(this, (string)responseMessage.message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }

    private void EditarUsuarioForm_Load(object sender, EventArgs e)
    {
      GetRoles();
    }
  }
}

