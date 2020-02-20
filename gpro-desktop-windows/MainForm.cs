using gpro_desktop_windows.Properties;
using gpro_desktop_windows.UsersControls;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gpro_desktop_windows
{
  public partial class MainForm : MetroFramework.Forms.MetroForm
  {
    static MainForm _instance;
    public static MainForm Instance
    {
      get
      {
        if (_instance == null)
          _instance = new MainForm();
        return _instance;
      }
    }

    public MetroFramework.Controls.MetroPanel MetroContainer
    {
      get { return metroPanelMF; }
      set { metroPanelMF = value; }
    }

    
    public MetroFramework.Controls.MetroLink MetroBack
    {
      get { return mlBack; }
      set { mlBack = value; }
    }
    
    public MainForm()
    {
      InitializeComponent();
      metroLabelUsername.Text = "username: " + Settings.Default.Username;
      metroLabelRole.Text = "role: " + Settings.Default.Role;
      metroPanelMF.Focus();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      DialogResult result = MetroMessageBox.Show(this, "¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
      switch (result)
      {
        case DialogResult.Yes:
          Application.Exit();
          break;
        case DialogResult.No:
          break;
      }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      mlBack.Visible = false;
      _instance = this;
      ucDashboard uc = new ucDashboard();
      uc.Dock = DockStyle.Fill;
      metroPanelMF.Controls.Add(uc);
    }

    private void mlBack_Click(object sender, EventArgs e)
    {
      metroPanelMF.Controls["ucDashboard"].BringToFront();
      mlBack.Visible = false;
      metroPanelMF.Focus();
    }

    private void btnSalirGpro_Click(object sender, EventArgs e)
    {
      DialogResult result = MetroMessageBox.Show(this,"¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
      switch (result)
      {
        case DialogResult.Yes:
          Application.Exit();
          break;
        case DialogResult.No:
          break;
      }
    }
  }
}
