using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using gpro_desktop_windows.Models;
using gpro_desktop_windows.Utils;
using System.Text.RegularExpressions;

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
      this.Close();
    }

    private void btnConfirmar_Click(object sender, EventArgs e)
    {
      BorrarMensajeError();
      if (ValidarCampos())
        postCliente();
    }

    private bool ValidarCampos()
    {
      bool ok = true;

      if (string.IsNullOrEmpty(textBoxidCliente.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxidCliente, "Ingresar CUIT.");
      }

      if (!textBoxidCliente.Text.All(char.IsDigit))
      {
        ok = false;
        errorProvider1.SetError(textBoxidCliente, "Ingresar solo números.");
      }

      if (string.IsNullOrEmpty(textBoxRSocial.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxRSocial, "Ingresar Razón Social.");
      }
      if (string.IsNullOrEmpty(textBoxApellido.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxApellido, "Ingresar Apellido.");
      }
      if (string.IsNullOrEmpty(textBoxNombre.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxNombre, "Ingresar Nombre.");
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

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.postCliente(client, clienteRequest);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        MessageBox.Show("Cliente creado con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        foreach (TextBox textBox in Controls.OfType<TextBox>())
          textBox.Clear();
      }
      else
      {
        MessageBox.Show((string)responseMessage.message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}

