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
using System.Globalization;

namespace gpro_desktop_windows.Forms
{
  public partial class EditarProyectoForm : MetroFramework.Forms.MetroForm
  {
    private string idProyecto = "";
    private string idCliente = "";
    private string estado = "";
    public bool okUpdate = false;
    public string tituloProyecto = "";

    public EditarProyectoForm(string idProyecto, string idCliente, string estado)
    {
      InitializeComponent();
      this.idProyecto = idProyecto;
      this.idCliente = idCliente;
      this.estado = estado;
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
        DialogResult result = MessageBox.Show("¿Está seguro de actualizar los datos?", "Editar Proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
          putProyecto(idProyecto);
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
        ComboBoxCliente.SelectedValue = int.Parse(this.idCliente);
      }
    }

    private void putProyecto(string idProyecto)
    {
      ProyectoRequest proyectoRequest = new ProyectoRequest()
      {
        IdProyecto = int.Parse(idProyecto),
        ClienteId = int.Parse(ComboBoxCliente.SelectedValue.ToString()),
        TituloProyecto = textBoxTitulo.Text,
        DescripcionProyecto = textBoxDescProyecto.Text,
        EstadoProyecto = comboBoxEstado.SelectedItem.ToString(),
        IdEmpleadoPm = Settings.Default.IdEmpleado
      };

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.putProyecto(client, int.Parse(idProyecto), proyectoRequest);

      string stringPR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringPR);

      if (response.IsSuccessStatusCode)
      {
        DialogResult result = MessageBox.Show("Proyecto actualizado con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (result == DialogResult.OK)
        {
          okUpdate = true;
          tituloProyecto = textBoxTitulo.Text;
          this.Dispose();
        }
      }
      else
      {
        MessageBox.Show(this, (string)responseMessage.message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void EditarProyectoForm_Load(object sender, EventArgs e)
    {
      getClientes();
      comboBoxEstado.Items.Add("Cancelado");
      comboBoxEstado.Items.Add("No vigente");
      comboBoxEstado.Items.Add("Pausado");
      comboBoxEstado.Items.Add("Vigente");
      comboBoxEstado.SelectedItem = estado;
    }
  }
}

