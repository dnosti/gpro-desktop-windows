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
      textBoxProyecto.Clear();
      textBoxEstado.Clear();
    }
  }
}


