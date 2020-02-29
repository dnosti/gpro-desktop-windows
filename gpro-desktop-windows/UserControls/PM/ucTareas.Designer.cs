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
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
      this.ComboBoxProyecto = new MetroFramework.Controls.MetroComboBox();
      this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
      this.ComboBoxEmpleado = new MetroFramework.Controls.MetroComboBox();
      this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
      this.TextBoxDescripcion = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
      this.ComboBoxPerfiles = new MetroFramework.Controls.MetroComboBox();
      this.horasEstimadas = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.horasEstimadas)).BeginInit();
      this.SuspendLayout();
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(100, 108);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(64, 19);
      this.metroLabel1.TabIndex = 2;
      this.metroLabel1.Text = "Proyecto:";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(498, 108);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(108, 19);
      this.metroLabel2.TabIndex = 2;
      this.metroLabel2.Text = "Horas Estimadas:";
      // 
      // btnAsignar
      // 
      this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnAsignar.Location = new System.Drawing.Point(641, 389);
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
      this.btnLimpiar.Location = new System.Drawing.Point(766, 389);
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
      // ComboBoxProyecto
      // 
      this.ComboBoxProyecto.FormattingEnabled = true;
      this.ComboBoxProyecto.ItemHeight = 23;
      this.ComboBoxProyecto.Location = new System.Drawing.Point(100, 128);
      this.ComboBoxProyecto.Name = "ComboBoxProyecto";
      this.ComboBoxProyecto.Size = new System.Drawing.Size(377, 29);
      this.ComboBoxProyecto.TabIndex = 9;
      this.ComboBoxProyecto.UseSelectable = true;
      // 
      // metroLabel5
      // 
      this.metroLabel5.AutoSize = true;
      this.metroLabel5.Location = new System.Drawing.Point(100, 177);
      this.metroLabel5.Name = "metroLabel5";
      this.metroLabel5.Size = new System.Drawing.Size(72, 19);
      this.metroLabel5.TabIndex = 10;
      this.metroLabel5.Text = "Empleado:";
      // 
      // ComboBoxEmpleado
      // 
      this.ComboBoxEmpleado.FormattingEnabled = true;
      this.ComboBoxEmpleado.ItemHeight = 23;
      this.ComboBoxEmpleado.Location = new System.Drawing.Point(100, 197);
      this.ComboBoxEmpleado.Name = "ComboBoxEmpleado";
      this.ComboBoxEmpleado.Size = new System.Drawing.Size(377, 29);
      this.ComboBoxEmpleado.TabIndex = 11;
      this.ComboBoxEmpleado.UseSelectable = true;
      // 
      // metroLabel6
      // 
      this.metroLabel6.AutoSize = true;
      this.metroLabel6.Location = new System.Drawing.Point(100, 246);
      this.metroLabel6.Name = "metroLabel6";
      this.metroLabel6.Size = new System.Drawing.Size(114, 19);
      this.metroLabel6.TabIndex = 12;
      this.metroLabel6.Text = "Descripción Tarea:";
      // 
      // TextBoxDescripcion
      // 
      // 
      // 
      // 
      this.TextBoxDescripcion.CustomButton.Image = null;
      this.TextBoxDescripcion.CustomButton.Location = new System.Drawing.Point(295, 2);
      this.TextBoxDescripcion.CustomButton.Name = "";
      this.TextBoxDescripcion.CustomButton.Size = new System.Drawing.Size(79, 79);
      this.TextBoxDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.TextBoxDescripcion.CustomButton.TabIndex = 1;
      this.TextBoxDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.TextBoxDescripcion.CustomButton.UseSelectable = true;
      this.TextBoxDescripcion.CustomButton.Visible = false;
      this.TextBoxDescripcion.Lines = new string[0];
      this.TextBoxDescripcion.Location = new System.Drawing.Point(100, 268);
      this.TextBoxDescripcion.MaxLength = 32767;
      this.TextBoxDescripcion.Multiline = true;
      this.TextBoxDescripcion.Name = "TextBoxDescripcion";
      this.TextBoxDescripcion.PasswordChar = '\0';
      this.TextBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.TextBoxDescripcion.SelectedText = "";
      this.TextBoxDescripcion.SelectionLength = 0;
      this.TextBoxDescripcion.SelectionStart = 0;
      this.TextBoxDescripcion.ShortcutsEnabled = true;
      this.TextBoxDescripcion.Size = new System.Drawing.Size(377, 84);
      this.TextBoxDescripcion.TabIndex = 13;
      this.TextBoxDescripcion.UseSelectable = true;
      this.TextBoxDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.TextBoxDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroLabel7
      // 
      this.metroLabel7.AutoSize = true;
      this.metroLabel7.Location = new System.Drawing.Point(498, 177);
      this.metroLabel7.Name = "metroLabel7";
      this.metroLabel7.Size = new System.Drawing.Size(41, 19);
      this.metroLabel7.TabIndex = 14;
      this.metroLabel7.Text = "Perfil:";
      // 
      // ComboBoxPerfiles
      // 
      this.ComboBoxPerfiles.FormattingEnabled = true;
      this.ComboBoxPerfiles.ItemHeight = 23;
      this.ComboBoxPerfiles.Location = new System.Drawing.Point(498, 197);
      this.ComboBoxPerfiles.Name = "ComboBoxPerfiles";
      this.ComboBoxPerfiles.Size = new System.Drawing.Size(377, 29);
      this.ComboBoxPerfiles.TabIndex = 15;
      this.ComboBoxPerfiles.UseSelectable = true;
      // 
      // horasEstimadas
      // 
      this.horasEstimadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.horasEstimadas.Location = new System.Drawing.Point(498, 128);
      this.horasEstimadas.Name = "horasEstimadas";
      this.horasEstimadas.Size = new System.Drawing.Size(377, 29);
      this.horasEstimadas.TabIndex = 16;
      // 
      // ucTareas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.horasEstimadas);
      this.Controls.Add(this.metroLabel7);
      this.Controls.Add(this.ComboBoxPerfiles);
      this.Controls.Add(this.TextBoxDescripcion);
      this.Controls.Add(this.metroLabel6);
      this.Controls.Add(this.metroLabel5);
      this.Controls.Add(this.ComboBoxEmpleado);
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.btnAsignar);
      this.Controls.Add(this.metroLabel4);
      this.Controls.Add(this.ComboBoxProyecto);
      this.Name = "ucTareas";
      this.Size = new System.Drawing.Size(900, 742);
      this.Style = MetroFramework.MetroColorStyle.Blue;
      this.Theme = MetroFramework.MetroThemeStyle.Light;
      this.UseStyleColors = true;
      this.Load += new System.EventHandler(this.ucTareas_Load);
      ((System.ComponentModel.ISupportInitialize)(this.horasEstimadas)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroButton btnAsignar;
    private MetroFramework.Controls.MetroButton btnLimpiar;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    private MetroFramework.Controls.MetroLabel metroLabel4;
    private MetroFramework.Controls.MetroLabel metroLabel5;
    private MetroFramework.Controls.MetroComboBox ComboBoxEmpleado;
    private MetroFramework.Controls.MetroLabel metroLabel6;
    private MetroFramework.Controls.MetroTextBox TextBoxDescripcion;
    private MetroFramework.Controls.MetroLabel metroLabel7;
    private MetroFramework.Controls.MetroComboBox ComboBoxPerfiles;
    private System.Windows.Forms.NumericUpDown horasEstimadas;
    public MetroFramework.Controls.MetroComboBox ComboBoxProyecto;
  }
}
