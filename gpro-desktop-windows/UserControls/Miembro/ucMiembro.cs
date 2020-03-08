using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gpro_desktop_windows.Properties;

namespace gpro_desktop_windows.UsersControls
{
  public partial class ucMiembro : MetroFramework.Controls.MetroUserControl
  {
    public ucMiembro()
    {
      InitializeComponent();
    }

    private void mtPanelMiembro_Click(object sender, EventArgs e)
    {
      if (!MainForm.Instance.MetroContainer.Controls.ContainsKey("ucMiPanel"))
      {
        ucMiPanel uc = new ucMiPanel();
        uc.Dock = DockStyle.Fill;
        MainForm.Instance.MetroContainer.Controls.Add(uc);
      }
      MainForm.Instance.MetroContainer.Controls["ucMiPanel"].BringToFront();
      MainForm.Instance.MetroBack.Visible = true;
    }
  }
}
