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
  public partial class CrearLiquidacionForm : MetroFramework.Forms.MetroForm
  {
    public CrearLiquidacionForm()
    {
      InitializeComponent();
      fechaDesde.MaxDate = DateTime.Now;
      fechaHasta.MaxDate = DateTime.Now;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }

    private void btnConfirmar_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("¿Está seguro de crear la liquidación?", "Crear Liquidación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
        postLiquidacion();
    }

    private void getEmpleados()
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

    private void CrearLiquidacionForm_Load(object sender, EventArgs e)
    {
      getEmpleados();
    }

    private void postLiquidacion()
    {
      Liquidacion liquidacion = new Liquidacion()
      {
        IdEmpleado = int.Parse(ComboBoxEmpleado.SelectedValue.ToString()),
        FechaDesde = fechaDesde.Value.Date.ToString(),
        FechaHasta = fechaHasta.Value.Date.ToString()
      };

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.postLiquidacion(client, liquidacion);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        MessageBox.Show("Liquidación creada con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MessageBox.Show((string)responseMessage.message + ".", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}

