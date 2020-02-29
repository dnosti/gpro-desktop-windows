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
  public partial class ucPM : MetroFramework.Controls.MetroUserControl
  {
    public ucPM()
    {
      InitializeComponent();
    }

    /*
    private void mtClientes_Click(object sender, EventArgs e)
    {
      if(!MainForm.Instance.MetroContainer.Controls.ContainsKey("ucClientes"))
      {
        ucClientes uc = new ucClientes();
        uc.Dock = DockStyle.Fill;
        MainForm.Instance.MetroContainer.Controls.Add(uc);
      }
      MainForm.Instance.MetroContainer.Controls["ucClientes"].BringToFront();
      MainForm.Instance.MetroBack.Visible = true;
    }

    private void mtEmpleados_Click(object sender, EventArgs e)
    {
      if (!MainForm.Instance.MetroContainer.Controls.ContainsKey("ucEmpleados"))
      {
        ucEmpleados uc = new ucEmpleados();
        uc.Dock = DockStyle.Fill;
        MainForm.Instance.MetroContainer.Controls.Add(uc);
      }
      MainForm.Instance.MetroContainer.Controls["ucEmpleados"].BringToFront();
      MainForm.Instance.MetroBack.Visible = true;
    }

    private void mtUsuarios_Click(object sender, EventArgs e)
    {
      if (!MainForm.Instance.MetroContainer.Controls.ContainsKey("ucUsuarios"))
      {
        ucUsuarios uc = new ucUsuarios();
        uc.Dock = DockStyle.Fill;
        MainForm.Instance.MetroContainer.Controls.Add(uc);
      }
      MainForm.Instance.MetroContainer.Controls["ucUsuarios"].BringToFront();
      MainForm.Instance.MetroBack.Visible = true;
    }
    */
  }
}
