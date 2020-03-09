namespace gpro_desktop_windows.Forms
{
  partial class HorasOverbudgetForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnCerrar = new MetroFramework.Controls.MetroButton();
      this.mgHorasOverbudget = new MetroFramework.Controls.MetroGrid();
      this.fechaDesde = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.fechaHasta = new MetroFramework.Controls.MetroTextBox();
      this.IdPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasEstimadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EstadoHorasTrab = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FechaHorasTrab = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescripcionPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ValorHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.mgHorasOverbudget)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCerrar
      // 
      this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnCerrar.Location = new System.Drawing.Point(640, 309);
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
      // mgHorasOverbudget
      // 
      this.mgHorasOverbudget.AllowUserToResizeRows = false;
      this.mgHorasOverbudget.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.mgHorasOverbudget.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgHorasOverbudget.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mgHorasOverbudget.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.mgHorasOverbudget.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgHorasOverbudget.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.mgHorasOverbudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgHorasOverbudget.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPerfil,
            this.FullName,
            this.HorasPerfil,
            this.HorasTotales,
            this.HorasEstimadas,
            this.EstadoHorasTrab,
            this.FechaHorasTrab,
            this.DescripcionPerfil,
            this.ValorHora,
            this.Nombre,
            this.Apellido});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.mgHorasOverbudget.DefaultCellStyle = dataGridViewCellStyle2;
      this.mgHorasOverbudget.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgHorasOverbudget.EnableHeadersVisualStyles = false;
      this.mgHorasOverbudget.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgHorasOverbudget.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgHorasOverbudget.Location = new System.Drawing.Point(27, 86);
      this.mgHorasOverbudget.Name = "mgHorasOverbudget";
      this.mgHorasOverbudget.ReadOnly = true;
      this.mgHorasOverbudget.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgHorasOverbudget.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.mgHorasOverbudget.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgHorasOverbudget.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgHorasOverbudget.Size = new System.Drawing.Size(737, 196);
      this.mgHorasOverbudget.TabIndex = 52;
      // 
      // fechaDesde
      // 
      // 
      // 
      // 
      this.fechaDesde.CustomButton.Image = null;
      this.fechaDesde.CustomButton.Location = new System.Drawing.Point(99, 1);
      this.fechaDesde.CustomButton.Name = "";
      this.fechaDesde.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.fechaDesde.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.fechaDesde.CustomButton.TabIndex = 1;
      this.fechaDesde.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.fechaDesde.CustomButton.UseSelectable = true;
      this.fechaDesde.CustomButton.Visible = false;
      this.fechaDesde.Enabled = false;
      this.fechaDesde.Lines = new string[0];
      this.fechaDesde.Location = new System.Drawing.Point(81, 320);
      this.fechaDesde.MaxLength = 32767;
      this.fechaDesde.Name = "fechaDesde";
      this.fechaDesde.PasswordChar = '\0';
      this.fechaDesde.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.fechaDesde.SelectedText = "";
      this.fechaDesde.SelectionLength = 0;
      this.fechaDesde.SelectionStart = 0;
      this.fechaDesde.ShortcutsEnabled = true;
      this.fechaDesde.Size = new System.Drawing.Size(121, 23);
      this.fechaDesde.TabIndex = 53;
      this.fechaDesde.UseSelectable = true;
      this.fechaDesde.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.fechaDesde.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(27, 320);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(48, 19);
      this.metroLabel1.TabIndex = 54;
      this.metroLabel1.Text = "Desde:";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(231, 320);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(44, 19);
      this.metroLabel2.TabIndex = 56;
      this.metroLabel2.Text = "Hasta:";
      // 
      // fechaHasta
      // 
      // 
      // 
      // 
      this.fechaHasta.CustomButton.Image = null;
      this.fechaHasta.CustomButton.Location = new System.Drawing.Point(99, 1);
      this.fechaHasta.CustomButton.Name = "";
      this.fechaHasta.CustomButton.Size = new System.Drawing.Size(21, 21);
      this.fechaHasta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.fechaHasta.CustomButton.TabIndex = 1;
      this.fechaHasta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.fechaHasta.CustomButton.UseSelectable = true;
      this.fechaHasta.CustomButton.Visible = false;
      this.fechaHasta.Enabled = false;
      this.fechaHasta.Lines = new string[0];
      this.fechaHasta.Location = new System.Drawing.Point(285, 320);
      this.fechaHasta.MaxLength = 32767;
      this.fechaHasta.Name = "fechaHasta";
      this.fechaHasta.PasswordChar = '\0';
      this.fechaHasta.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.fechaHasta.SelectedText = "";
      this.fechaHasta.SelectionLength = 0;
      this.fechaHasta.SelectionStart = 0;
      this.fechaHasta.ShortcutsEnabled = true;
      this.fechaHasta.Size = new System.Drawing.Size(121, 23);
      this.fechaHasta.TabIndex = 55;
      this.fechaHasta.UseSelectable = true;
      this.fechaHasta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.fechaHasta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // IdPerfil
      // 
      this.IdPerfil.DataPropertyName = "IdPerfil";
      this.IdPerfil.HeaderText = "Id Perfil";
      this.IdPerfil.Name = "IdPerfil";
      this.IdPerfil.ReadOnly = true;
      this.IdPerfil.Visible = false;
      // 
      // FullName
      // 
      this.FullName.DataPropertyName = "FullName";
      this.FullName.HeaderText = "Empleado";
      this.FullName.Name = "FullName";
      this.FullName.ReadOnly = true;
      // 
      // HorasPerfil
      // 
      this.HorasPerfil.DataPropertyName = "HorasPerfil";
      this.HorasPerfil.HeaderText = "Horas Overbudget";
      this.HorasPerfil.Name = "HorasPerfil";
      this.HorasPerfil.ReadOnly = true;
      // 
      // HorasTotales
      // 
      this.HorasTotales.DataPropertyName = "HorasTotales";
      this.HorasTotales.HeaderText = "Horas Totales";
      this.HorasTotales.Name = "HorasTotales";
      this.HorasTotales.ReadOnly = true;
      this.HorasTotales.Visible = false;
      // 
      // HorasEstimadas
      // 
      this.HorasEstimadas.DataPropertyName = "HorasEstimadas";
      this.HorasEstimadas.HeaderText = "Horas Estimadas";
      this.HorasEstimadas.Name = "HorasEstimadas";
      this.HorasEstimadas.ReadOnly = true;
      this.HorasEstimadas.Visible = false;
      // 
      // EstadoHorasTrab
      // 
      this.EstadoHorasTrab.DataPropertyName = "EstadoHorasTrab";
      this.EstadoHorasTrab.HeaderText = "Estado";
      this.EstadoHorasTrab.Name = "EstadoHorasTrab";
      this.EstadoHorasTrab.ReadOnly = true;
      // 
      // FechaHorasTrab
      // 
      this.FechaHorasTrab.DataPropertyName = "FechaHorasTrab";
      this.FechaHorasTrab.HeaderText = "Fecha";
      this.FechaHorasTrab.Name = "FechaHorasTrab";
      this.FechaHorasTrab.ReadOnly = true;
      // 
      // DescripcionPerfil
      // 
      this.DescripcionPerfil.DataPropertyName = "DescripcionPerfil";
      this.DescripcionPerfil.HeaderText = "Perfil";
      this.DescripcionPerfil.Name = "DescripcionPerfil";
      this.DescripcionPerfil.ReadOnly = true;
      // 
      // ValorHora
      // 
      this.ValorHora.DataPropertyName = "ValorHora";
      this.ValorHora.HeaderText = "Valor Hora";
      this.ValorHora.Name = "ValorHora";
      this.ValorHora.ReadOnly = true;
      // 
      // Nombre
      // 
      this.Nombre.DataPropertyName = "Nombre";
      this.Nombre.HeaderText = "Nombre";
      this.Nombre.Name = "Nombre";
      this.Nombre.ReadOnly = true;
      this.Nombre.Visible = false;
      // 
      // Apellido
      // 
      this.Apellido.DataPropertyName = "Apellido";
      this.Apellido.HeaderText = "Apellido";
      this.Apellido.Name = "Apellido";
      this.Apellido.ReadOnly = true;
      this.Apellido.Visible = false;
      // 
      // HorasOverbudgetForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(790, 368);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.fechaHasta);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.fechaDesde);
      this.Controls.Add(this.mgHorasOverbudget);
      this.Controls.Add(this.btnCerrar);
      this.MaximizeBox = false;
      this.Name = "HorasOverbudgetForm";
      this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
      this.Text = "Horas Overbudget [Informe Semanal]";
      ((System.ComponentModel.ISupportInitialize)(this.mgHorasOverbudget)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MetroFramework.Controls.MetroButton btnCerrar;
    public MetroFramework.Controls.MetroGrid mgHorasOverbudget;
    private MetroFramework.Controls.MetroTextBox fechaDesde;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroTextBox fechaHasta;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdPerfil;
    private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
    private System.Windows.Forms.DataGridViewTextBoxColumn HorasPerfil;
    private System.Windows.Forms.DataGridViewTextBoxColumn HorasTotales;
    private System.Windows.Forms.DataGridViewTextBoxColumn HorasEstimadas;
    private System.Windows.Forms.DataGridViewTextBoxColumn EstadoHorasTrab;
    private System.Windows.Forms.DataGridViewTextBoxColumn FechaHorasTrab;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPerfil;
    private System.Windows.Forms.DataGridViewTextBoxColumn ValorHora;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
  }
}