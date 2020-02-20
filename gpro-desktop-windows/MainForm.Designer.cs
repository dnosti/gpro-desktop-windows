namespace gpro_desktop_windows
{
  partial class MainForm
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
      this.metroPanelMF = new MetroFramework.Controls.MetroPanel();
      this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
      this.metroLabelRole = new MetroFramework.Controls.MetroLabel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.metroLabelUsername = new MetroFramework.Controls.MetroLabel();
      this.mlBack = new MetroFramework.Controls.MetroLink();
      this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
      this.btnSalirGpro = new MetroFramework.Controls.MetroButton();
      this.metroPanel2.SuspendLayout();
      this.metroPanel1.SuspendLayout();
      this.metroPanel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // metroPanelMF
      // 
      this.metroPanelMF.Dock = System.Windows.Forms.DockStyle.Fill;
      this.metroPanelMF.HorizontalScrollbarBarColor = true;
      this.metroPanelMF.HorizontalScrollbarHighlightOnWheel = false;
      this.metroPanelMF.HorizontalScrollbarSize = 10;
      this.metroPanelMF.Location = new System.Drawing.Point(20, 60);
      this.metroPanelMF.Name = "metroPanelMF";
      this.metroPanelMF.Size = new System.Drawing.Size(984, 520);
      this.metroPanelMF.TabIndex = 0;
      this.metroPanelMF.VerticalScrollbarBarColor = true;
      this.metroPanelMF.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanelMF.VerticalScrollbarSize = 10;
      // 
      // metroPanel2
      // 
      this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      this.metroPanel2.Controls.Add(this.metroLabelRole);
      this.metroPanel2.HorizontalScrollbarBarColor = true;
      this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
      this.metroPanel2.HorizontalScrollbarSize = 10;
      this.metroPanel2.Location = new System.Drawing.Point(31, 74);
      this.metroPanel2.Name = "metroPanel2";
      this.metroPanel2.Size = new System.Drawing.Size(177, 48);
      this.metroPanel2.TabIndex = 2;
      this.metroPanel2.UseCustomBackColor = true;
      this.metroPanel2.VerticalScrollbarBarColor = true;
      this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanel2.VerticalScrollbarSize = 10;
      // 
      // metroLabelRole
      // 
      this.metroLabelRole.AutoSize = true;
      this.metroLabelRole.BackColor = System.Drawing.Color.Transparent;
      this.metroLabelRole.ForeColor = System.Drawing.Color.White;
      this.metroLabelRole.Location = new System.Drawing.Point(8, 21);
      this.metroLabelRole.Name = "metroLabelRole";
      this.metroLabelRole.Size = new System.Drawing.Size(62, 19);
      this.metroLabelRole.TabIndex = 2;
      this.metroLabelRole.Text = "role: role";
      this.metroLabelRole.UseCustomBackColor = true;
      this.metroLabelRole.UseCustomForeColor = true;
      // 
      // metroPanel1
      // 
      this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      this.metroPanel1.Controls.Add(this.metroLabelUsername);
      this.metroPanel1.HorizontalScrollbarBarColor = true;
      this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
      this.metroPanel1.HorizontalScrollbarSize = 10;
      this.metroPanel1.Location = new System.Drawing.Point(31, 20);
      this.metroPanel1.Name = "metroPanel1";
      this.metroPanel1.Size = new System.Drawing.Size(177, 48);
      this.metroPanel1.TabIndex = 2;
      this.metroPanel1.UseCustomBackColor = true;
      this.metroPanel1.VerticalScrollbarBarColor = true;
      this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanel1.VerticalScrollbarSize = 10;
      // 
      // metroLabelUsername
      // 
      this.metroLabelUsername.AutoSize = true;
      this.metroLabelUsername.BackColor = System.Drawing.Color.Transparent;
      this.metroLabelUsername.ForeColor = System.Drawing.Color.White;
      this.metroLabelUsername.Location = new System.Drawing.Point(8, 21);
      this.metroLabelUsername.Name = "metroLabelUsername";
      this.metroLabelUsername.Size = new System.Drawing.Size(98, 19);
      this.metroLabelUsername.TabIndex = 2;
      this.metroLabelUsername.Text = "user: username";
      this.metroLabelUsername.UseCustomBackColor = true;
      this.metroLabelUsername.UseCustomForeColor = true;
      // 
      // mlBack
      // 
      this.mlBack.Cursor = System.Windows.Forms.Cursors.Default;
      this.mlBack.Location = new System.Drawing.Point(102, 27);
      this.mlBack.Name = "mlBack";
      this.mlBack.Size = new System.Drawing.Size(75, 23);
      this.mlBack.TabIndex = 1;
      this.mlBack.Text = "Volver";
      this.mlBack.UseSelectable = true;
      this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
      // 
      // metroPanel3
      // 
      this.metroPanel3.Controls.Add(this.btnSalirGpro);
      this.metroPanel3.Controls.Add(this.metroPanel1);
      this.metroPanel3.Controls.Add(this.metroPanel2);
      this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Right;
      this.metroPanel3.HorizontalScrollbarBarColor = true;
      this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
      this.metroPanel3.HorizontalScrollbarSize = 10;
      this.metroPanel3.Location = new System.Drawing.Point(780, 60);
      this.metroPanel3.Name = "metroPanel3";
      this.metroPanel3.Size = new System.Drawing.Size(224, 520);
      this.metroPanel3.TabIndex = 2;
      this.metroPanel3.VerticalScrollbarBarColor = true;
      this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanel3.VerticalScrollbarSize = 10;
      // 
      // btnSalirGpro
      // 
      this.btnSalirGpro.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnSalirGpro.Location = new System.Drawing.Point(31, 138);
      this.btnSalirGpro.Name = "btnSalirGpro";
      this.btnSalirGpro.Size = new System.Drawing.Size(177, 30);
      this.btnSalirGpro.TabIndex = 4;
      this.btnSalirGpro.Text = "Salir";
      this.btnSalirGpro.UseSelectable = true;
      this.btnSalirGpro.UseStyleColors = true;
      this.btnSalirGpro.Click += new System.EventHandler(this.btnSalirGpro_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1024, 600);
      this.Controls.Add(this.metroPanel3);
      this.Controls.Add(this.mlBack);
      this.Controls.Add(this.metroPanelMF);
      this.Name = "MainForm";
      this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
      this.Text = "GPRO";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.metroPanel2.ResumeLayout(false);
      this.metroPanel2.PerformLayout();
      this.metroPanel1.ResumeLayout(false);
      this.metroPanel1.PerformLayout();
      this.metroPanel3.ResumeLayout(false);
      this.ResumeLayout(false);

    }
    #endregion

    private MetroFramework.Controls.MetroPanel metroPanelMF;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    private MetroFramework.Controls.MetroLabel metroLabelUsername;
    private MetroFramework.Controls.MetroPanel metroPanel2;
    private MetroFramework.Controls.MetroLabel metroLabelRole;
    private MetroFramework.Controls.MetroLink mlBack;
    private MetroFramework.Controls.MetroPanel metroPanel3;
    private MetroFramework.Controls.MetroButton btnSalirGpro;
  }
}