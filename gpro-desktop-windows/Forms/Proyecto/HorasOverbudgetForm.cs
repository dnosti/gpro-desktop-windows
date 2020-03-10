using gpro_desktop_windows.Models;
using gpro_desktop_windows.Properties;
using gpro_desktop_windows.Utils;
using Newtonsoft.Json;
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
  public partial class HorasOverbudgetForm : MetroFramework.Forms.MetroForm
  {
    private string IdProyecto = "";
    private bool hayDatos = false;

    public HorasOverbudgetForm(string IdProyecto)
    {
      InitializeComponent();
      this.IdProyecto = IdProyecto;
      getHorasOverbudget();
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void getHorasOverbudget()
    {
      HoraTrabajada horasTrabajadas = null;

      string fechaInicio = DateTime.Today.AddDays(-7).ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz");
      string fechaFin = DateTime.Today.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz");

      HttpResponseMessage response = HttpUtils.getHorasTrabajadasFecha(Settings.Default.Client, "/horatrabajadas/overbudget/", this.IdProyecto, fechaInicio, fechaFin);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      horasTrabajadas = JsonConvert.DeserializeObject<HoraTrabajada>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        var lista = horasTrabajadas.SumaPorPerfil;
        foreach (SumaPerfiles i in lista)
          i.HorasPerfil = i.HorasPerfil - 8;

        mgHorasOverbudget.DataSource = lista;

        if (horasTrabajadas.SumaPorPerfil.Count() > 0)
        {
          hayDatos = true;
          fechaDesde.Text = DateTime.Today.AddDays(-7).ToString("dd-MM-yyyy");
          fechaHasta.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }
      }
    }

    private void btnReporte_Click(object sender, EventArgs e)
    {
      if (hayDatos)
      {
        ReporteOverbudgetForm reporteOverbudgetForm = new ReporteOverbudgetForm(IdProyecto);
        reporteOverbudgetForm.ShowDialog();
      }
    }

    private void HorasOverbudgetForm_Load(object sender, EventArgs e)
    {
      if (!hayDatos) { 
        DialogResult result = MessageBox.Show("No hay horas overbudget en este proyecto.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (result == DialogResult.OK)
          this.Close();
      }
    }
  }
}
