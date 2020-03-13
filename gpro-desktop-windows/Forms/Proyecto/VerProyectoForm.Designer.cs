namespace gpro_desktop_windows.Forms
{
  partial class VerProyectoForm
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
      this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.textBoxProyecto = new MetroFramework.Controls.MetroTextBox();
      this.btnCerrar = new MetroFramework.Controls.MetroButton();
      this.textBoxDescripcion = new MetroFramework.Controls.MetroTextBox();
      this.textBoxEstado = new MetroFramework.Controls.MetroTextBox();
      this.textBoxRSocial = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
      this.textBoxCliente = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
      this.SuspendLayout();
      // 
      // metroLabel7
      // 
      this.metroLabel7.AutoSize = true;
      this.metroLabel7.Location = new System.Drawing.Point(28, 270);
      this.metroLabel7.Name = "metroLabel7";
      this.metroLabel7.Size = new System.Drawing.Size(51, 19);
      this.metroLabel7.TabIndex = 46;
      this.metroLabel7.Text = "Estado:";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(28, 142);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(79, 19);
      this.metroLabel2.TabIndex = 43;
      this.metroLabel2.Text = "Descripción:";
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(28, 74);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(64, 19);
      this.metroLabel1.TabIndex = 42;
      this.metroLabel1.Text = "Proyecto:";
      // 
      // textBoxProyecto
      // 
      // 
      // 
      // 
      this.textBoxProyecto.CustomButton.Image = null;
      this.textBoxProyecto.CustomButton.Location = new System.Drawing.Point(319, 1);
      this.textBoxProyecto.CustomButton.Name = "";
      this.textBoxProyecto.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxProyecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxProyecto.CustomButton.TabIndex = 1;
      this.textBoxProyecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxProyecto.CustomButton.UseSelectable = true;
      this.textBoxProyecto.CustomButton.Visible = false;
      this.textBoxProyecto.Enabled = false;
      this.textBoxProyecto.Lines = new string[0];
      this.textBoxProyecto.Location = new System.Drawing.Point(28, 97);
      this.textBoxProyecto.MaxLength = 50;
      this.textBoxProyecto.Name = "textBoxProyecto";
      this.textBoxProyecto.PasswordChar = '\0';
      this.textBoxProyecto.ReadOnly = true;
      this.textBoxProyecto.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxProyecto.SelectedText = "";
      this.textBoxProyecto.SelectionLength = 0;
      this.textBoxProyecto.SelectionStart = 0;
      this.textBoxProyecto.ShortcutsEnabled = true;
      this.textBoxProyecto.Size = new System.Drawing.Size(341, 23);
      this.textBoxProyecto.TabIndex = 35;
      this.textBoxProyecto.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxProyecto.UseSelectable = true;
      this.textBoxProyecto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxProyecto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // btnCerrar
      // 
      this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnCerrar.Location = new System.Drawing.Point(631, 308);
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
      // textBoxDescripcion
      // 
      // 
      // 
      // 
      this.textBoxDescripcion.CustomButton.Image = null;
      this.textBoxDescripcion.CustomButton.Location = new System.Drawing.Point(258, 2);
      this.textBoxDescripcion.CustomButton.Name = "";
      this.textBoxDescripcion.CustomButton.Size = new System.Drawing.Size(79, 79);
      this.textBoxDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxDescripcion.CustomButton.TabIndex = 1;
      this.textBoxDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxDescripcion.CustomButton.UseSelectable = true;
      this.textBoxDescripcion.CustomButton.Visible = false;
      this.textBoxDescripcion.Enabled = false;
      this.textBoxDescripcion.Lines = new string[0];
      this.textBoxDescripcion.Location = new System.Drawing.Point(28, 166);
      this.textBoxDescripcion.MaxLength = 250;
      this.textBoxDescripcion.Multiline = true;
      this.textBoxDescripcion.Name = "textBoxDescripcion";
      this.textBoxDescripcion.PasswordChar = '\0';
      this.textBoxDescripcion.ReadOnly = true;
      this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxDescripcion.SelectedText = "";
      this.textBoxDescripcion.SelectionLength = 0;
      this.textBoxDescripcion.SelectionStart = 0;
      this.textBoxDescripcion.ShortcutsEnabled = true;
      this.textBoxDescripcion.Size = new System.Drawing.Size(340, 84);
      this.textBoxDescripcion.TabIndex = 53;
      this.textBoxDescripcion.UseSelectable = true;
      this.textBoxDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxEstado
      // 
      // 
      // 
      // 
      this.textBoxEstado.CustomButton.Image = null;
      this.textBoxEstado.CustomButton.Location = new System.Drawing.Point(318, 1);
      this.textBoxEstado.CustomButton.Name = "";
      this.textBoxEstado.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxEstado.CustomButton.TabIndex = 1;
      this.textBoxEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxEstado.CustomButton.UseSelectable = true;
      this.textBoxEstado.CustomButton.Visible = false;
      this.textBoxEstado.Enabled = false;
      this.textBoxEstado.Lines = new string[0];
      this.textBoxEstado.Location = new System.Drawing.Point(28, 293);
      this.textBoxEstado.MaxLength = 50;
      this.textBoxEstado.Name = "textBoxEstado";
      this.textBoxEstado.PasswordChar = '\0';
      this.textBoxEstado.ReadOnly = true;
      this.textBoxEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxEstado.SelectedText = "";
      this.textBoxEstado.SelectionLength = 0;
      this.textBoxEstado.SelectionStart = 0;
      this.textBoxEstado.ShortcutsEnabled = true;
      this.textBoxEstado.Size = new System.Drawing.Size(340, 23);
      this.textBoxEstado.TabIndex = 56;
      this.textBoxEstado.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxEstado.UseSelectable = true;
      this.textBoxEstado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxEstado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // textBoxRSocial
      // 
      // 
      // 
      // 
      this.textBoxRSocial.CustomButton.Image = null;
      this.textBoxRSocial.CustomButton.Location = new System.Drawing.Point(318, 1);
      this.textBoxRSocial.CustomButton.Name = "";
      this.textBoxRSocial.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxRSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxRSocial.CustomButton.TabIndex = 1;
      this.textBoxRSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxRSocial.CustomButton.UseSelectable = true;
      this.textBoxRSocial.CustomButton.Visible = false;
      this.textBoxRSocial.Enabled = false;
      this.textBoxRSocial.Lines = new string[0];
      this.textBoxRSocial.Location = new System.Drawing.Point(415, 97);
      this.textBoxRSocial.MaxLength = 32767;
      this.textBoxRSocial.Name = "textBoxRSocial";
      this.textBoxRSocial.PasswordChar = '\0';
      this.textBoxRSocial.ReadOnly = true;
      this.textBoxRSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxRSocial.SelectedText = "";
      this.textBoxRSocial.SelectionLength = 0;
      this.textBoxRSocial.SelectionStart = 0;
      this.textBoxRSocial.ShortcutsEnabled = true;
      this.textBoxRSocial.Size = new System.Drawing.Size(340, 23);
      this.textBoxRSocial.TabIndex = 58;
      this.textBoxRSocial.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxRSocial.UseSelectable = true;
      this.textBoxRSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxRSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroLabel4
      // 
      this.metroLabel4.AutoSize = true;
      this.metroLabel4.Location = new System.Drawing.Point(415, 74);
      this.metroLabel4.Name = "metroLabel4";
      this.metroLabel4.Size = new System.Drawing.Size(138, 19);
      this.metroLabel4.TabIndex = 57;
      this.metroLabel4.Text = "(Cliente) Razón Social:";
      // 
      // textBoxCliente
      // 
      // 
      // 
      // 
      this.textBoxCliente.CustomButton.Image = null;
      this.textBoxCliente.CustomButton.Location = new System.Drawing.Point(318, 1);
      this.textBoxCliente.CustomButton.Name = "";
      this.textBoxCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.textBoxCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxCliente.CustomButton.TabIndex = 1;
      this.textBoxCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxCliente.CustomButton.UseSelectable = true;
      this.textBoxCliente.CustomButton.Visible = false;
      this.textBoxCliente.Enabled = false;
      this.textBoxCliente.Lines = new string[0];
      this.textBoxCliente.Location = new System.Drawing.Point(415, 165);
      this.textBoxCliente.MaxLength = 32767;
      this.textBoxCliente.Name = "textBoxCliente";
      this.textBoxCliente.PasswordChar = '\0';
      this.textBoxCliente.ReadOnly = true;
      this.textBoxCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxCliente.SelectedText = "";
      this.textBoxCliente.SelectionLength = 0;
      this.textBoxCliente.SelectionStart = 0;
      this.textBoxCliente.ShortcutsEnabled = true;
      this.textBoxCliente.Size = new System.Drawing.Size(340, 23);
      this.textBoxCliente.TabIndex = 60;
      this.textBoxCliente.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxCliente.UseSelectable = true;
      this.textBoxCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroLabel5
      // 
      this.metroLabel5.AutoSize = true;
      this.metroLabel5.Location = new System.Drawing.Point(415, 142);
      this.metroLabel5.Name = "metroLabel5";
      this.metroLabel5.Size = new System.Drawing.Size(177, 19);
      this.metroLabel5.TabIndex = 59;
      this.metroLabel5.Text = "(Cliente) Apellido y Nombre:";
      // 
      // VerProyectoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(783, 363);
      this.Controls.Add(this.textBoxCliente);
      this.Controls.Add(this.metroLabel5);
      this.Controls.Add(this.textBoxRSocial);
      this.Controls.Add(this.metroLabel4);
      this.Controls.Add(this.textBoxEstado);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.metroLabel7);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.textBoxProyecto);
      this.Controls.Add(this.textBoxDescripcion);
      this.MaximizeBox = false;
      this.Name = "VerProyectoForm";
      this.Text = "Ver Proyecto";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MetroFramework.Controls.MetroButton btnCerrar;
    public MetroFramework.Controls.MetroLabel metroLabel7;
    public MetroFramework.Controls.MetroLabel metroLabel2;
    public MetroFramework.Controls.MetroLabel metroLabel1;
    public MetroFramework.Controls.MetroTextBox textBoxProyecto;
    public MetroFramework.Controls.MetroTextBox textBoxDescripcion;
    public MetroFramework.Controls.MetroTextBox textBoxEstado;
    public MetroFramework.Controls.MetroTextBox textBoxRSocial;
    public MetroFramework.Controls.MetroLabel metroLabel4;
    public MetroFramework.Controls.MetroTextBox textBoxCliente;
    public MetroFramework.Controls.MetroLabel metroLabel5;
  }
}