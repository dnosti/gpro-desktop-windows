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
    private bool hayDatos = false;

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

      HttpResponseMessage response = HttpUtils.getHorasTrabajadas(Settings.Default.Client, "/horatrabajadas/empleado/", payload);

      string stringCR = response.Content.ReadAsStringAsync().Result;

      horasTrabajadas = JsonConvert.DeserializeObject<HoraTrabajada>(stringCR);

      if (response.IsSuccessStatusCode)
      {
        mgHorasTrab.DataSource = horasTrabajadas.SumaPorPerfil;
        this.mgHorasTrab.Columns["ValorHora"].DefaultCellStyle.Format = "c";

        if (horasTrabajadas.SumaPorPerfil.Count > 0)
          hayDatos = true;
      }
    }

    private void VerHorasForm_Load(object sender, EventArgs e)
    {
      if (!hayDatos)
      {
        DialogResult result = MessageBox.Show("No hay horas trabajadas en este proyecto.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (result == DialogResult.OK)
          this.Close();
      }
    }
  }
}
