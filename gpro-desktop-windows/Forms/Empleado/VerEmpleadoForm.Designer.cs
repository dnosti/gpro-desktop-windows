namespace gpro_desktop_windows.Forms
{
  partial class VerEmpleadoForm
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
      this.Provincia = new MetroFramework.Controls.MetroLabel();
      this.Localidad = new MetroFramework.Controls.MetroLabel();
      this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.textBoxProvinciaEmpl = new MetroFramework.Controls.MetroTextBox();
      this.textBoxLocalidadEmpl = new MetroFramework.Controls.MetroTextBox();
      this.textBoxDomicilioEmpl = new MetroFramework.Controls.MetroTextBox();
      this.textBoxDniEmpl = new MetroFramework.Controls.MetroTextBox();
      this.textBoxNombreEmpl = new MetroFramework.Controls.MetroTextBox();
      this.textBoxApellidoEmpl = new MetroFramework.Controls.MetroTextBox();
      this.btnCerrar = new MetroFramework.Controls.MetroButton();
      this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
      this.textBoxTelefonoEmpl = new MetroFramework.Controls.MetroTextBox();
      this.metroLabelProv = new MetroFramework.Controls.MetroLabel();
      this.textBoxNacionalidadEmpl = new MetroFramework.Controls.MetroTextBox();
      this.textBoxFechaIngEmpl = new MetroFramework.Controls.MetroDateTime();
      this.SuspendLayout();
      // 
      // Provincia
      // 
      this.Provincia.AutoSize = true;
      this.Provincia.Location = new System.Drawing.Point(415, 212);
      this.Provincia.Name = "Provincia";
      this.Provincia.Size = new System.Drawing.Size(65, 19);
      this.Provincia.TabIndex = 48;
      this.Provincia.Text = "Provincia:";
      // 
      // Localidad
      // 
      this.Localidad.AutoSize = true;
      this.Localidad.Location = new System.Drawing.Point(415, 142);
      this.Localidad.Name = "Localidad";
      this.Localidad.Size = new System.Drawing.Size(68, 19);
      this.Localidad.TabIndex = 47;
      this.Localidad.Text = "Localidad:";
      // 
      // metroLabel7
      // 
      this.metroLabel7.AutoSize = true;
      this.metroLabel7.Location = new System.Drawing.Point(415, 74);
      this.metroLabel7.Name = "metroLabel7";
      this.metroLabel7.Size = new System.Drawing.Size(67, 19);
      this.metroLabel7.TabIndex = 46;
      this.metroLabel7.Text = "Domicilio:";
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.Location = new System.Drawing.Point(28, 280);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(34, 19);
      this.metroLabel3.TabIndex = 45;
      this.metroLabel3.Text = "DNI:";
      // 
      // metroLabel4
      // 
      this.metroLabel4.AutoSize = true;
      this.metroLabel4.Location = new System.Drawing.Point(28, 212);
      this.metroLabel4.Name = "metroLabel4";
      this.metroLabel4.Size = new System.Drawing.Size(112, 19);
      this.metroLabel4.TabIndex = 44;
      this.metroLabel4.Text = "Fecha de Ingreso:";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(28, 142);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(62, 19);
      this.metroLabel2.TabIndex = 43;
      this.metroLabel2.Text = "Nombre:";
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(28, 74);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(61, 19);
      this.metroLabel1.TabIndex = 42;
      this.metroLabel1.Text = "Apellido:";
      // 
      // textBoxProvinciaEmpl
      // 
      // 
      // 
      // 
      this.textBoxProvinciaEmpl.CustomButton.Image = null;
      this.textBoxProvinciaEmpl.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxProvinciaEmpl.CustomButton.Name = "";
      this.textBoxProvinciaEmpl.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxProvinciaEmpl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxProvinciaEmpl.CustomButton.TabIndex = 1;
      this.textBoxProvinciaEmpl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxProvinciaEmpl.CustomButton.UseSelectable = true;
      this.textBoxProvinciaEmpl.CustomButton.Visible = false;
      this.textBoxProvinciaEmpl.Enabled = false;
      this.textBoxProvinciaEmpl.Lines = new string[0];
      this.textBoxProvinciaEmpl.Location = new System.Drawing.Point(415, 235);
      this.textBoxProvinciaEmpl.MaxLength = 50;
      this.textBoxProvinciaEmpl.Name = "textBoxProvinciaEmpl";
      this.textBoxProvinciaEmpl.PasswordChar = '\0';
      this.textBoxProvinciaEmpl.ReadOnly = true;
      this.textBoxProvinciaEmpl.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxProvinciaEmpl.SelectedText = "";
      this.textBoxProvinciaEmpl.SelectionLength = 0;
      this.textBoxProvinciaEmpl.SelectionStart = 0;
      this.textBoxProvinciaEmpl.ShortcutsEnabled = true;
      this.textBoxProvinciaEmpl.Size = new System.Drawing.Size(341, 23);
      this.textBoxProvinciaEmpl.TabIndex = 41;
      this.textBoxProvinciaEmpl.UseSelectable = true;
      this.textBoxProvinciaEmpl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxProvinciaEmpl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxLocalidadEmpl
      // 
      // 
      // 
      // 
      this.textBoxLocalidadEmpl.CustomButton.Image = null;
      this.textBoxLocalidadEmpl.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxLocalidadEmpl.CustomButton.Name = "";
      this.textBoxLocalidadEmpl.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxLocalidadEmpl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxLocalidadEmpl.CustomButton.TabIndex = 1;
      this.textBoxLocalidadEmpl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxLocalidadEmpl.CustomButton.UseSelectable = true;
      this.textBoxLocalidadEmpl.CustomButton.Visible = false;
      this.textBoxLocalidadEmpl.Enabled = false;
      this.textBoxLocalidadEmpl.Lines = new string[0];
      this.textBoxLocalidadEmpl.Location = new System.Drawing.Point(415, 166);
      this.textBoxLocalidadEmpl.MaxLength = 50;
      this.textBoxLocalidadEmpl.Name = "textBoxLocalidadEmpl";
      this.textBoxLocalidadEmpl.PasswordChar = '\0';
      this.textBoxLocalidadEmpl.ReadOnly = true;
      this.textBoxLocalidadEmpl.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxLocalidadEmpl.SelectedText = "";
      this.textBoxLocalidadEmpl.SelectionLength = 0;
      this.textBoxLocalidadEmpl.SelectionStart = 0;
      this.textBoxLocalidadEmpl.ShortcutsEnabled = true;
      this.textBoxLocalidadEmpl.Size = new System.Drawing.Size(341, 23);
      this.textBoxLocalidadEmpl.TabIndex = 40;
      this.textBoxLocalidadEmpl.UseSelectable = true;
      this.textBoxLocalidadEmpl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxLocalidadEmpl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxDomicilioEmpl
      // 
      // 
      // 
      // 
      this.textBoxDomicilioEmpl.CustomButton.Image = null;
      this.textBoxDomicilioEmpl.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxDomicilioEmpl.CustomButton.Name = "";
      this.textBoxDomicilioEmpl.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxDomicilioEmpl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxDomicilioEmpl.CustomButton.TabIndex = 1;
      this.textBoxDomicilioEmpl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxDomicilioEmpl.CustomButton.UseSelectable = true;
      this.textBoxDomicilioEmpl.CustomButton.Visible = false;
      this.textBoxDomicilioEmpl.Enabled = false;
      this.textBoxDomicilioEmpl.Lines = new string[0];
      this.textBoxDomicilioEmpl.Location = new System.Drawing.Point(415, 97);
      this.textBoxDomicilioEmpl.MaxLength = 50;
      this.textBoxDomicilioEmpl.Name = "textBoxDomicilioEmpl";
      this.textBoxDomicilioEmpl.PasswordChar = '\0';
      this.textBoxDomicilioEmpl.ReadOnly = true;
      this.textBoxDomicilioEmpl.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxDomicilioEmpl.SelectedText = "";
      this.textBoxDomicilioEmpl.SelectionLength = 0;
      this.textBoxDomicilioEmpl.SelectionStart = 0;
      this.textBoxDomicilioEmpl.ShortcutsEnabled = true;
      this.textBoxDomicilioEmpl.Size = new System.Drawing.Size(341, 23);
      this.textBoxDomicilioEmpl.TabIndex = 39;
      this.textBoxDomicilioEmpl.UseSelectable = true;
      this.textBoxDomicilioEmpl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxDomicilioEmpl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxDniEmpl
      // 
      // 
      // 
      // 
      this.textBoxDniEmpl.CustomButton.Image = null;
      this.textBoxDniEmpl.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxDniEmpl.CustomButton.Name = "";
      this.textBoxDniEmpl.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxDniEmpl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxDniEmpl.CustomButton.TabIndex = 1;
      this.textBoxDniEmpl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxDniEmpl.CustomButton.UseSelectable = true;
      this.textBoxDniEmpl.CustomButton.Visible = false;
      this.textBoxDniEmpl.Enabled = false;
      this.textBoxDniEmpl.Lines = new string[0];
      this.textBoxDniEmpl.Location = new System.Drawing.Point(28, 302);
      this.textBoxDniEmpl.MaxLength = 50;
      this.textBoxDniEmpl.Name = "textBoxDniEmpl";
      this.textBoxDniEmpl.PasswordChar = '\0';
      this.textBoxDniEmpl.ReadOnly = true;
      this.textBoxDniEmpl.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxDniEmpl.SelectedText = "";
      this.textBoxDniEmpl.SelectionLength = 0;
      this.textBoxDniEmpl.SelectionStart = 0;
      this.textBoxDniEmpl.ShortcutsEnabled = true;
      this.textBoxDniEmpl.Size = new System.Drawing.Size(341, 23);
      this.textBoxDniEmpl.TabIndex = 38;
      this.textBoxDniEmpl.UseSelectable = true;
      this.textBoxDniEmpl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxDniEmpl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxNombreEmpl
      // 
      // 
      // 
      // 
      this.textBoxNombreEmpl.CustomButton.Image = null;
      this.textBoxNombreEmpl.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxNombreEmpl.CustomButton.Name = "";
      this.textBoxNombreEmpl.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxNombreEmpl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxNombreEmpl.CustomButton.TabIndex = 1;
      this.textBoxNombreEmpl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxNombreEmpl.CustomButton.UseSelectable = true;
      this.textBoxNombreEmpl.CustomButton.Visible = false;
      this.textBoxNombreEmpl.Enabled = false;
      this.textBoxNombreEmpl.Lines = new string[0];
      this.textBoxNombreEmpl.Location = new System.Drawing.Point(28, 166);
      this.textBoxNombreEmpl.MaxLength = 50;
      this.textBoxNombreEmpl.Name = "textBoxNombreEmpl";
      this.textBoxNombreEmpl.PasswordChar = '\0';
      this.textBoxNombreEmpl.ReadOnly = true;
      this.textBoxNombreEmpl.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxNombreEmpl.SelectedText = "";
      this.textBoxNombreEmpl.SelectionLength = 0;
      this.textBoxNombreEmpl.SelectionStart = 0;
      this.textBoxNombreEmpl.ShortcutsEnabled = true;
      this.textBoxNombreEmpl.Size = new System.Drawing.Size(341, 23);
      this.textBoxNombreEmpl.TabIndex = 36;
      this.textBoxNombreEmpl.UseSelectable = true;
      this.textBoxNombreEmpl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxNombreEmpl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxApellidoEmpl
      // 
      // 
      // 
      // 
      this.textBoxApellidoEmpl.CustomButton.Image = null;
      this.textBoxApellidoEmpl.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxApellidoEmpl.CustomButton.Name = "";
      this.textBoxApellidoEmpl.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxApellidoEmpl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxApellidoEmpl.CustomButton.TabIndex = 1;
      this.textBoxApellidoEmpl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxApellidoEmpl.CustomButton.UseSelectable = true;
      this.textBoxApellidoEmpl.CustomButton.Visible = false;
      this.textBoxApellidoEmpl.Enabled = false;
      this.textBoxApellidoEmpl.Lines = new string[0];
      this.textBoxApellidoEmpl.Location = new System.Drawing.Point(28, 97);
      this.textBoxApellidoEmpl.MaxLength = 50;
      this.textBoxApellidoEmpl.Name = "textBoxApellidoEmpl";
      this.textBoxApellidoEmpl.PasswordChar = '\0';
      this.textBoxApellidoEmpl.ReadOnly = true;
      this.textBoxApellidoEmpl.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxApellidoEmpl.SelectedText = "";
      this.textBoxApellidoEmpl.SelectionLength = 0;
      this.textBoxApellidoEmpl.SelectionStart = 0;
      this.textBoxApellidoEmpl.ShortcutsEnabled = true;
      this.textBoxApellidoEmpl.Size = new System.Drawing.Size(341, 23);
      this.textBoxApellidoEmpl.TabIndex = 35;
      this.textBoxApellidoEmpl.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxApellidoEmpl.UseSelectable = true;
      this.textBoxApellidoEmpl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxApellidoEmpl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // btnCerrar
      // 
      this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnCerrar.Location = new System.Drawing.Point(632, 394);
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
      // metroLabel8
      // 
      this.metroLabel8.AutoSize = true;
      this.metroLabel8.Location = new System.Drawing.Point(28, 346);
      this.metroLabel8.Name = "metroLabel8";
      this.metroLabel8.Size = new System.Drawing.Size(61, 19);
      this.metroLabel8.TabIndex = 51;
      this.metroLabel8.Text = "Teléfono:";
      // 
      // textBoxTelefonoEmpl
      // 
      // 
      // 
      // 
      this.textBoxTelefonoEmpl.CustomButton.Image = null;
      this.textBoxTelefonoEmpl.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxTelefonoEmpl.CustomButton.Name = "";
      this.textBoxTelefonoEmpl.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxTelefonoEmpl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxTelefonoEmpl.CustomButton.TabIndex = 1;
      this.textBoxTelefonoEmpl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxTelefonoEmpl.CustomButton.UseSelectable = true;
      this.textBoxTelefonoEmpl.CustomButton.Visible = false;
      this.textBoxTelefonoEmpl.Enabled = false;
      this.textBoxTelefonoEmpl.Lines = new string[0];
      this.textBoxTelefonoEmpl.Location = new System.Drawing.Point(28, 368);
      this.textBoxTelefonoEmpl.MaxLength = 50;
      this.textBoxTelefonoEmpl.Name = "textBoxTelefonoEmpl";
      this.textBoxTelefonoEmpl.PasswordChar = '\0';
      this.textBoxTelefonoEmpl.ReadOnly = true;
      this.textBoxTelefonoEmpl.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxTelefonoEmpl.SelectedText = "";
      this.textBoxTelefonoEmpl.SelectionLength = 0;
      this.textBoxTelefonoEmpl.SelectionStart = 0;
      this.textBoxTelefonoEmpl.ShortcutsEnabled = true;
      this.textBoxTelefonoEmpl.Size = new System.Drawing.Size(341, 23);
      this.textBoxTelefonoEmpl.TabIndex = 50;
      this.textBoxTelefonoEmpl.UseSelectable = true;
      this.textBoxTelefonoEmpl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxTelefonoEmpl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroLabelProv
      // 
      this.metroLabelProv.AutoSize = true;
      this.metroLabelProv.Location = new System.Drawing.Point(415, 280);
      this.metroLabelProv.Name = "metroLabelProv";
      this.metroLabelProv.Size = new System.Drawing.Size(89, 19);
      this.metroLabelProv.TabIndex = 53;
      this.metroLabelProv.Text = "Nacionalidad:";
      // 
      // textBoxNacionalidadEmpl
      // 
      // 
      // 
      // 
      this.textBoxNacionalidadEmpl.CustomButton.Image = null;
      this.textBoxNacionalidadEmpl.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxNacionalidadEmpl.CustomButton.Name = "";
      this.textBoxNacionalidadEmpl.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxNacionalidadEmpl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxNacionalidadEmpl.CustomButton.TabIndex = 1;
      this.textBoxNacionalidadEmpl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxNacionalidadEmpl.CustomButton.UseSelectable = true;
      this.textBoxNacionalidadEmpl.CustomButton.Visible = false;
      this.textBoxNacionalidadEmpl.Enabled = false;
      this.textBoxNacionalidadEmpl.Lines = new string[0];
      this.textBoxNacionalidadEmpl.Location = new System.Drawing.Point(415, 303);
      this.textBoxNacionalidadEmpl.MaxLength = 50;
      this.textBoxNacionalidadEmpl.Name = "textBoxNacionalidadEmpl";
      this.textBoxNacionalidadEmpl.PasswordChar = '\0';
      this.textBoxNacionalidadEmpl.ReadOnly = true;
      this.textBoxNacionalidadEmpl.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxNacionalidadEmpl.SelectedText = "";
      this.textBoxNacionalidadEmpl.SelectionLength = 0;
      this.textBoxNacionalidadEmpl.SelectionStart = 0;
      this.textBoxNacionalidadEmpl.ShortcutsEnabled = true;
      this.textBoxNacionalidadEmpl.Size = new System.Drawing.Size(341, 23);
      this.textBoxNacionalidadEmpl.TabIndex = 52;
      this.textBoxNacionalidadEmpl.UseSelectable = true;
      this.textBoxNacionalidadEmpl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxNacionalidadEmpl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxFechaIngEmpl
      // 
      this.textBoxFechaIngEmpl.Enabled = false;
      this.textBoxFechaIngEmpl.Location = new System.Drawing.Point(28, 235);
      this.textBoxFechaIngEmpl.MinimumSize = new System.Drawing.Size(0, 29);
      this.textBoxFechaIngEmpl.Name = "textBoxFechaIngEmpl";
      this.textBoxFechaIngEmpl.Size = new System.Drawing.Size(341, 29);
      this.textBoxFechaIngEmpl.TabIndex = 54;
      // 
      // VerEmpleadoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(783, 451);
      this.Controls.Add(this.textBoxFechaIngEmpl);
      this.Controls.Add(this.metroLabelProv);
      this.Controls.Add(this.textBoxNacionalidadEmpl);
      this.Controls.Add(this.metroLabel8);
      this.Controls.Add(this.textBoxTelefonoEmpl);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.Provincia);
      this.Controls.Add(this.Localidad);
      this.Controls.Add(this.metroLabel7);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.metroLabel4);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.textBoxProvinciaEmpl);
      this.Controls.Add(this.textBoxLocalidadEmpl);
      this.Controls.Add(this.textBoxDomicilioEmpl);
      this.Controls.Add(this.textBoxDniEmpl);
      this.Controls.Add(this.textBoxNombreEmpl);
      this.Controls.Add(this.textBoxApellidoEmpl);
      this.MaximizeBox = false;
      this.Name = "VerEmpleadoForm";
      this.Text = "Ver Empleado";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MetroFramework.Controls.MetroButton btnCerrar;
    public MetroFramework.Controls.MetroLabel Provincia;
    public MetroFramework.Controls.MetroLabel Localidad;
    public MetroFramework.Controls.MetroLabel metroLabel7;
    public MetroFramework.Controls.MetroLabel metroLabel3;
    public MetroFramework.Controls.MetroLabel metroLabel4;
    public MetroFramework.Controls.MetroLabel metroLabel2;
    public MetroFramework.Controls.MetroLabel metroLabel1;
    public MetroFramework.Controls.MetroTextBox textBoxProvinciaEmpl;
    public MetroFramework.Controls.MetroTextBox textBoxLocalidadEmpl;
    public MetroFramework.Controls.MetroTextBox textBoxDomicilioEmpl;
    public MetroFramework.Controls.MetroTextBox textBoxDniEmpl;
    public MetroFramework.Controls.MetroTextBox textBoxNombreEmpl;
    public MetroFramework.Controls.MetroTextBox textBoxApellidoEmpl;
    public MetroFramework.Controls.MetroLabel metroLabel8;
    public MetroFramework.Controls.MetroTextBox textBoxTelefonoEmpl;
    public MetroFramework.Controls.MetroLabel metroLabelProv;
    public MetroFramework.Controls.MetroTextBox textBoxNacionalidadEmpl;
    public MetroFramework.Controls.MetroDateTime textBoxFechaIngEmpl;
  }
}