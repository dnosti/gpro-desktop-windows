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
  public partial class CrearProyectoForm : MetroFramework.Forms.MetroForm
  {
    public CrearProyectoForm()
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
        DialogResult result = MessageBox.Show("¿Está seguro de crear un nuevo proyecto?", "Crear Proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
          postProyecto();
      }

    }

    private bool ValidarCampos()
    {
      bool ok = true;

      if (string.IsNullOrEmpty(textBoxTitulo.Text))
      {
        ok = false;
        errorProvider1.SetError(textBoxTitulo, "Ingresar Título.");
      }

      return ok;
    }

    private void BorrarMensajeError()
    {
      errorProvider1.SetError(textBoxTitulo, "");
    }

    private void getClientes()
    {
      List<Cliente> clienteResponses = null;
      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getClientes(client, "/cliente/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        clienteResponses = JsonConvert.DeserializeObject<List<Cliente>>(stringCR);
        ComboBoxCliente.DataSource = clienteResponses.OrderBy(x => x.FullName).ToList();
        ComboBoxCliente.ValueMember = "Id";
        ComboBoxCliente.DisplayMember = "FullName";
      }
    }

    private void postProyecto()
    {
      ProyectoRequest usuarioRequest = new ProyectoRequest()
      {
        ClienteId = int.Parse(ComboBoxCliente.SelectedValue.ToString()),
        TituloProyecto = textBoxTitulo.Text,
        DescripcionProyecto = textBoxDescProyecto.Text,
        EstadoProyecto = "Vigente",
        IdEmpleadoPm = Settings.Default.IdEmpleado
      };

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.postProyecto(client, usuarioRequest);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        MessageBox.Show("Proyecto creado con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        foreach (MetroTextBox textBox in Controls.OfType<MetroTextBox>())
          textBox.Clear();
      }
      else
      {
        MessageBox.Show((string)responseMessage.message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void CrearProyectoForm_Load(object sender, EventArgs e)
    {
      getClientes();
    }
  }
}

