namespace gpro_desktop_windows.UsersControls
{
  partial class ucMiembro
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
      this.mtProyectosMiembro = new MetroFramework.Controls.MetroTile();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.SuspendLayout();
      // 
      // mtProyectosMiembro
      // 
      this.mtProyectosMiembro.ActiveControl = null;
      this.mtProyectosMiembro.Cursor = System.Windows.Forms.Cursors.Hand;
      this.mtProyectosMiembro.Location = new System.Drawing.Point(100, 66);
      this.mtProyectosMiembro.Name = "mtProyectosMiembro";
      this.mtProyectosMiembro.Size = new System.Drawing.Size(456, 119);
      this.mtProyectosMiembro.TabIndex = 0;
      this.mtProyectosMiembro.Text = "Mis Proyectos";
      this.mtProyectosMiembro.UseSelectable = true;
      this.mtProyectosMiembro.Click += new System.EventHandler(this.mtProyectosMiembro_Click);
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
      // ucMiembro
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.mtProyectosMiembro);
      this.Name = "ucMiembro";
      this.Size = new System.Drawing.Size(900, 742);
      this.ResumeLayout(false);

    }

    #endregion

    private MetroFramework.Controls.MetroTile mtProyectosMiembro;
    private MetroFramework.Controls.MetroPanel metroPanel1;
  }
}
