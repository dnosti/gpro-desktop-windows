using gpro_desktop_windows.Models;
using gpro_desktop_windows.UsersControls;
using gpro_desktop_windows.Utils;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpro_desktop_windows.Forms
{
  public partial class EditarClienteForm : MetroFramework.Forms.MetroForm
  {
    private string id = "";

    public EditarClienteForm(string id)
    {
      InitializeComponent();
      this.id = id;
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
        DialogResult result = MessageBox.Show("¿Está seguro de actualizar los datos?", "Editar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
          putCliente();
        }
      }
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

    private void putCliente()
    {
      Cliente clienteRequest = new Cliente()
      {
        Id = int.Parse(id),
        IdCliente = Int64.Parse(textBoxidCliente.Text),
        RazonSocialCliente = textBoxRSocial.Text,
        ApellidoCliente = textBoxApellido.Text,
        NombreCliente = textBoxNombre.Text,
        DireccionCliente = textBoxDomicilio.Text,
        TelefonoCliente = textBoxTelefono.Text,
        EmailCliente = textBoxEMail.Text
      };

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.putCliente(client, clienteRequest);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        DialogResult result = MessageBox.Show("Cliente actualizado con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (result == DialogResult.OK)
          this.Dispose();
      }
      else
      {
        MessageBox.Show(this, (string)responseMessage.message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
