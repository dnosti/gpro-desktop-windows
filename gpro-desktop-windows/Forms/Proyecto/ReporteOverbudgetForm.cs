using gpro_desktop_windows.Models;
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
  public partial class ReporteOverbudgetForm : MetroFramework.Forms.MetroForm
  {
    private string IdProyecto = "";

    public ReporteOverbudgetForm(string IdProyecto)
    {
      InitializeComponent();
      this.IdProyecto = IdProyecto;
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void InformeOverbudgetForm_Load(object sender, EventArgs e)
    {

      HoraTrabajada horasTrabajadas = null;

      string fechaInicio = DateTime.Today.AddDays(-7).ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz");
      string fechaFin = DateTime.Today.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz");

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getHorasTrabajadasFecha(client, "/horatrabajadas/overbudget/", this.IdProyecto, fechaInicio, fechaFin);

      string stringCR = response.Content.ReadAsStringAsync().Result;
      horasTrabajadas = JsonConvert.DeserializeObject<HoraTrabajada>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        var lista = horasTrabajadas.SumaPorPerfil;
        foreach (SumaPerfiles i in lista)
          i.HorasPerfil = i.HorasPerfil - 8;

        List<FechaReporteOverbudget> fechaReporte = new List<FechaReporteOverbudget>();
        fechaReporte.Add(new FechaReporteOverbudget() { FechaInicio = DateTime.Today.AddDays(-7).ToString("dd-MM-yyyy"), FechaFin = DateTime.Today.ToString("dd-MM-yyyy") });

        var reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
        var reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
        reportDataSource1.Name = "DataSet1";
        reportDataSource2.Name = "DataSet2";
        reportDataSource1.Value = lista;
        reportDataSource2.Value = fechaReporte;
        this.reportViewerHorasOverbudget.LocalReport.DataSources.Add(reportDataSource1);
        this.reportViewerHorasOverbudget.LocalReport.DataSources.Add(reportDataSource2);
        this.reportViewerHorasOverbudget.LocalReport.ReportEmbeddedResource = "gpro_desktop_windows.Reportes.ReporteHorasOverbudget.rdlc";
        this.reportViewerHorasOverbudget.RefreshReport();
      }
    }
  }
}
