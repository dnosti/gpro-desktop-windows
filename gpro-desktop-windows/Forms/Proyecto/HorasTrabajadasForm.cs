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
  public partial class HorasTrabajadasForm: MetroFramework.Forms.MetroForm
  {
    private string IdProyecto = "";

    public HorasTrabajadasForm(string IdProyecto)
    {
      InitializeComponent();
      this.IdProyecto = IdProyecto;
      metroTabControl.SelectedTab = metroTabPagePerfil;
      getHorasTrabajadas();
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
      }
    }
  }
}
