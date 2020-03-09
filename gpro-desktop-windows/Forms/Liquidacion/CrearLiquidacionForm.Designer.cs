namespace gpro_desktop_windows.Forms
{
  partial class CrearLiquidacionForm
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
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
      this.ComboBoxEmpleado = new MetroFramework.Controls.MetroComboBox();
      this.fechaDesde = new MetroFramework.Controls.MetroDateTime();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.fechaHasta = new MetroFramework.Controls.MetroDateTime();
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
      this.btnCancelar.Location = new System.Drawing.Point(487, 230);
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
      this.btnConfirmar.Location = new System.Drawing.Point(631, 230);
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
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(27, 70);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(72, 19);
      this.metroLabel2.TabIndex = 29;
      this.metroLabel2.Text = "Empleado:";
      // 
      // metroLabel7
      // 
      this.metroLabel7.AutoSize = true;
      this.metroLabel7.Location = new System.Drawing.Point(27, 142);
      this.metroLabel7.Name = "metroLabel7";
      this.metroLabel7.Size = new System.Drawing.Size(48, 19);
      this.metroLabel7.TabIndex = 32;
      this.metroLabel7.Text = "Desde:";
      // 
      // ComboBoxEmpleado
      // 
      this.ComboBoxEmpleado.FormattingEnabled = true;
      this.ComboBoxEmpleado.ItemHeight = 23;
      this.ComboBoxEmpleado.Location = new System.Drawing.Point(27, 94);
      this.ComboBoxEmpleado.Name = "ComboBoxEmpleado";
      this.ComboBoxEmpleado.Size = new System.Drawing.Size(728, 29);
      this.ComboBoxEmpleado.TabIndex = 34;
      this.ComboBoxEmpleado.UseSelectable = true;
      // 
      // fechaDesde
      // 
      this.fechaDesde.Location = new System.Drawing.Point(27, 165);
      this.fechaDesde.MinimumSize = new System.Drawing.Size(0, 29);
      this.fechaDesde.Name = "fechaDesde";
      this.fechaDesde.Size = new System.Drawing.Size(340, 29);
      this.fechaDesde.TabIndex = 57;
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(415, 142);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(41, 19);
      this.metroLabel1.TabIndex = 58;
      this.metroLabel1.Text = "Hasta";
      // 
      // fechaHasta
      // 
      this.fechaHasta.Location = new System.Drawing.Point(415, 165);
      this.fechaHasta.MinimumSize = new System.Drawing.Size(0, 29);
      this.fechaHasta.Name = "fechaHasta";
      this.fechaHasta.Size = new System.Drawing.Size(340, 29);
      this.fechaHasta.TabIndex = 59;
      // 
      // CrearLiquidacionForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(785, 291);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.fechaHasta);
      this.Controls.Add(this.metroLabel7);
      this.Controls.Add(this.btnConfirmar);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.ComboBoxEmpleado);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.fechaDesde);
      this.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.Name = "CrearLiquidacionForm";
      this.ShowIcon = false;
      this.Text = "Crear Liquidación";
      this.Load += new System.EventHandler(this.CrearLiquidacionForm_Load);
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
    public MetroFramework.Controls.MetroComboBox ComboBoxEmpleado;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroDateTime fechaHasta;
    private MetroFramework.Controls.MetroDateTime fechaDesde;
  }
}