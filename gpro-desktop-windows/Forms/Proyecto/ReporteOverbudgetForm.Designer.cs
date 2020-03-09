namespace gpro_desktop_windows.Forms
{
  partial class ReporteOverbudgetForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.reportViewerHorasOverbudget = new Microsoft.Reporting.WinForms.ReportViewer();
      this.btnCerrar = new MetroFramework.Controls.MetroButton();
      this.SuspendLayout();
      // 
      // reportViewerHorasOverbudget
      // 
      this.reportViewerHorasOverbudget.LocalReport.ReportEmbeddedResource = "gpro_desktop_windows.Forms.Proyecto.Report1.rdlc";
      this.reportViewerHorasOverbudget.Location = new System.Drawing.Point(27, 66);
      this.reportViewerHorasOverbudget.Name = "reportViewerHorasOverbudget";
      this.reportViewerHorasOverbudget.ServerReport.BearerToken = null;
      this.reportViewerHorasOverbudget.Size = new System.Drawing.Size(763, 290);
      this.reportViewerHorasOverbudget.TabIndex = 57;
      // 
      // btnCerrar
      // 
      this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnCerrar.Location = new System.Drawing.Point(666, 374);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(124, 34);
      this.btnCerrar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnCerrar.TabIndex = 49;
      this.btnCerrar.Text = "Cerrar";
      this.btnCerrar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnCerrar.UseSelectable = true;
      this.btnCerrar.UseStyleColors = true;
      this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
      // 
      // ReporteOverbudgetForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(817, 437);
      this.Controls.Add(this.reportViewerHorasOverbudget);
      this.Controls.Add(this.btnCerrar);
      this.MaximizeBox = false;
      this.Name = "ReporteOverbudgetForm";
      this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
      this.Text = "Horas Overbudget [Reporte Semanal]";
      this.Load += new System.EventHandler(this.InformeOverbudgetForm_Load);
      this.ResumeLayout(false);

    }

    #endregion
    private Microsoft.Reporting.WinForms.ReportViewer reportViewerHorasOverbudget;
    private MetroFramework.Controls.MetroButton btnCerrar;
  }
}