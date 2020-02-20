using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpro_desktop_windows.UsersControls
{
  public partial class ucDashboard : MetroFramework.Controls.MetroUserControl
  {
    public ucDashboard()
    {
      InitializeComponent();
    }

    private void mtClientes_Click(object sender, EventArgs e)
    {
      if(!MainForm.Instance.MetroContainer.Controls.ContainsKey("ucClientes"))
      {
        ucCliente uc = new ucCliente();
        uc.Dock = DockStyle.Fill;
        MainForm.Instance.MetroContainer.Controls.Add(uc);
      }
      MainForm.Instance.MetroContainer.Controls["ucCliente"].BringToFront();
      MainForm.Instance.MetroBack.Visible = true;
    }
  }
}
