namespace gpro_desktop_windows.Forms
{
  partial class CrearTareaForm
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
      this.components = new System.ComponentModel.Container();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.btnCancelar = new MetroFramework.Controls.MetroButton();
      this.btnConfirmar = new MetroFramework.Controls.MetroButton();
      this.horasEstimadas = new System.Windows.Forms.NumericUpDown();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.ComboBoxPerfiles = new MetroFramework.Controls.MetroComboBox();
      this.textBoxDescTarea = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
      this.ComboBoxEmpleado = new MetroFramework.Controls.MetroComboBox();
      this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
      this.ComboBoxProyecto = new MetroFramework.Controls.MetroComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.horasEstimadas)).BeginInit();
      this.SuspendLayout();
      // 
      // errorProvider1
      // 
      this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider1.ContainerControl = this;
      // 
      // btnCancelar
      // 
      this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnCancelar.Location = new System.Drawing.Point(487, 343);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(124, 34);
      this.btnCancelar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnCancelar.TabIndex = 26;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnCancelar.UseSelectable = true;
      this.btnCancelar.UseStyleColors = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnConfirmar
      // 
      this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnConfirmar.Location = new System.Drawing.Point(631, 343);
      this.btnConfirmar.Name = "btnConfirmar";
      this.btnConfirmar.Size = new System.Drawing.Size(124, 34);
      this.btnConfirmar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnConfirmar.TabIndex = 27;
      this.btnConfirmar.Text = "Confirmar";
      this.btnConfirmar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnConfirmar.UseSelectable = true;
      this.btnConfirmar.UseStyleColors = true;
      this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
      // 
      // horasEstimadas
      // 
      this.horasEstimadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.horasEstimadas.Location = new System.Drawing.Point(415, 94);
      this.horasEstimadas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.horasEstimadas.Name = "horasEstimadas";
      this.horasEstimadas.Size = new System.Drawing.Size(340, 29);
      this.horasEstimadas.TabIndex = 45;
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.Location = new System.Drawing.Point(415, 143);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(41, 19);
      this.metroLabel3.TabIndex = 43;
      this.metroLabel3.Text = "Perfil:";
      // 
      // ComboBoxPerfiles
      // 
      this.ComboBoxPerfiles.FormattingEnabled = true;
      this.ComboBoxPerfiles.ItemHeight = 23;
      this.ComboBoxPerfiles.Location = new System.Drawing.Point(415, 163);
      this.ComboBoxPerfiles.Name = "ComboBoxPerfiles";
      this.ComboBoxPerfiles.Size = new System.Drawing.Size(340, 29);
      this.ComboBoxPerfiles.TabIndex = 44;
      this.ComboBoxPerfiles.UseSelectable = true;
      // 
      // textBoxDescTarea
      // 
      // 
      // 
      // 
      this.textBoxDescTarea.CustomButton.Image = null;
      this.textBoxDescTarea.CustomButton.Location = new System.Drawing.Point(258, 2);
      this.textBoxDescTarea.CustomButton.Name = "";
      this.textBoxDescTarea.CustomButton.Size = new System.Drawing.Size(79, 79);
      this.textBoxDescTarea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxDescTarea.CustomButton.TabIndex = 1;
      this.textBoxDescTarea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxDescTarea.CustomButton.UseSelectable = true;
      this.textBoxDescTarea.CustomButton.Visible = false;
      this.textBoxDescTarea.Lines = new string[0];
      this.textBoxDescTarea.Location = new System.Drawing.Point(27, 234);
      this.textBoxDescTarea.MaxLength = 250;
      this.textBoxDescTarea.Multiline = true;
      this.textBoxDescTarea.Name = "textBoxDescTarea";
      this.textBoxDescTarea.PasswordChar = '\0';
      this.textBoxDescTarea.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxDescTarea.SelectedText = "";
      this.textBoxDescTarea.SelectionLength = 0;
      this.textBoxDescTarea.SelectionStart = 0;
      this.textBoxDescTarea.ShortcutsEnabled = true;
      this.textBoxDescTarea.Size = new System.Drawing.Size(340, 84);
      this.textBoxDescTarea.TabIndex = 42;
      this.textBoxDescTarea.UseSelectable = true;
      this.textBoxDescTarea.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxDescTarea.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroLabel4
      // 
      this.metroLabel4.AutoSize = true;
      this.metroLabel4.Location = new System.Drawing.Point(27, 212);
      this.metroLabel4.Name = "metroLabel4";
      this.metroLabel4.Size = new System.Drawing.Size(114, 19);
      this.metroLabel4.TabIndex = 41;
      this.metroLabel4.Text = "Descripción Tarea:";
      // 
      // metroLabel5
      // 
      this.metroLabel5.AutoSize = true;
      this.metroLabel5.Location = new System.Drawing.Point(27, 143);
      this.metroLabel5.Name = "metroLabel5";
      this.metroLabel5.Size = new System.Drawing.Size(72, 19);
      this.metroLabel5.TabIndex = 39;
      this.metroLabel5.Text = "Empleado:";
      // 
      // ComboBoxEmpleado
      // 
      this.ComboBoxEmpleado.FormattingEnabled = true;
      this.ComboBoxEmpleado.ItemHeight = 23;
      this.ComboBoxEmpleado.Location = new System.Drawing.Point(27, 163);
      this.ComboBoxEmpleado.Name = "ComboBoxEmpleado";
      this.ComboBoxEmpleado.Size = new System.Drawing.Size(340, 29);
      this.ComboBoxEmpleado.TabIndex = 40;
      this.ComboBoxEmpleado.UseSelectable = true;
      // 
      // metroLabel8
      // 
      this.metroLabel8.AutoSize = true;
      this.metroLabel8.Location = new System.Drawing.Point(415, 74);
      this.metroLabel8.Name = "metroLabel8";
      this.metroLabel8.Size = new System.Drawing.Size(108, 19);
      this.metroLabel8.TabIndex = 36;
      this.metroLabel8.Text = "Horas Estimadas:";
      // 
      // metroLabel9
      // 
      this.metroLabel9.AutoSize = true;
      this.metroLabel9.Location = new System.Drawing.Point(27, 74);
      this.metroLabel9.Name = "metroLabel9";
      this.metroLabel9.Size = new System.Drawing.Size(64, 19);
      this.metroLabel9.TabIndex = 37;
      this.metroLabel9.Text = "Proyecto:";
      // 
      // ComboBoxProyecto
      // 
      this.ComboBoxProyecto.FormattingEnabled = true;
      this.ComboBoxProyecto.ItemHeight = 23;
      this.ComboBoxProyecto.Location = new System.Drawing.Point(27, 94);
      this.ComboBoxProyecto.Name = "ComboBoxProyecto";
      this.ComboBoxProyecto.Size = new System.Drawing.Size(340, 29);
      this.ComboBoxProyecto.TabIndex = 38;
      this.ComboBoxProyecto.UseSelectable = true;
      // 
      // CrearTareaForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(783, 403);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.textBoxDescTarea);
      this.Controls.Add(this.metroLabel4);
      this.Controls.Add(this.btnConfirmar);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.metroLabel9);
      this.Controls.Add(this.ComboBoxProyecto);
      this.Controls.Add(this.metroLabel5);
      this.Controls.Add(this.ComboBoxEmpleado);
      this.Controls.Add(this.metroLabel8);
      this.Controls.Add(this.horasEstimadas);
      this.Controls.Add(this.ComboBoxPerfiles);
      this.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.Name = "CrearTareaForm";
      this.ShowIcon = false;
      this.Text = "Crear Tarea";
      this.Load += new System.EventHandler(this.CrearTareaForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.horasEstimadas)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private MetroFramework.Controls.MetroButton btnCancelar;
    private MetroFramework.Controls.MetroButton btnConfirmar;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroTextBox textBoxDescTarea;
    private MetroFramework.Controls.MetroLabel metroLabel4;
    private MetroFramework.Controls.MetroLabel metroLabel9;
    public MetroFramework.Controls.MetroComboBox ComboBoxProyecto;
    private MetroFramework.Controls.MetroLabel metroLabel5;
    private MetroFramework.Controls.MetroLabel metroLabel8;
    private System.Windows.Forms.NumericUpDown horasEstimadas;
    private MetroFramework.Controls.MetroComboBox ComboBoxPerfiles;
    public MetroFramework.Controls.MetroComboBox ComboBoxEmpleado;
  }
}