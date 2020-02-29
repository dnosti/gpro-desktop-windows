namespace gpro_desktop_windows.UsersControls
{
  partial class ucTareas
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
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.btnAsignar = new MetroFramework.Controls.MetroButton();
      this.btnLimpiar = new MetroFramework.Controls.MetroButton();
      this.textBoxProyecto = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.textBoxEstado = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
      this.SuspendLayout();
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(100, 108);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(61, 19);
      this.metroLabel1.TabIndex = 2;
      this.metroLabel1.Text = "Proyecto";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(498, 108);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(48, 19);
      this.metroLabel2.TabIndex = 2;
      this.metroLabel2.Text = "Estado";
      // 
      // btnAsignar
      // 
      this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnAsignar.Location = new System.Drawing.Point(642, 166);
      this.btnAsignar.Name = "btnAsignar";
      this.btnAsignar.Size = new System.Drawing.Size(107, 25);
      this.btnAsignar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnAsignar.TabIndex = 0;
      this.btnAsignar.Text = "Asignar Tarea";
      this.btnAsignar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnAsignar.UseSelectable = true;
      this.btnAsignar.UseStyleColors = true;
      // 
      // btnLimpiar
      // 
      this.btnLimpiar.Location = new System.Drawing.Point(767, 166);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new System.Drawing.Size(107, 25);
      this.btnLimpiar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnLimpiar.TabIndex = 0;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnLimpiar.UseSelectable = true;
      this.btnLimpiar.UseStyleColors = true;
      this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
      // 
      // textBoxProyecto
      // 
      // 
      // 
      // 
      this.textBoxProyecto.CustomButton.Image = null;
      this.textBoxProyecto.CustomButton.Location = new System.Drawing.Point(353, 1);
      this.textBoxProyecto.CustomButton.Name = "";
      this.textBoxProyecto.CustomButton.Size = new System.Drawing.Size(23, 23);
      this.textBoxProyecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxProyecto.CustomButton.TabIndex = 1;
      this.textBoxProyecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxProyecto.CustomButton.UseSelectable = true;
      this.textBoxProyecto.CustomButton.Visible = false;
      this.textBoxProyecto.Lines = new string[0];
      this.textBoxProyecto.Location = new System.Drawing.Point(100, 128);
      this.textBoxProyecto.MaxLength = 32767;
      this.textBoxProyecto.Name = "textBoxProyecto";
      this.textBoxProyecto.PasswordChar = '\0';
      this.textBoxProyecto.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxProyecto.SelectedText = "";
      this.textBoxProyecto.SelectionLength = 0;
      this.textBoxProyecto.SelectionStart = 0;
      this.textBoxProyecto.ShortcutsEnabled = true;
      this.textBoxProyecto.Size = new System.Drawing.Size(377, 25);
      this.textBoxProyecto.TabIndex = 3;
      this.textBoxProyecto.UseSelectable = true;
      this.textBoxProyecto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxProyecto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
      this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel3.ForeColor = System.Drawing.Color.Black;
      this.metroLabel3.Location = new System.Drawing.Point(741, 15);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(140, 25);
      this.metroLabel3.TabIndex = 5;
      this.metroLabel3.Text = "Gestión [ Tareas ]";
      this.metroLabel3.UseCustomBackColor = true;
      this.metroLabel3.UseCustomForeColor = true;
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
      this.metroPanel1.TabIndex = 6;
      this.metroPanel1.UseCustomBackColor = true;
      this.metroPanel1.VerticalScrollbarBarColor = true;
      this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanel1.VerticalScrollbarSize = 10;
      // 
      // textBoxEstado
      // 
      // 
      // 
      // 
      this.textBoxEstado.CustomButton.Image = null;
      this.textBoxEstado.CustomButton.Location = new System.Drawing.Point(353, 1);
      this.textBoxEstado.CustomButton.Name = "";
      this.textBoxEstado.CustomButton.Size = new System.Drawing.Size(23, 23);
      this.textBoxEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxEstado.CustomButton.TabIndex = 1;
      this.textBoxEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxEstado.CustomButton.UseSelectable = true;
      this.textBoxEstado.CustomButton.Visible = false;
      this.textBoxEstado.Lines = new string[0];
      this.textBoxEstado.Location = new System.Drawing.Point(498, 128);
      this.textBoxEstado.MaxLength = 32767;
      this.textBoxEstado.Name = "textBoxEstado";
      this.textBoxEstado.PasswordChar = '\0';
      this.textBoxEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxEstado.SelectedText = "";
      this.textBoxEstado.SelectionLength = 0;
      this.textBoxEstado.SelectionStart = 0;
      this.textBoxEstado.ShortcutsEnabled = true;
      this.textBoxEstado.Size = new System.Drawing.Size(377, 25);
      this.textBoxEstado.TabIndex = 7;
      this.textBoxEstado.UseSelectable = true;
      this.textBoxEstado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxEstado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroLabel4
      // 
      this.metroLabel4.AutoSize = true;
      this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
      this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel4.ForeColor = System.Drawing.Color.Black;
      this.metroLabel4.Location = new System.Drawing.Point(96, 66);
      this.metroLabel4.Name = "metroLabel4";
      this.metroLabel4.Size = new System.Drawing.Size(218, 25);
      this.metroLabel4.TabIndex = 8;
      this.metroLabel4.Text = "Asignar [ Tarea a Proyecto ]";
      this.metroLabel4.UseCustomBackColor = true;
      this.metroLabel4.UseCustomForeColor = true;
      // 
      // ucTareas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.textBoxEstado);
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.btnAsignar);
      this.Controls.Add(this.textBoxProyecto);
      this.Controls.Add(this.metroLabel4);
      this.Name = "ucTareas";
      this.Size = new System.Drawing.Size(900, 742);
      this.Style = MetroFramework.MetroColorStyle.Blue;
      this.Theme = MetroFramework.MetroThemeStyle.Light;
      this.UseStyleColors = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroButton btnAsignar;
    private MetroFramework.Controls.MetroButton btnLimpiar;
    private MetroFramework.Controls.MetroTextBox textBoxProyecto;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    private MetroFramework.Controls.MetroTextBox textBoxEstado;
    private MetroFramework.Controls.MetroLabel metroLabel4;
  }
}
