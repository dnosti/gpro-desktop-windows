namespace gpro_desktop_windows.UsersControls
{
  partial class ucPM
  {
    /// <summary> 
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de componentes

    /// <summary> 
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.mtProyectos = new MetroFramework.Controls.MetroTile();
      this.mtTareas = new MetroFramework.Controls.MetroTile();
      this.mtMiPanel = new MetroFramework.Controls.MetroTile();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.SuspendLayout();
      // 
      // mtProyectos
      // 
      this.mtProyectos.ActiveControl = null;
      this.mtProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
      this.mtProyectos.Location = new System.Drawing.Point(100, 66);
      this.mtProyectos.Name = "mtProyectos";
      this.mtProyectos.Size = new System.Drawing.Size(456, 119);
      this.mtProyectos.TabIndex = 0;
      this.mtProyectos.Text = "Proyectos";
      this.mtProyectos.UseSelectable = true;
      // 
      // mtTareas
      // 
      this.mtTareas.ActiveControl = null;
      this.mtTareas.Cursor = System.Windows.Forms.Cursors.Hand;
      this.mtTareas.Location = new System.Drawing.Point(100, 205);
      this.mtTareas.Name = "mtTareas";
      this.mtTareas.Size = new System.Drawing.Size(456, 119);
      this.mtTareas.TabIndex = 0;
      this.mtTareas.Text = "Tareas";
      this.mtTareas.UseSelectable = true;
      // 
      // mtMiPanel
      // 
      this.mtMiPanel.ActiveControl = null;
      this.mtMiPanel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.mtMiPanel.Location = new System.Drawing.Point(100, 344);
      this.mtMiPanel.Name = "mtMiPanel";
      this.mtMiPanel.Size = new System.Drawing.Size(456, 119);
      this.mtMiPanel.TabIndex = 0;
      this.mtMiPanel.Text = "Mi Panel";
      this.mtMiPanel.UseSelectable = true;
      // 
      // metroPanel1
      // 
      this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      this.metroPanel1.HorizontalScrollbarBarColor = true;
      this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
      this.metroPanel1.HorizontalScrollbarSize = 10;
      this.metroPanel1.Location = new System.Drawing.Point(0, 0);
      this.metroPanel1.Name = "metroPanel1";
      this.metroPanel1.Size = new System.Drawing.Size(71, 775);
      this.metroPanel1.TabIndex = 7;
      this.metroPanel1.UseCustomBackColor = true;
      this.metroPanel1.VerticalScrollbarBarColor = true;
      this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanel1.VerticalScrollbarSize = 10;
      // 
      // ucPM
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.mtMiPanel);
      this.Controls.Add(this.mtTareas);
      this.Controls.Add(this.mtProyectos);
      this.Name = "ucPM";
      this.Size = new System.Drawing.Size(900, 742);
      this.ResumeLayout(false);

    }

    #endregion

    private MetroFramework.Controls.MetroTile mtProyectos;
    private MetroFramework.Controls.MetroTile mtTareas;
    private MetroFramework.Controls.MetroTile mtMiPanel;
    private MetroFramework.Controls.MetroPanel metroPanel1;
  }
}
