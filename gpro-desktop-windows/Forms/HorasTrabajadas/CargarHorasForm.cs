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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpro_desktop_windows.Forms
{
  public partial class CargarHorasForm : MetroFramework.Forms.MetroForm
  {
    public int IdTarea;
    public int IdProyecto;
    public int IdPerfil;


    public CargarHorasForm()
    {
      InitializeComponent();
      fechaHoras.MaxDate = DateTime.Now;
    }


    private void btnCancelar_Click_1(object sender, EventArgs e)
    {
      this.Dispose();
    }

    private void btnConfirmar_Click_1(object sender, EventArgs e)
    {
      int horasoverbudget = 0;
      bool hayhorasob = false;
      if (cantidadHoras.Value > 8)
      {
        horasoverbudget = Decimal.ToInt32(cantidadHoras.Value) - 8;
        hayhorasob = true;
      }

      DialogResult result = MessageBox.Show(hayhorasob ? "Horas Overbudget: " + horasoverbudget.ToString() + "\n¿Está seguro de realizar la carga de horas trabajadas?" : "¿Está seguro de realizar la carga de horas trabajadas?", "Cargar Horas Trabajadas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
        postHorasTrabajadas();
    }

    private void postHorasTrabajadas()
    {
      HoraTrab horaTrab = new HoraTrab()
      {
        PerfilIdPerfil = IdPerfil,
        IdEmpleado = Settings.Default.IdEmpleado,
        ProyectoIdProyecto = IdProyecto,
        TareaIdTarea = IdTarea,
        CatidadHorasTrab = Decimal.ToInt32(cantidadHoras.Value),
        FechaHorasTrab = fechaHoras.Value,
        EstadoHorasTrab = "Adeudadas",
      };

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.postHorasTrabajadas(client, horaTrab);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      var responseMessage = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        MessageBox.Show("Horas cargadas con éxito!", "Wooh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Dispose();
      }
      else
      {
        MessageBox.Show((string)responseMessage.message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
