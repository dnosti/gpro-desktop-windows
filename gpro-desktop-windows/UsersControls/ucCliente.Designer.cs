namespace gpro_desktop_windows.UsersControls
{
  partial class ucCliente
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
      this.btnCrearCliente = new MetroFramework.Controls.MetroButton();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.btnBuscar = new MetroFramework.Controls.MetroButton();
      this.btnLimpiar = new MetroFramework.Controls.MetroButton();
      this.textBoxDato = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
      this.SuspendLayout();
      // 
      // btnCrearCliente
      // 
      this.btnCrearCliente.Location = new System.Drawing.Point(100, 66);
      this.btnCrearCliente.Name = "btnCrearCliente";
      this.btnCrearCliente.Size = new System.Drawing.Size(137, 25);
      this.btnCrearCliente.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnCrearCliente.TabIndex = 0;
      this.btnCrearCliente.Text = "Crear Cliente";
      this.btnCrearCliente.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnCrearCliente.UseSelectable = true;
      this.btnCrearCliente.UseStyleColors = true;
      this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(100, 108);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(208, 19);
      this.metroLabel1.TabIndex = 2;
      this.metroLabel1.Text = "Apellido / Nombre / Razón Social";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(498, 108);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(37, 19);
      this.metroLabel2.TabIndex = 2;
      this.metroLabel2.Text = "CUIT";
      // 
      // btnBuscar
      // 
      this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnBuscar.Location = new System.Drawing.Point(642, 166);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(107, 25);
      this.btnBuscar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnBuscar.TabIndex = 0;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnBuscar.UseSelectable = true;
      this.btnBuscar.UseStyleColors = true;
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
      // 
      // textBoxDato
      // 
      // 
      // 
      // 
      this.textBoxDato.CustomButton.Image = null;
      this.textBoxDato.CustomButton.Location = new System.Drawing.Point(297, 1);
      this.textBoxDato.CustomButton.Name = "";
      this.textBoxDato.CustomButton.Size = new System.Drawing.Size(23, 23);
      this.textBoxDato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxDato.CustomButton.TabIndex = 1;
      this.textBoxDato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxDato.CustomButton.UseSelectable = true;
      this.textBoxDato.CustomButton.Visible = false;
      this.textBoxDato.Lines = new string[0];
      this.textBoxDato.Location = new System.Drawing.Point(100, 128);
      this.textBoxDato.MaxLength = 32767;
      this.textBoxDato.Name = "textBoxDato";
      this.textBoxDato.PasswordChar = '\0';
      this.textBoxDato.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxDato.SelectedText = "";
      this.textBoxDato.SelectionLength = 0;
      this.textBoxDato.SelectionStart = 0;
      this.textBoxDato.ShortcutsEnabled = true;
      this.textBoxDato.Size = new System.Drawing.Size(377, 25);
      this.textBoxDato.TabIndex = 3;
      this.textBoxDato.UseSelectable = true;
      this.textBoxDato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxDato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
      this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel3.ForeColor = System.Drawing.Color.Black;
      this.metroLabel3.Location = new System.Drawing.Point(730, 15);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(153, 25);
      this.metroLabel3.TabIndex = 5;
      this.metroLabel3.Text = "Gestión [ Clientes ]";
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
      // metroTextBox1
      // 
      // 
      // 
      // 
      this.metroTextBox1.CustomButton.Image = null;
      this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(353, 1);
      this.metroTextBox1.CustomButton.Name = "";
      this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
      this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.metroTextBox1.CustomButton.TabIndex = 1;
      this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.metroTextBox1.CustomButton.UseSelectable = true;
      this.metroTextBox1.CustomButton.Visible = false;
      this.metroTextBox1.Lines = new string[0];
      this.metroTextBox1.Location = new System.Drawing.Point(498, 128);
      this.metroTextBox1.MaxLength = 32767;
      this.metroTextBox1.Name = "metroTextBox1";
      this.metroTextBox1.PasswordChar = '\0';
      this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.metroTextBox1.SelectedText = "";
      this.metroTextBox1.SelectionLength = 0;
      this.metroTextBox1.SelectionStart = 0;
      this.metroTextBox1.ShortcutsEnabled = true;
      this.metroTextBox1.Size = new System.Drawing.Size(377, 25);
      this.metroTextBox1.TabIndex = 7;
      this.metroTextBox1.UseSelectable = true;
      this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // ucCliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.metroTextBox1);
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.btnCrearCliente);
      this.Controls.Add(this.textBoxDato);
      this.Name = "ucCliente";
      this.Size = new System.Drawing.Size(900, 742);
      this.Style = MetroFramework.MetroColorStyle.Blue;
      this.Theme = MetroFramework.MetroThemeStyle.Light;
      this.UseStyleColors = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MetroFramework.Controls.MetroButton btnCrearCliente;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroButton btnBuscar;
    private MetroFramework.Controls.MetroButton btnLimpiar;
    private MetroFramework.Controls.MetroTextBox textBoxDato;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    private MetroFramework.Controls.MetroTextBox metroTextBox1;
  }
}
