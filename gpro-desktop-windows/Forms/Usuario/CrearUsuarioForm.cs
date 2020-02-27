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

namespace gpro_desktop_windows.Forms
{
  public partial class CrearUsuarioForm : MetroFramework.Forms.MetroForm
  {
    public CrearUsuarioForm()
    {
      InitializeComponent();
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
        DialogResult result = MessageBox.Show("¿Está seguro de crear un nuevo usuario?", "Crear Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes) {; }
        postUsuario();
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
      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getEmpleados(client, "/rols/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        roleResponses = JsonConvert.DeserializeObject<List<Role>>(stringCR);
        ComboBoxRole.DataSource = roleResponses.OrderBy(x => x.Descripcion).ToList();
        ComboBoxRole.ValueMember = "Id";
        ComboBoxRole.DisplayMember = "Descripcion";
      }
    }

    private void GetEmpleados()
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
      }
    }

    private void postUsuario()
    {
      UsuarioRequest usuarioRequest = new UsuarioRequest()
      {
        Username = textBoxUsuario.Text,
        IdEmpleado = int.Parse(ComboBoxEmpleado.SelectedValue.ToString()),
        IdRol = int.Parse(ComboBoxRole.SelectedValue.ToString()),
        Password = textBoxPassword.Text
      };

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.postUsuario(client, usuarioRequest);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        MessageBox.Show("Usuario creado con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        foreach (MetroTextBox textBox in Controls.OfType<MetroTextBox>())
          textBox.Clear();
      }
      else
      {
        MessageBox.Show((string)responseMessage.message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void CrearUsuarioForm_Load(object sender, EventArgs e)
    {
      GetEmpleados();
      GetRoles();
    }
  }
}

