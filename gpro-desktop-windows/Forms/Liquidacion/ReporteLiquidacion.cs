using gpro_desktop_windows.Models;
using gpro_desktop_windows.Utils;
using Microsoft.Reporting.WinForms;
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
  public partial class ReporteLiquidacionForm : MetroFramework.Forms.MetroForm
  {
    private List<Object> reporte;

    public ReporteLiquidacionForm(List<Object> reporte)
    {
      InitializeComponent();
      this.reporte = reporte;
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ReporteLiquidacionForm_Load(object sender, EventArgs e)
    {
      var reportDataSource1 = new ReportDataSource();
      reportDataSource1.Name = "DataSet1";
      reportDataSource1.Value = reporte;
      this.reportViewerHorasOverbudget.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewerHorasOverbudget.LocalReport.ReportEmbeddedResource = "gpro_desktop_windows.Reportes.ReporteLiquidacion.rdlc";
      this.reportViewerHorasOverbudget.RefreshReport();
    }
  }
}
