using gpro_desktop_windows.Models;
using gpro_desktop_windows.Utils;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpro_desktop_windows.Forms
{
  public partial class EditarEmpleadoForm : MetroFramework.Forms.MetroForm
  {
    private string idEmpleado = "";

    public string dni { get; set; }

    public EditarEmpleadoForm(string idEmpleado)
    {
      InitializeComponent();
      this.idEmpleado = idEmpleado;
    }

    private bool ValidarCampos()
    {
      bool ok = true;

      if (string.IsNullOrEmpty(textBoxApellidoEmpl.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxApellidoEmpl, "Ingresar Apellido.");
      }

      if (string.IsNullOrEmpty(textBoxNombreEmpl.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxNombreEmpl, "Ingresar Nombre.");
      }

      if (string.IsNullOrEmpty(textBoxDniEmpl.Text) || textBoxDniEmpl.Text.Length < 6 || textBoxDniEmpl.Text.Length > 8)
      {
        ok = false;
        errorProvider1.SetError(textBoxDniEmpl, "Ingresar DNI.");
      }

      if (!textBoxDniEmpl.Text.All(char.IsDigit))
      {
        ok = false;
        errorProvider1.SetError(textBoxDniEmpl, "Ingresar solo números.");
      }

      if (string.IsNullOrEmpty(textBoxTelefonoEmpl.Text) || textBoxTelefonoEmpl.Text.Length != 10)
      {
        ok = false;
        errorProvider1.SetError(textBoxTelefonoEmpl, "Ingresar Teléfono.");
      }

      if (!textBoxTelefonoEmpl.Text.All(char.IsDigit))
      {
        ok = false;
        errorProvider1.SetError(textBoxTelefonoEmpl, "Ingrese solo números.");
      }

      if (string.IsNullOrEmpty(textBoxDomicilioEmpl.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxDomicilioEmpl, "Ingresar Domicilio.");
      }

      if (string.IsNullOrEmpty(textBoxLocalidadEmpl.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxLocalidadEmpl, "Ingresar Localidad.");
      }

      if (string.IsNullOrEmpty(textBoxProvinciaEmpl.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxProvinciaEmpl, "Ingresar Provincia.");
      }

      if (string.IsNullOrEmpty(textBoxNacionalidadEmpl.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxNacionalidadEmpl, "Ingresar Nacionalidad.");
      }

      if (!textBoxNacionalidadEmpl.Text.All(char.IsLetter))
      {
        ok = false;
        errorProvider1.SetError(textBoxNacionalidadEmpl, "Ingrese solo letras");
      }

      return ok;
    }

    private void BorrarMensajeError()
    {
      errorProvider1.SetError(textBoxApellidoEmpl, "");
      errorProvider1.SetError(textBoxNombreEmpl, "");
      errorProvider1.SetError(textBoxDniEmpl, "");
      errorProvider1.SetError(textBoxDomicilioEmpl, "");
      errorProvider1.SetError(textBoxTelefonoEmpl, "");
      errorProvider1.SetError(textBoxLocalidadEmpl, "");
      errorProvider1.SetError(textBoxProvinciaEmpl, "");
      errorProvider1.SetError(textBoxNacionalidadEmpl, "");
    }

    private void btnCancelar_Click_1(object sender, EventArgs e)
    {
      this.Dispose();
    }

    private void btnConfirmar_Click_1(object sender, EventArgs e)
    {
      BorrarMensajeError();
      if (ValidarCampos())
      {
        DialogResult result = MessageBox.Show("¿Está seguro de actualizar los datos?", "Editar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
          putEmpleado();
      }
    }

    private void putEmpleado()
    {
      Empleado empleadoRequest = new Empleado()
      {
        IdEmpleado = int.Parse(idEmpleado),
        ApellidoEmpleado = textBoxApellidoEmpl.Text,
        NombreEmpleado = textBoxNombreEmpl.Text,
        FechaIngreso = textBoxFechaIngEmpl.Value.Date,
        Dni = int.Parse(textBoxDniEmpl.Text),
        Telefono = textBoxTelefonoEmpl.Text,
        Domicilio = textBoxDomicilioEmpl.Text,
        Localidad = textBoxLocalidadEmpl.Text,
        Provincia = textBoxProvinciaEmpl.Text,
        Nacionalidad = textBoxNacionalidadEmpl.Text
      };

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.putEmpleado(client, empleadoRequest);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        DialogResult result = MessageBox.Show("Empleado actualizado con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (result == DialogResult.OK) { 
          dni = empleadoRequest.Dni.ToString();
          this.Dispose();
        }
      }
      else
      {
        MessageBox.Show((string)responseMessage.message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
