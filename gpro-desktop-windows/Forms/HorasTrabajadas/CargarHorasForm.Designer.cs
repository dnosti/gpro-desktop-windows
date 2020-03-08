namespace gpro_desktop_windows.Forms
{
  partial class CargarHorasForm
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
      this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.btnConfirmar = new MetroFramework.Controls.MetroButton();
      this.btnCancelar = new MetroFramework.Controls.MetroButton();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.fechaHoras = new MetroFramework.Controls.MetroDateTime();
      this.cantidadHoras = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cantidadHoras)).BeginInit();
      this.SuspendLayout();
      // 
      // metroLabel4
      // 
      this.metroLabel4.AutoSize = true;
      this.metroLabel4.Location = new System.Drawing.Point(28, 143);
      this.metroLabel4.Name = "metroLabel4";
      this.metroLabel4.Size = new System.Drawing.Size(46, 19);
      this.metroLabel4.TabIndex = 44;
      this.metroLabel4.Text = "Fecha:";
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(28, 74);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(122, 19);
      this.metroLabel1.TabIndex = 42;
      this.metroLabel1.Text = "Cantidad de Horas:";
      // 
      // btnConfirmar
      // 
      this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnConfirmar.Location = new System.Drawing.Point(245, 236);
      this.btnConfirmar.Name = "btnConfirmar";
      this.btnConfirmar.Size = new System.Drawing.Size(124, 34);
      this.btnConfirmar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnConfirmar.TabIndex = 55;
      this.btnConfirmar.Text = "Confirmar";
      this.btnConfirmar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnConfirmar.UseSelectable = true;
      this.btnConfirmar.UseStyleColors = true;
      this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnCancelar.Location = new System.Drawing.Point(101, 236);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(124, 34);
      this.btnCancelar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnCancelar.TabIndex = 54;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnCancelar.UseSelectable = true;
      this.btnCancelar.UseStyleColors = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
      // 
      // errorProvider1
      // 
      this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider1.ContainerControl = this;
      // 
      // fechaHoras
      // 
      this.fechaHoras.Location = new System.Drawing.Point(28, 166);
      this.fechaHoras.MinimumSize = new System.Drawing.Size(0, 29);
      this.fechaHoras.Name = "fechaHoras";
      this.fechaHoras.Size = new System.Drawing.Size(340, 29);
      this.fechaHoras.TabIndex = 56;
      // 
      // cantidadHoras
      // 
      this.cantidadHoras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cantidadHoras.Location = new System.Drawing.Point(28, 96);
      this.cantidadHoras.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.cantidadHoras.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.cantidadHoras.Name = "cantidadHoras";
      this.cantidadHoras.Size = new System.Drawing.Size(340, 29);
      this.cantidadHoras.TabIndex = 57;
      this.cantidadHoras.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // CargarHorasForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(400, 294);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnConfirmar);
      this.Controls.Add(this.fechaHoras);
      this.Controls.Add(this.metroLabel4);
      this.Controls.Add(this.cantidadHoras);
      this.MaximizeBox = false;
      this.Name = "CargarHorasForm";
      this.Text = "Cargar Horas Trabajadas";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cantidadHoras)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    public MetroFramework.Controls.MetroLabel metroLabel4;
    public MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroButton btnConfirmar;
    private MetroFramework.Controls.MetroButton btnCancelar;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private MetroFramework.Controls.MetroDateTime fechaHoras;
    private System.Windows.Forms.NumericUpDown cantidadHoras;
  }
}