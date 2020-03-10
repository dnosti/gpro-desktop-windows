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
  public partial class CrearTareaForm : MetroFramework.Forms.MetroForm
  {
    public CrearTareaForm()
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
        DialogResult result = MessageBox.Show("¿Está seguro de asignar la tarea al proyecto?", "Asignar Tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
          postTarea();
      }

    }

    private void getEmpleados()
    {
      List<Empleado> empleadoResponses = null;
      HttpResponseMessage response = HttpUtils.getEmpleados(Settings.Default.Client, "/empleado/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        empleadoResponses = JsonConvert.DeserializeObject<List<Empleado>>(stringCR);
        ComboBoxEmpleado.DataSource = empleadoResponses.OrderBy(x => x.FullName).ToList();
        ComboBoxEmpleado.DisplayMember = "FullName";
        ComboBoxEmpleado.ValueMember = "IdEmpleado";
      }
    }

    private void getProyectos()
    {
      List<ProyectoResponse> proyectoResponses = null;
      HttpResponseMessage response = HttpUtils.getProyectos(Settings.Default.Client, "/proyectos/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        proyectoResponses = JsonConvert.DeserializeObject<List<ProyectoResponse>>(stringCR);
        ComboBoxProyecto.DataSource = proyectoResponses.OrderBy(x => x.TituloProyecto).ToList();
        ComboBoxProyecto.DisplayMember = "TituloProyecto";
        ComboBoxProyecto.ValueMember = "IdProyecto";
      }
    }

    private void getPerfiles()
    {
      List<Perfil> perfilResponses = null;
      HttpResponseMessage response = HttpUtils.getPerfiles(Settings.Default.Client, "/perfiles/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        perfilResponses = JsonConvert.DeserializeObject<List<Perfil>>(stringCR);
        ComboBoxPerfiles.DataSource = perfilResponses.OrderBy(x => x.DescripcionPerfil).ToList();
        ComboBoxPerfiles.DisplayMember = "DescripcionPerfil";
        ComboBoxPerfiles.ValueMember = "IdPerfil";
      }
    }

    private bool ValidarCampos()
    {
      bool ok = true;

      if (string.IsNullOrEmpty(textBoxDescTarea.Text))
      {
        ok = false;
        errorProvider1.SetError(horasEstimadas, "Ingresar Descripción.");
      }
      return ok;
    }

    private void BorrarMensajeError()
    {
      errorProvider1.SetError(textBoxDescTarea, "");
    }

    private void postTarea()
    {
      Tarea tareaRequest = new Tarea()
      {
        ProyectoIdProyecto = int.Parse(ComboBoxProyecto.SelectedValue.ToString()),
        PerfilEmpleadoIdPerfil = int.Parse(ComboBoxPerfiles.SelectedValue.ToString()),
        PerfilEmpleadoIdEmpleado = int.Parse(ComboBoxEmpleado.SelectedValue.ToString()),
        DescripcionTarea = textBoxDescTarea.Text,
        HorasEstimadasTarea = int.Parse(horasEstimadas.Value.ToString())
      };

      HttpResponseMessage response = HttpUtils.postTarea(Settings.Default.Client, tareaRequest);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        MessageBox.Show("Tarea creada con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        foreach (MetroTextBox textBox in Controls.OfType<MetroTextBox>())
          textBox.Clear();
      }
      else
      {
        MessageBox.Show((string)responseMessage.message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void CrearTareaForm_Load(object sender, EventArgs e)
    {
      getEmpleados();
      getProyectos();
      getPerfiles();
    }

  }
}

