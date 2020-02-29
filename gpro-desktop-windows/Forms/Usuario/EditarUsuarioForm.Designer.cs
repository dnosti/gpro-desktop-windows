namespace gpro_desktop_windows.Forms
{
  partial class EditarUsuarioForm
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
      this.textBoxUsuario = new MetroFramework.Controls.MetroTextBox();
      this.textBoxPassword = new MetroFramework.Controls.MetroTextBox();
      this.btnCancelar = new MetroFramework.Controls.MetroButton();
      this.btnConfirmar = new MetroFramework.Controls.MetroButton();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
      this.ComboBoxRole = new MetroFramework.Controls.MetroComboBox();
      this.textBoxEmpleado = new MetroFramework.Controls.MetroTextBox();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // errorProvider1
      // 
      this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider1.ContainerControl = this;
      // 
      // textBoxUsuario
      // 
      // 
      // 
      // 
      this.textBoxUsuario.CustomButton.Image = null;
      this.textBoxUsuario.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxUsuario.CustomButton.Name = "";
      this.textBoxUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxUsuario.CustomButton.TabIndex = 1;
      this.textBoxUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxUsuario.CustomButton.UseSelectable = true;
      this.textBoxUsuario.CustomButton.Visible = false;
      this.textBoxUsuario.Lines = new string[0];
      this.textBoxUsuario.Location = new System.Drawing.Point(415, 94);
      this.textBoxUsuario.MaxLength = 32767;
      this.textBoxUsuario.Name = "textBoxUsuario";
      this.textBoxUsuario.PasswordChar = '\0';
      this.textBoxUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxUsuario.SelectedText = "";
      this.textBoxUsuario.SelectionLength = 0;
      this.textBoxUsuario.SelectionStart = 0;
      this.textBoxUsuario.ShortcutsEnabled = true;
      this.textBoxUsuario.Size = new System.Drawing.Size(341, 23);
      this.textBoxUsuario.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxUsuario.TabIndex = 19;
      this.textBoxUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxUsuario.UseSelectable = true;
      this.textBoxUsuario.UseStyleColors = true;
      this.textBoxUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxPassword
      // 
      // 
      // 
      // 
      this.textBoxPassword.CustomButton.Image = null;
      this.textBoxPassword.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxPassword.CustomButton.Name = "";
      this.textBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxPassword.CustomButton.TabIndex = 1;
      this.textBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxPassword.CustomButton.UseSelectable = true;
      this.textBoxPassword.CustomButton.Visible = false;
      this.textBoxPassword.Lines = new string[0];
      this.textBoxPassword.Location = new System.Drawing.Point(415, 166);
      this.textBoxPassword.MaxLength = 32767;
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.PasswordChar = '●';
      this.textBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxPassword.SelectedText = "";
      this.textBoxPassword.SelectionLength = 0;
      this.textBoxPassword.SelectionStart = 0;
      this.textBoxPassword.ShortcutsEnabled = true;
      this.textBoxPassword.Size = new System.Drawing.Size(341, 23);
      this.textBoxPassword.TabIndex = 24;
      this.textBoxPassword.UseSelectable = true;
      this.textBoxPassword.UseSystemPasswordChar = true;
      this.textBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnCancelar.Location = new System.Drawing.Point(487, 219);
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
      this.btnConfirmar.Location = new System.Drawing.Point(631, 219);
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
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(415, 71);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(71, 19);
      this.metroLabel1.TabIndex = 28;
      this.metroLabel1.Text = "Username:";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(27, 70);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(72, 19);
      this.metroLabel2.TabIndex = 29;
      this.metroLabel2.Text = "Empleado:";
      // 
      // metroLabel6
      // 
      this.metroLabel6.AutoSize = true;
      this.metroLabel6.Location = new System.Drawing.Point(415, 142);
      this.metroLabel6.Name = "metroLabel6";
      this.metroLabel6.Size = new System.Drawing.Size(66, 19);
      this.metroLabel6.TabIndex = 33;
      this.metroLabel6.Text = "Password:";
      // 
      // metroLabel7
      // 
      this.metroLabel7.AutoSize = true;
      this.metroLabel7.Location = new System.Drawing.Point(27, 142);
      this.metroLabel7.Name = "metroLabel7";
      this.metroLabel7.Size = new System.Drawing.Size(38, 19);
      this.metroLabel7.TabIndex = 32;
      this.metroLabel7.Text = "Role:";
      // 
      // ComboBoxRole
      // 
      this.ComboBoxRole.FormattingEnabled = true;
      this.ComboBoxRole.ItemHeight = 23;
      this.ComboBoxRole.Location = new System.Drawing.Point(27, 165);
      this.ComboBoxRole.Name = "ComboBoxRole";
      this.ComboBoxRole.Size = new System.Drawing.Size(340, 29);
      this.ComboBoxRole.TabIndex = 35;
      this.ComboBoxRole.UseSelectable = true;
      // 
      // textBoxEmpleado
      // 
      // 
      // 
      // 
      this.textBoxEmpleado.CustomButton.Image = null;
      this.textBoxEmpleado.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxEmpleado.CustomButton.Name = "";
      this.textBoxEmpleado.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxEmpleado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxEmpleado.CustomButton.TabIndex = 1;
      this.textBoxEmpleado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxEmpleado.CustomButton.UseSelectable = true;
      this.textBoxEmpleado.CustomButton.Visible = false;
      this.textBoxEmpleado.Enabled = false;
      this.textBoxEmpleado.Lines = new string[0];
      this.textBoxEmpleado.Location = new System.Drawing.Point(27, 94);
      this.textBoxEmpleado.MaxLength = 32767;
      this.textBoxEmpleado.Name = "textBoxEmpleado";
      this.textBoxEmpleado.PasswordChar = '\0';
      this.textBoxEmpleado.ReadOnly = true;
      this.textBoxEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxEmpleado.SelectedText = "";
      this.textBoxEmpleado.SelectionLength = 0;
      this.textBoxEmpleado.SelectionStart = 0;
      this.textBoxEmpleado.ShortcutsEnabled = true;
      this.textBoxEmpleado.Size = new System.Drawing.Size(341, 23);
      this.textBoxEmpleado.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxEmpleado.TabIndex = 36;
      this.textBoxEmpleado.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxEmpleado.UseSelectable = true;
      this.textBoxEmpleado.UseStyleColors = true;
      this.textBoxEmpleado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxEmpleado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // EditarUsuarioForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(783, 276);
      this.Controls.Add(this.textBoxEmpleado);
      this.Controls.Add(this.metroLabel6);
      this.Controls.Add(this.metroLabel7);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnConfirmar);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.textBoxUsuario);
      this.Controls.Add(this.ComboBoxRole);
      this.Controls.Add(this.metroLabel2);
      this.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.Name = "EditarUsuarioForm";
      this.ShowIcon = false;
      this.Text = "Editar Usuario";
      this.Load += new System.EventHandler(this.CrearUsuarioForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private MetroFramework.Controls.MetroButton btnCancelar;
    private MetroFramework.Controls.MetroButton btnConfirmar;
    private MetroFramework.Controls.MetroLabel metroLabel6;
    private MetroFramework.Controls.MetroLabel metroLabel7;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    public MetroFramework.Controls.MetroComboBox ComboBoxRole;
    public MetroFramework.Controls.MetroTextBox textBoxUsuario;
    public MetroFramework.Controls.MetroTextBox textBoxPassword;
    public MetroFramework.Controls.MetroTextBox textBoxEmpleado;
  }
}