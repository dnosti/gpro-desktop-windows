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
  public partial class HorasTrabajadasForm : MetroFramework.Forms.MetroForm
  {
    private string IdProyecto = "";

    public HorasTrabajadasForm(string IdProyecto)
    {
      InitializeComponent();
      this.IdProyecto = IdProyecto;
      metroTabControl.SelectedTab = metroTabPagePerfil;
      fechaInicio.MaxDate = DateTime.Now;
      fechaFin.MaxDate = DateTime.Now;
      getHorasTrabajadas();
      getDetalles();
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void getHorasTrabajadas()
    {
      HoraTrabajada horasTrabajadas = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getHorasTrabajadas(client, "/horatrabajadas/porProy/", IdProyecto);

      string stringCR = response.Content.ReadAsStringAsync().Result;

      horasTrabajadas = JsonConvert.DeserializeObject<HoraTrabajada>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        mgPorPerfil.DataSource = horasTrabajadas.SumaPorPerfil;

        ComboBoxPerfiles.DataSource = (from t in horasTrabajadas.SumaPorPerfil
                                       select new { t.DescripcionPerfil, t.IdPerfil }).Distinct().ToList();
        ComboBoxPerfiles.ValueMember = "IdPerfil";
        ComboBoxPerfiles.DisplayMember = "DescripcionPerfil";
      }
    }

    private void getHorasPorPeriodo()
    {
      HtrabPorRecDto horasTrabajadas = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getHorasTrabajadasFecha(client, "/horatrabajadas/porfecha/", ComboBoxPerfiles.SelectedValue.ToString(), fechaInicio.Value.Date.ToString(("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")), fechaFin.Value.Date.ToString(("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")));

      string stringCR = response.Content.ReadAsStringAsync().Result;
      horasTrabajadas = JsonConvert.DeserializeObject<HtrabPorRecDto>(stringCR);

      if (response.IsSuccessStatusCode && horasTrabajadas.TotalHorasRec > 0)
      {
        DialogResult result = MessageBox.Show("Total de horas: " + horasTrabajadas.TotalHorasRec, "Horas Trabajadas por Período", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MessageBox.Show("No posee horas cargadas en ese período.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      if (ComboBoxPerfiles.SelectedIndex != -1)
        getHorasPorPeriodo();
    }

    private void getDetalles()
    {
      HoraTrabajada horasTrabajadas = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getHorasTrabajadas(client, "/horatrabajadas/porProy/", IdProyecto);

      string stringCR = response.Content.ReadAsStringAsync().Result;

      horasTrabajadas = JsonConvert.DeserializeObject<HoraTrabajada>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        var detalle = (from t in horasTrabajadas.SumaPorPerfil
                       select new
                       {
                         t.DescripcionPerfil,
                         t.IdPerfil,
                         t.HorasEstimadas,
                         t.HorasTotales,
                         HorasRestantes = t.HorasEstimadas - t.HorasTotales,
                         t.ValorHora,
                         t.EstadoHorasTrab
                       }).Distinct().ToList();

        mgDetalle.DataSource = detalle;

        tbHorasAdeudadas.Text = detalle.Sum(x => x.EstadoHorasTrab == "Adeudadas" ? x.HorasTotales : 0).ToString();
      }
    }
  }
}
