using gpro_desktop_windows.Models;
using gpro_desktop_windows.Properties;
using gpro_desktop_windows.Utils;
using MetroFramework.Controls;
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
  public partial class VerHorasForm : MetroFramework.Forms.MetroForm
  {
    private int IdPerfilEmpl;
    private int IdProyecto;
    
    public VerHorasForm(int IdPerfilEmpl, int IdProyecto)
    {
      InitializeComponent();
      this.IdPerfilEmpl = IdPerfilEmpl;
      this.IdProyecto = IdProyecto;
      getHorasTrabajadas();
    }

    private void btnCancelar_Click_1(object sender, EventArgs e)
    {
      this.Dispose();
    }

    private void getHorasTrabajadas()
    {
      HoraTrabajada horasTrabajadas = null;

      string payload = IdPerfilEmpl + "/" + IdProyecto;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getHorasTrabajadas(client, "/horatrabajadas/empleado/", payload);

      string stringCR = response.Content.ReadAsStringAsync().Result;

      horasTrabajadas = JsonConvert.DeserializeObject<HoraTrabajada>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        mgHorasTrab.DataSource = horasTrabajadas.SumaPorPerfil;
      }
    }
  }
}
