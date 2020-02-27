using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpro_desktop_windows.Forms
{
  public partial class VerUsuarioForm : MetroFramework.Forms.MetroForm
  {
    public VerUsuarioForm()
    {
      InitializeComponent();
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
