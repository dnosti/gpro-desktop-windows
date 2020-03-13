using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using gpro_desktop_windows.Models;
using gpro_desktop_windows.Utils;
using System.Text.RegularExpressions;
using MetroFramework;
using MetroFramework.Controls;
using gpro_desktop_windows.Properties;

namespace gpro_desktop_windows.Forms
{
  public partial class CrearClienteForm : MetroFramework.Forms.MetroForm
  {
    public CrearClienteForm()
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
        DialogResult result = MessageBox.Show("¿Está seguro de crear un nuevo cliente?", "Crear Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
          postCliente();
      }

    }

    private bool ValidarCampos()
    {
      bool ok = true;

      if (string.IsNullOrEmpty(textBoxidCliente.Text) || textBoxidCliente.Text.Length != 11)
      {
        ok = false;
        errorProvider1.SetError(textBoxidCliente, "Ingresar CUIT.");
      }

      if (!textBoxidCliente.Text.All(char.IsDigit))
      {
        ok = false;
        errorProvider1.SetError(textBoxidCliente, "Ingresar solo números.");
      }

      if (string.IsNullOrEmpty(textBoxRSocial.Text) && string.IsNullOrEmpty(textBoxApellido.Text) && string.IsNullOrEmpty(textBoxNombre.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxRSocial, "Ingresar Razón Social.");
      }

      if (!textBoxRSocial.Text.All(char.IsLetter))
      {
        ok = false;
        errorProvider1.SetError(textBoxRSocial, "Ingresar solo letras.");
      }

      if (string.IsNullOrEmpty(textBoxApellido.Text) && string.IsNullOrEmpty(textBoxRSocial.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxApellido, "Ingresar Apellido.");
      }

      if (!textBoxApellido.Text.All(char.IsLetter))
      {
        ok = false;
        errorProvider1.SetError(textBoxApellido, "Ingresar solo letras.");
      }

      if (string.IsNullOrEmpty(textBoxNombre.Text) && string.IsNullOrEmpty(textBoxRSocial.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxNombre, "Ingresar Nombre.");
      }

      if (!textBoxNombre.Text.All(char.IsLetter))
      {
        ok = false;
        errorProvider1.SetError(textBoxNombre, "Ingresar solo letras.");
      }

      if (string.IsNullOrEmpty(textBoxDomicilio.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxDomicilio, "Ingresar Domicilio.");
      }

      if (string.IsNullOrEmpty(textBoxTelefono.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxTelefono, "Ingresar Teléfono.");
      }

      if(!textBoxTelefono.Text.All(char.IsDigit))
      {
        ok = false;
        errorProvider1.SetError(textBoxTelefono, "Ingrese solo números.");
      }

      if (string.IsNullOrEmpty(textBoxEMail.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxEMail, "Ingresar E-Mail.");
      }

      else
      {
        Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        if (!reg.IsMatch(textBoxEMail.Text))
        {
          ok = false;
          errorProvider1.SetError(textBoxEMail, "Formato de email incorrecto.");
        }
      }
      return ok;
    }

    private void BorrarMensajeError()
    {
      errorProvider1.SetError(textBoxidCliente, "");
      errorProvider1.SetError(textBoxRSocial, "");
      errorProvider1.SetError(textBoxApellido, "");
      errorProvider1.SetError(textBoxNombre, "");
      errorProvider1.SetError(textBoxDomicilio, "");
      errorProvider1.SetError(textBoxTelefono, "");
      errorProvider1.SetError(textBoxEMail, "");
    }

    private void postCliente()
    {
      Cliente clienteRequest = new Cliente()
      {
        IdCliente = Int64.Parse(textBoxidCliente.Text),
        RazonSocialCliente = textBoxRSocial.Text,
        ApellidoCliente = textBoxApellido.Text,
        NombreCliente = textBoxNombre.Text,
        DireccionCliente = textBoxDomicilio.Text,
        TelefonoCliente = textBoxTelefono.Text,
        EmailCliente = textBoxEMail.Text
      };

      HttpResponseMessage response = HttpUtils.postCliente(Settings.Default.Client, clienteRequest);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        MessageBox.Show("Cliente creado con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        foreach (MetroTextBox textBox in Controls.OfType<MetroTextBox>())
          textBox.Clear();
      }
      else
      {
        MessageBox.Show((string)responseMessage.message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}

