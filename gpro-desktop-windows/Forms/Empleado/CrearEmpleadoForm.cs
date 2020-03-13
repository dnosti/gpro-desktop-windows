using gpro_desktop_windows.Models;
using gpro_desktop_windows.Properties;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpro_desktop_windows.Forms
{
  public partial class CrearEmpleadoForm : MetroFramework.Forms.MetroForm
  {
    public CrearEmpleadoForm()
    {
      InitializeComponent();
      textBoxFechaIngEmpl.MaxDate = DateTime.Today;
    }

    private bool ValidarCampos()
    {
      bool ok = true;

      if (string.IsNullOrEmpty(textBoxApellidoEmpl.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxApellidoEmpl, "Ingresar Apellido.");
      }

      if (!textBoxApellidoEmpl.Text.All(char.IsLetter))
      {
        ok = false;
        errorProvider1.SetError(textBoxApellidoEmpl, "Ingresar solo letras.");
      }

      if (string.IsNullOrEmpty(textBoxNombreEmpl.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxNombreEmpl, "Ingresar Nombre.");
      }

      if (!textBoxNombreEmpl.Text.All(char.IsLetter))
      {
        ok = false;
        errorProvider1.SetError(textBoxNombreEmpl, "Ingresar solo letras.");
      }

      if (string.IsNullOrEmpty(textBoxDniEmpl.Text) || textBoxDniEmpl.Text.Length < 6 || textBoxDniEmpl.Text.Length > 8)
      {
        ok = false;
        errorProvider1.SetError(textBoxDniEmpl, "Ingresar DNI.");
      }

      if (!textBoxDniEmpl.Text.All(char.IsDigit))
      {
        ok = false;
        errorProvider1.SetError(textBoxDniEmpl, "Ingrese solo números.");
      }

      if (string.IsNullOrEmpty(textBoxTelefonoEmpl.Text))
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

      if (!textBoxLocalidadEmpl.Text.All(char.IsLetter))
      {
        ok = false;
        errorProvider1.SetError(textBoxLocalidadEmpl, "Ingresar solo letras.");
      }

      if (string.IsNullOrEmpty(textBoxProvinciaEmpl.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxProvinciaEmpl, "Ingresar Provincia.");
      }

      if (!textBoxProvinciaEmpl.Text.All(char.IsLetter))
      {
        ok = false;
        errorProvider1.SetError(textBoxProvinciaEmpl, "Ingresar solo letras.");
      }

      if (string.IsNullOrEmpty(textBoxNacionalidadEmpl.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxNacionalidadEmpl, "Ingresar Nacionalidad.");
      }

      if (!textBoxNacionalidadEmpl.Text.All(char.IsLetter))
      {
        ok = false;
        errorProvider1.SetError(textBoxNacionalidadEmpl, "Ingresar solo letras.");
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
        DialogResult result = MessageBox.Show("¿Está seguro de crear un nuevo empleado?", "Crear Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
          postEmpleado();
      }
    }

    private void postEmpleado()
    {
      Empleado empleadoRequest = new Empleado()
      {
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

      HttpResponseMessage response = HttpUtils.postEmpleado(Settings.Default.Client, empleadoRequest);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        MessageBox.Show("Empleado creado con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
