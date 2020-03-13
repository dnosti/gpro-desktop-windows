namespace gpro_desktop_windows.Forms
{
  partial class EditarClienteForm
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
      this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.btnConfirmar = new MetroFramework.Controls.MetroButton();
      this.btnCancelar = new MetroFramework.Controls.MetroButton();
      this.textBoxEMail = new MetroFramework.Controls.MetroTextBox();
      this.textBoxTelefono = new MetroFramework.Controls.MetroTextBox();
      this.textBoxDomicilio = new MetroFramework.Controls.MetroTextBox();
      this.textBoxNombre = new MetroFramework.Controls.MetroTextBox();
      this.textBoxApellido = new MetroFramework.Controls.MetroTextBox();
      this.textBoxRSocial = new MetroFramework.Controls.MetroTextBox();
      this.textBoxidCliente = new MetroFramework.Controls.MetroTextBox();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // metroLabel5
      // 
      this.metroLabel5.AutoSize = true;
      this.metroLabel5.Location = new System.Drawing.Point(415, 212);
      this.metroLabel5.Name = "metroLabel5";
      this.metroLabel5.Size = new System.Drawing.Size(50, 19);
      this.metroLabel5.TabIndex = 50;
      this.metroLabel5.Text = "E-Mail:";
      // 
      // metroLabel6
      // 
      this.metroLabel6.AutoSize = true;
      this.metroLabel6.Location = new System.Drawing.Point(415, 142);
      this.metroLabel6.Name = "metroLabel6";
      this.metroLabel6.Size = new System.Drawing.Size(61, 19);
      this.metroLabel6.TabIndex = 49;
      this.metroLabel6.Text = "Teléfono:";
      // 
      // metroLabel7
      // 
      this.metroLabel7.AutoSize = true;
      this.metroLabel7.Location = new System.Drawing.Point(415, 74);
      this.metroLabel7.Name = "metroLabel7";
      this.metroLabel7.Size = new System.Drawing.Size(67, 19);
      this.metroLabel7.TabIndex = 48;
      this.metroLabel7.Text = "Domicilio:";
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.Location = new System.Drawing.Point(28, 280);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(62, 19);
      this.metroLabel3.TabIndex = 47;
      this.metroLabel3.Text = "Nombre:";
      // 
      // metroLabel4
      // 
      this.metroLabel4.AutoSize = true;
      this.metroLabel4.Location = new System.Drawing.Point(28, 212);
      this.metroLabel4.Name = "metroLabel4";
      this.metroLabel4.Size = new System.Drawing.Size(61, 19);
      this.metroLabel4.TabIndex = 46;
      this.metroLabel4.Text = "Apellido:";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(28, 142);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(86, 19);
      this.metroLabel2.TabIndex = 45;
      this.metroLabel2.Text = "Razón Social:";
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(28, 74);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(40, 19);
      this.metroLabel1.TabIndex = 44;
      this.metroLabel1.Text = "CUIT:";
      // 
      // btnConfirmar
      // 
      this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnConfirmar.Location = new System.Drawing.Point(632, 349);
      this.btnConfirmar.Name = "btnConfirmar";
      this.btnConfirmar.Size = new System.Drawing.Size(124, 34);
      this.btnConfirmar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnConfirmar.TabIndex = 43;
      this.btnConfirmar.Text = "Confirmar";
      this.btnConfirmar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnConfirmar.UseSelectable = true;
      this.btnConfirmar.UseStyleColors = true;
      this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnCancelar.Location = new System.Drawing.Point(488, 349);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(124, 34);
      this.btnCancelar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnCancelar.TabIndex = 42;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnCancelar.UseSelectable = true;
      this.btnCancelar.UseStyleColors = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // textBoxEMail
      // 
      // 
      // 
      // 
      this.textBoxEMail.CustomButton.Image = null;
      this.textBoxEMail.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxEMail.CustomButton.Name = "";
      this.textBoxEMail.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxEMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxEMail.CustomButton.TabIndex = 1;
      this.textBoxEMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxEMail.CustomButton.UseSelectable = true;
      this.textBoxEMail.CustomButton.Visible = false;
      this.textBoxEMail.Lines = new string[0];
      this.textBoxEMail.Location = new System.Drawing.Point(415, 235);
      this.textBoxEMail.MaxLength = 50;
      this.textBoxEMail.Name = "textBoxEMail";
      this.textBoxEMail.PasswordChar = '\0';
      this.textBoxEMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxEMail.SelectedText = "";
      this.textBoxEMail.SelectionLength = 0;
      this.textBoxEMail.SelectionStart = 0;
      this.textBoxEMail.ShortcutsEnabled = true;
      this.textBoxEMail.Size = new System.Drawing.Size(341, 23);
      this.textBoxEMail.TabIndex = 41;
      this.textBoxEMail.UseSelectable = true;
      this.textBoxEMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxEMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxTelefono
      // 
      // 
      // 
      // 
      this.textBoxTelefono.CustomButton.Image = null;
      this.textBoxTelefono.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxTelefono.CustomButton.Name = "";
      this.textBoxTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxTelefono.CustomButton.TabIndex = 1;
      this.textBoxTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxTelefono.CustomButton.UseSelectable = true;
      this.textBoxTelefono.CustomButton.Visible = false;
      this.textBoxTelefono.Lines = new string[0];
      this.textBoxTelefono.Location = new System.Drawing.Point(415, 166);
      this.textBoxTelefono.MaxLength = 50;
      this.textBoxTelefono.Name = "textBoxTelefono";
      this.textBoxTelefono.PasswordChar = '\0';
      this.textBoxTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxTelefono.SelectedText = "";
      this.textBoxTelefono.SelectionLength = 0;
      this.textBoxTelefono.SelectionStart = 0;
      this.textBoxTelefono.ShortcutsEnabled = true;
      this.textBoxTelefono.Size = new System.Drawing.Size(341, 23);
      this.textBoxTelefono.TabIndex = 40;
      this.textBoxTelefono.UseSelectable = true;
      this.textBoxTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxDomicilio
      // 
      // 
      // 
      // 
      this.textBoxDomicilio.CustomButton.Image = null;
      this.textBoxDomicilio.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxDomicilio.CustomButton.Name = "";
      this.textBoxDomicilio.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxDomicilio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxDomicilio.CustomButton.TabIndex = 1;
      this.textBoxDomicilio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxDomicilio.CustomButton.UseSelectable = true;
      this.textBoxDomicilio.CustomButton.Visible = false;
      this.textBoxDomicilio.Lines = new string[0];
      this.textBoxDomicilio.Location = new System.Drawing.Point(415, 97);
      this.textBoxDomicilio.MaxLength = 50;
      this.textBoxDomicilio.Name = "textBoxDomicilio";
      this.textBoxDomicilio.PasswordChar = '\0';
      this.textBoxDomicilio.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxDomicilio.SelectedText = "";
      this.textBoxDomicilio.SelectionLength = 0;
      this.textBoxDomicilio.SelectionStart = 0;
      this.textBoxDomicilio.ShortcutsEnabled = true;
      this.textBoxDomicilio.Size = new System.Drawing.Size(341, 23);
      this.textBoxDomicilio.TabIndex = 39;
      this.textBoxDomicilio.UseSelectable = true;
      this.textBoxDomicilio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxDomicilio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxNombre
      // 
      // 
      // 
      // 
      this.textBoxNombre.CustomButton.Image = null;
      this.textBoxNombre.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxNombre.CustomButton.Name = "";
      this.textBoxNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxNombre.CustomButton.TabIndex = 1;
      this.textBoxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxNombre.CustomButton.UseSelectable = true;
      this.textBoxNombre.CustomButton.Visible = false;
      this.textBoxNombre.Lines = new string[0];
      this.textBoxNombre.Location = new System.Drawing.Point(28, 302);
      this.textBoxNombre.MaxLength = 50;
      this.textBoxNombre.Name = "textBoxNombre";
      this.textBoxNombre.PasswordChar = '\0';
      this.textBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxNombre.SelectedText = "";
      this.textBoxNombre.SelectionLength = 0;
      this.textBoxNombre.SelectionStart = 0;
      this.textBoxNombre.ShortcutsEnabled = true;
      this.textBoxNombre.Size = new System.Drawing.Size(341, 23);
      this.textBoxNombre.TabIndex = 38;
      this.textBoxNombre.UseSelectable = true;
      this.textBoxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxApellido
      // 
      // 
      // 
      // 
      this.textBoxApellido.CustomButton.Image = null;
      this.textBoxApellido.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxApellido.CustomButton.Name = "";
      this.textBoxApellido.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxApellido.CustomButton.TabIndex = 1;
      this.textBoxApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxApellido.CustomButton.UseSelectable = true;
      this.textBoxApellido.CustomButton.Visible = false;
      this.textBoxApellido.Lines = new string[0];
      this.textBoxApellido.Location = new System.Drawing.Point(28, 235);
      this.textBoxApellido.MaxLength = 50;
      this.textBoxApellido.Name = "textBoxApellido";
      this.textBoxApellido.PasswordChar = '\0';
      this.textBoxApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxApellido.SelectedText = "";
      this.textBoxApellido.SelectionLength = 0;
      this.textBoxApellido.SelectionStart = 0;
      this.textBoxApellido.ShortcutsEnabled = true;
      this.textBoxApellido.Size = new System.Drawing.Size(341, 23);
      this.textBoxApellido.TabIndex = 37;
      this.textBoxApellido.UseSelectable = true;
      this.textBoxApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxRSocial
      // 
      // 
      // 
      // 
      this.textBoxRSocial.CustomButton.Image = null;
      this.textBoxRSocial.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxRSocial.CustomButton.Name = "";
      this.textBoxRSocial.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxRSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxRSocial.CustomButton.TabIndex = 1;
      this.textBoxRSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxRSocial.CustomButton.UseSelectable = true;
      this.textBoxRSocial.CustomButton.Visible = false;
      this.textBoxRSocial.Lines = new string[0];
      this.textBoxRSocial.Location = new System.Drawing.Point(28, 166);
      this.textBoxRSocial.MaxLength = 50;
      this.textBoxRSocial.Name = "textBoxRSocial";
      this.textBoxRSocial.PasswordChar = '\0';
      this.textBoxRSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxRSocial.SelectedText = "";
      this.textBoxRSocial.SelectionLength = 0;
      this.textBoxRSocial.SelectionStart = 0;
      this.textBoxRSocial.ShortcutsEnabled = true;
      this.textBoxRSocial.Size = new System.Drawing.Size(341, 23);
      this.textBoxRSocial.TabIndex = 36;
      this.textBoxRSocial.UseSelectable = true;
      this.textBoxRSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxRSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxidCliente
      // 
      // 
      // 
      // 
      this.textBoxidCliente.CustomButton.Image = null;
      this.textBoxidCliente.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxidCliente.CustomButton.Name = "";
      this.textBoxidCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxidCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxidCliente.CustomButton.TabIndex = 1;
      this.textBoxidCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxidCliente.CustomButton.UseSelectable = true;
      this.textBoxidCliente.CustomButton.Visible = false;
      this.textBoxidCliente.Lines = new string[0];
      this.textBoxidCliente.Location = new System.Drawing.Point(28, 97);
      this.textBoxidCliente.MaxLength = 50;
      this.textBoxidCliente.Name = "textBoxidCliente";
      this.textBoxidCliente.PasswordChar = '\0';
      this.textBoxidCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxidCliente.SelectedText = "";
      this.textBoxidCliente.SelectionLength = 0;
      this.textBoxidCliente.SelectionStart = 0;
      this.textBoxidCliente.ShortcutsEnabled = true;
      this.textBoxidCliente.Size = new System.Drawing.Size(341, 23);
      this.textBoxidCliente.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxidCliente.TabIndex = 35;
      this.textBoxidCliente.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxidCliente.UseSelectable = true;
      this.textBoxidCliente.UseStyleColors = true;
      this.textBoxidCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxidCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // errorProvider1
      // 
      this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider1.ContainerControl = this;
      // 
      // EditarClienteForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(783, 406);
      this.Controls.Add(this.metroLabel5);
      this.Controls.Add(this.metroLabel6);
      this.Controls.Add(this.metroLabel7);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.metroLabel4);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnConfirmar);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.textBoxEMail);
      this.Controls.Add(this.textBoxTelefono);
      this.Controls.Add(this.textBoxDomicilio);
      this.Controls.Add(this.textBoxNombre);
      this.Controls.Add(this.textBoxApellido);
      this.Controls.Add(this.textBoxRSocial);
      this.Controls.Add(this.textBoxidCliente);
      this.MaximizeBox = false;
      this.Name = "EditarClienteForm";
      this.Text = "Editar Cliente";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MetroFramework.Controls.MetroLabel metroLabel5;
    private MetroFramework.Controls.MetroLabel metroLabel6;
    private MetroFramework.Controls.MetroLabel metroLabel7;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroLabel metroLabel4;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroButton btnConfirmar;
    private MetroFramework.Controls.MetroButton btnCancelar;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    public MetroFramework.Controls.MetroTextBox textBoxEMail;
    public MetroFramework.Controls.MetroTextBox textBoxTelefono;
    public MetroFramework.Controls.MetroTextBox textBoxDomicilio;
    public MetroFramework.Controls.MetroTextBox textBoxNombre;
    public MetroFramework.Controls.MetroTextBox textBoxApellido;
    public MetroFramework.Controls.MetroTextBox textBoxRSocial;
    public MetroFramework.Controls.MetroTextBox textBoxidCliente;
  }
}