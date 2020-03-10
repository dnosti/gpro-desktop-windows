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
  public partial class EditarTareaForm : MetroFramework.Forms.MetroForm
  {

    public string id = "";
    private string idProyecto = "";
    private string idEmpleado = "";
    private string idPerfil = "";
    public bool okUpdate = false;


    public EditarTareaForm(string id, string idProyecto, string idEmpleado, string idPerfil)
    {
      InitializeComponent();
      this.id = id;
      this.idProyecto = idProyecto;
      this.idEmpleado = idEmpleado;
      this.idPerfil = idPerfil;
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
        DialogResult result = MessageBox.Show("¿Está seguro de actualizar los datos?", "Editar Tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
          putTarea();
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
        ComboBoxEmpleado.ValueMember = "IdEmpleado";
        ComboBoxEmpleado.DisplayMember = "FullName";
        ComboBoxEmpleado.SelectedValue = int.Parse(this.idEmpleado);
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
        ComboBoxProyecto.ValueMember = "IdProyecto";
        ComboBoxProyecto.DisplayMember = "TituloProyecto";
        ComboBoxProyecto.SelectedValue = int.Parse(idProyecto);
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
        ComboBoxPerfiles.ValueMember = "IdPerfil";
        ComboBoxPerfiles.DisplayMember = "DescripcionPerfil";
        ComboBoxPerfiles.SelectedValue = int.Parse(idPerfil);

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

    private void putTarea()
    {
      Tarea tareaRequest = new Tarea()
      {
        ProyectoIdProyecto = int.Parse(ComboBoxProyecto.SelectedValue.ToString()),
        IdTarea = int.Parse(this.id),
        PerfilEmpleadoIdPerfil = int.Parse(ComboBoxPerfiles.SelectedValue.ToString()),
        PerfilEmpleadoIdEmpleado = int.Parse(ComboBoxEmpleado.SelectedValue.ToString()),
        DescripcionTarea = textBoxDescTarea.Text,
        HorasEstimadasTarea = int.Parse(horasEstimadas.Value.ToString())
      };

      HttpResponseMessage response = HttpUtils.putTarea(Settings.Default.Client, tareaRequest);

      string stringTR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringTR);

      if (response.IsSuccessStatusCode)
      {
        DialogResult result = MessageBox.Show("Tarea actualizada con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (result == DialogResult.OK)
        {
          okUpdate = true;
          this.Dispose();
        }
      }
      else
      {
        MessageBox.Show((string)responseMessage.message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void EditarTareaForm_Load(object sender, EventArgs e)
    {
      getEmpleados();
      getProyectos();
      getPerfiles();
    }
  }
}

