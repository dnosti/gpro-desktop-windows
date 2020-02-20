using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gpro_desktop_windows.Forms;

namespace gpro_desktop_windows.UsersControls
{
  public partial class ucCliente : MetroFramework.Controls.MetroUserControl
  {
    public ucCliente()
    {
      InitializeComponent();
    }

    private void btnCrearCliente_Click(object sender, EventArgs e)
    {
      CrearClienteForm crearClienteForm = new CrearClienteForm();
      crearClienteForm.Show();
    }
  }
}
