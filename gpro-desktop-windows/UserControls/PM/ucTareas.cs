using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gpro_desktop_windows.Models;
using System.Net.Http;
using gpro_desktop_windows.Utils;
using Newtonsoft.Json;
using MetroFramework;
using gpro_desktop_windows.Forms;


namespace gpro_desktop_windows.UsersControls
{
  public partial class ucTareas : MetroFramework.Controls.MetroUserControl
  {
    public ucTareas()
    {
      InitializeComponent();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      TextBoxDescripcion.Clear();
      horasEstimadas.Value = 0;

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

    private void ucTareas_Load(object sender, EventArgs e)
    {
      getEmpleados();
      getProyectos();
      getPerfiles();
    }

    private void getProyectos()
    {
      List<Proyecto> proyectoResponses = null;
      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getProyectos(client, "/proyectos/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        proyectoResponses = JsonConvert.DeserializeObject<List<Proyecto>>(stringCR);
        ComboBoxProyecto.DataSource = proyectoResponses.OrderBy(x => x.TituloProyecto).ToList();
        ComboBoxProyecto.DisplayMember = "TituloProyecto";
        ComboBoxProyecto.ValueMember = "IdProyecto";
      }
    }

    private void getPerfiles()
    {
      List<Perfil> perfilResponses = null;
      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getPerfiles(client, "/perfiles/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        perfilResponses = JsonConvert.DeserializeObject<List<Perfil>>(stringCR);
        ComboBoxPerfiles.DataSource = perfilResponses.OrderBy(x => x.DescripcionPerfil).ToList();
        ComboBoxPerfiles.DisplayMember = "DescripcionPerfil";
        ComboBoxPerfiles.ValueMember = "IdPerfil";
      }
    }
  }
}


