namespace gpro_desktop_windows.Forms
{
  partial class EditarProyectoForm
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
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
      this.ComboBoxCliente = new MetroFramework.Controls.MetroComboBox();
      this.textBoxDescProyecto = new MetroFramework.Controls.MetroTextBox();
      this.textBoxTitulo = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.comboBoxEstado = new MetroFramework.Controls.MetroComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
      this.btnCancelar.Location = new System.Drawing.Point(487, 259);
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
      this.btnConfirmar.Location = new System.Drawing.Point(631, 259);
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
      this.metroLabel1.Size = new System.Drawing.Size(79, 19);
      this.metroLabel1.TabIndex = 28;
      this.metroLabel1.Text = "Descripción:";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(27, 70);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(52, 19);
      this.metroLabel2.TabIndex = 29;
      this.metroLabel2.Text = "Cliente:";
      // 
      // metroLabel7
      // 
      this.metroLabel7.AutoSize = true;
      this.metroLabel7.Location = new System.Drawing.Point(27, 142);
      this.metroLabel7.Name = "metroLabel7";
      this.metroLabel7.Size = new System.Drawing.Size(44, 19);
      this.metroLabel7.TabIndex = 32;
      this.metroLabel7.Text = "Título:";
      // 
      // ComboBoxCliente
      // 
      this.ComboBoxCliente.Enabled = false;
      this.ComboBoxCliente.FormattingEnabled = true;
      this.ComboBoxCliente.ItemHeight = 23;
      this.ComboBoxCliente.Location = new System.Drawing.Point(27, 94);
      this.ComboBoxCliente.Name = "ComboBoxCliente";
      this.ComboBoxCliente.Size = new System.Drawing.Size(341, 29);
      this.ComboBoxCliente.TabIndex = 34;
      this.ComboBoxCliente.UseSelectable = true;
      // 
      // textBoxDescProyecto
      // 
      // 
      // 
      // 
      this.textBoxDescProyecto.CustomButton.Image = null;
      this.textBoxDescProyecto.CustomButton.Location = new System.Drawing.Point(248, 2);
      this.textBoxDescProyecto.CustomButton.Name = "";
      this.textBoxDescProyecto.CustomButton.Size = new System.Drawing.Size(89, 89);
      this.textBoxDescProyecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxDescProyecto.CustomButton.TabIndex = 1;
      this.textBoxDescProyecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxDescProyecto.CustomButton.UseSelectable = true;
      this.textBoxDescProyecto.CustomButton.Visible = false;
      this.textBoxDescProyecto.Lines = new string[0];
      this.textBoxDescProyecto.Location = new System.Drawing.Point(415, 94);
      this.textBoxDescProyecto.MaxLength = 32767;
      this.textBoxDescProyecto.Multiline = true;
      this.textBoxDescProyecto.Name = "textBoxDescProyecto";
      this.textBoxDescProyecto.PasswordChar = '\0';
      this.textBoxDescProyecto.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxDescProyecto.SelectedText = "";
      this.textBoxDescProyecto.SelectionLength = 0;
      this.textBoxDescProyecto.SelectionStart = 0;
      this.textBoxDescProyecto.ShortcutsEnabled = true;
      this.textBoxDescProyecto.Size = new System.Drawing.Size(340, 94);
      this.textBoxDescProyecto.TabIndex = 36;
      this.textBoxDescProyecto.UseSelectable = true;
      this.textBoxDescProyecto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxDescProyecto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxTitulo
      // 
      // 
      // 
      // 
      this.textBoxTitulo.CustomButton.Image = null;
      this.textBoxTitulo.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxTitulo.CustomButton.Name = "";
      this.textBoxTitulo.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxTitulo.CustomButton.TabIndex = 1;
      this.textBoxTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxTitulo.CustomButton.UseSelectable = true;
      this.textBoxTitulo.CustomButton.Visible = false;
      this.textBoxTitulo.Lines = new string[0];
      this.textBoxTitulo.Location = new System.Drawing.Point(27, 165);
      this.textBoxTitulo.MaxLength = 32767;
      this.textBoxTitulo.Name = "textBoxTitulo";
      this.textBoxTitulo.PasswordChar = '\0';
      this.textBoxTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxTitulo.SelectedText = "";
      this.textBoxTitulo.SelectionLength = 0;
      this.textBoxTitulo.SelectionStart = 0;
      this.textBoxTitulo.ShortcutsEnabled = true;
      this.textBoxTitulo.Size = new System.Drawing.Size(341, 23);
      this.textBoxTitulo.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxTitulo.TabIndex = 19;
      this.textBoxTitulo.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxTitulo.UseSelectable = true;
      this.textBoxTitulo.UseStyleColors = true;
      this.textBoxTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.Location = new System.Drawing.Point(27, 206);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(51, 19);
      this.metroLabel3.TabIndex = 38;
      this.metroLabel3.Text = "Estado:";
      // 
      // comboBoxEstado
      // 
      this.comboBoxEstado.FormattingEnabled = true;
      this.comboBoxEstado.ItemHeight = 23;
      this.comboBoxEstado.Location = new System.Drawing.Point(27, 229);
      this.comboBoxEstado.Name = "comboBoxEstado";
      this.comboBoxEstado.Size = new System.Drawing.Size(341, 29);
      this.comboBoxEstado.TabIndex = 39;
      this.comboBoxEstado.UseSelectable = true;
      // 
      // EditarProyectoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(783, 312);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.metroLabel7);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnConfirmar);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.textBoxTitulo);
      this.Controls.Add(this.ComboBoxCliente);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.textBoxDescProyecto);
      this.Controls.Add(this.comboBoxEstado);
      this.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.Name = "EditarProyectoForm";
      this.ShowIcon = false;
      this.Text = "Editar Proyecto";
      this.Load += new System.EventHandler(this.EditarProyectoForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private MetroFramework.Controls.MetroButton btnCancelar;
    private MetroFramework.Controls.MetroButton btnConfirmar;
    private MetroFramework.Controls.MetroLabel metroLabel7;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    public MetroFramework.Controls.MetroComboBox ComboBoxCliente;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    public MetroFramework.Controls.MetroComboBox comboBoxEstado;
    public MetroFramework.Controls.MetroTextBox textBoxTitulo;
    public MetroFramework.Controls.MetroTextBox textBoxDescProyecto;
  }
}