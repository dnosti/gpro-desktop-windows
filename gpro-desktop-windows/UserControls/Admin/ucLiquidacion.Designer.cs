namespace gpro_desktop_windows.UsersControls
{
  partial class ucLiquidacion
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnCrearLiquidacion = new MetroFramework.Controls.MetroButton();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.mgLiquidacion = new MetroFramework.Controls.MetroGrid();
      this.btnVerTodasLiquidaciones = new MetroFramework.Controls.MetroButton();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ApellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CantHorasTrab = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdEscalaHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PorcentajeHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasOverBudget = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdEscalaPerfiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CantPerfiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PorcentajePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CantAnios = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdEscalaAntiguedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.mgLiquidacion)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCrearLiquidacion
      // 
      this.btnCrearLiquidacion.Location = new System.Drawing.Point(100, 66);
      this.btnCrearLiquidacion.Name = "btnCrearLiquidacion";
      this.btnCrearLiquidacion.Size = new System.Drawing.Size(137, 25);
      this.btnCrearLiquidacion.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnCrearLiquidacion.TabIndex = 0;
      this.btnCrearLiquidacion.Text = "Crear Liquidación";
      this.btnCrearLiquidacion.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnCrearLiquidacion.UseSelectable = true;
      this.btnCrearLiquidacion.UseStyleColors = true;
      this.btnCrearLiquidacion.Click += new System.EventHandler(this.btnCrearLiquidacion_Click);
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
      this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel3.ForeColor = System.Drawing.Color.Black;
      this.metroLabel3.Location = new System.Drawing.Point(701, 15);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(181, 25);
      this.metroLabel3.TabIndex = 5;
      this.metroLabel3.Text = "Gestión [ Liquidación ]";
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
      // mgLiquidacion
      // 
      this.mgLiquidacion.AllowUserToResizeRows = false;
      this.mgLiquidacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.mgLiquidacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgLiquidacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mgLiquidacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.mgLiquidacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgLiquidacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.mgLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgLiquidacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdEmpleado,
            this.Empleado,
            this.ApellidoEmpleado,
            this.NombreEmpleado,
            this.FechaDesde,
            this.FechaHasta,
            this.CantHorasTrab,
            this.Importe,
            this.IdEscalaHoras,
            this.PorcentajeHoras,
            this.HorasOverBudget,
            this.IdEscalaPerfiles,
            this.CantPerfiles,
            this.PorcentajePerfil,
            this.CantAnios,
            this.IdEscalaAntiguedad,
            this.Porcentaje});
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.mgLiquidacion.DefaultCellStyle = dataGridViewCellStyle3;
      this.mgLiquidacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgLiquidacion.EnableHeadersVisualStyles = false;
      this.mgLiquidacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgLiquidacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgLiquidacion.Location = new System.Drawing.Point(100, 113);
      this.mgLiquidacion.Name = "mgLiquidacion";
      this.mgLiquidacion.ReadOnly = true;
      this.mgLiquidacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgLiquidacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.mgLiquidacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgLiquidacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgLiquidacion.Size = new System.Drawing.Size(774, 425);
      this.mgLiquidacion.TabIndex = 8;
      this.mgLiquidacion.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.mgLiquidacion_CellPainting);
      // 
      // btnVerTodasLiquidaciones
      // 
      this.btnVerTodasLiquidaciones.Location = new System.Drawing.Point(254, 66);
      this.btnVerTodasLiquidaciones.Name = "btnVerTodasLiquidaciones";
      this.btnVerTodasLiquidaciones.Size = new System.Drawing.Size(167, 25);
      this.btnVerTodasLiquidaciones.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnVerTodasLiquidaciones.TabIndex = 10;
      this.btnVerTodasLiquidaciones.Text = "Ver todas las Liquidaciones";
      this.btnVerTodasLiquidaciones.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnVerTodasLiquidaciones.UseSelectable = true;
      this.btnVerTodasLiquidaciones.UseStyleColors = true;
      this.btnVerTodasLiquidaciones.Click += new System.EventHandler(this.btnVerTodasLiquidaciones_Click);
      // 
      // Id
      // 
      this.Id.DataPropertyName = "Id";
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Visible = false;
      // 
      // IdEmpleado
      // 
      this.IdEmpleado.DataPropertyName = "IdEmpleado";
      this.IdEmpleado.HeaderText = "IdEmpleado";
      this.IdEmpleado.Name = "IdEmpleado";
      this.IdEmpleado.ReadOnly = true;
      this.IdEmpleado.Visible = false;
      // 
      // Empleado
      // 
      this.Empleado.DataPropertyName = "FullName";
      this.Empleado.HeaderText = "Empleado";
      this.Empleado.Name = "Empleado";
      this.Empleado.ReadOnly = true;
      // 
      // ApellidoEmpleado
      // 
      this.ApellidoEmpleado.DataPropertyName = "ApellidoEmpleado";
      this.ApellidoEmpleado.HeaderText = "ApellidoEmpleado";
      this.ApellidoEmpleado.Name = "ApellidoEmpleado";
      this.ApellidoEmpleado.ReadOnly = true;
      this.ApellidoEmpleado.Visible = false;
      // 
      // NombreEmpleado
      // 
      this.NombreEmpleado.DataPropertyName = "NombreEmpleado";
      this.NombreEmpleado.HeaderText = "NombreEmpleado";
      this.NombreEmpleado.Name = "NombreEmpleado";
      this.NombreEmpleado.ReadOnly = true;
      this.NombreEmpleado.Visible = false;
      // 
      // FechaDesde
      // 
      this.FechaDesde.DataPropertyName = "FechaDesde";
      this.FechaDesde.HeaderText = "Desde";
      this.FechaDesde.Name = "FechaDesde";
      this.FechaDesde.ReadOnly = true;
      // 
      // FechaHasta
      // 
      this.FechaHasta.DataPropertyName = "FechaHasta";
      this.FechaHasta.HeaderText = "Hasta";
      this.FechaHasta.Name = "FechaHasta";
      this.FechaHasta.ReadOnly = true;
      // 
      // CantHorasTrab
      // 
      this.CantHorasTrab.DataPropertyName = "CantHorasTrab";
      this.CantHorasTrab.HeaderText = "Horas Trabajadas";
      this.CantHorasTrab.Name = "CantHorasTrab";
      this.CantHorasTrab.ReadOnly = true;
      // 
      // Importe
      // 
      this.Importe.DataPropertyName = "Importe";
      dataGridViewCellStyle2.Format = "C2";
      dataGridViewCellStyle2.NullValue = null;
      this.Importe.DefaultCellStyle = dataGridViewCellStyle2;
      this.Importe.HeaderText = "Importe";
      this.Importe.Name = "Importe";
      this.Importe.ReadOnly = true;
      // 
      // IdEscalaHoras
      // 
      this.IdEscalaHoras.DataPropertyName = "IdEscalaHoras";
      this.IdEscalaHoras.HeaderText = "Escala Horas";
      this.IdEscalaHoras.Name = "IdEscalaHoras";
      this.IdEscalaHoras.ReadOnly = true;
      this.IdEscalaHoras.Visible = false;
      // 
      // PorcentajeHoras
      // 
      this.PorcentajeHoras.DataPropertyName = "PorcentajeHoras";
      this.PorcentajeHoras.HeaderText = "Porcentaje";
      this.PorcentajeHoras.Name = "PorcentajeHoras";
      this.PorcentajeHoras.ReadOnly = true;
      this.PorcentajeHoras.Visible = false;
      // 
      // HorasOverBudget
      // 
      this.HorasOverBudget.DataPropertyName = "HorasOverBudget";
      this.HorasOverBudget.HeaderText = "Horas Overbudget";
      this.HorasOverBudget.Name = "HorasOverBudget";
      this.HorasOverBudget.ReadOnly = true;
      this.HorasOverBudget.Visible = false;
      // 
      // IdEscalaPerfiles
      // 
      this.IdEscalaPerfiles.DataPropertyName = "IdEscalaPerfiles";
      this.IdEscalaPerfiles.HeaderText = "Id Escala Perfiles";
      this.IdEscalaPerfiles.Name = "IdEscalaPerfiles";
      this.IdEscalaPerfiles.ReadOnly = true;
      this.IdEscalaPerfiles.Visible = false;
      // 
      // CantPerfiles
      // 
      this.CantPerfiles.DataPropertyName = "CantPerfiles";
      this.CantPerfiles.HeaderText = "Cantidad Perfiles";
      this.CantPerfiles.Name = "CantPerfiles";
      this.CantPerfiles.ReadOnly = true;
      this.CantPerfiles.Visible = false;
      // 
      // PorcentajePerfil
      // 
      this.PorcentajePerfil.DataPropertyName = "PorcentajePerfil";
      this.PorcentajePerfil.HeaderText = "Porcentaje Perfil";
      this.PorcentajePerfil.Name = "PorcentajePerfil";
      this.PorcentajePerfil.ReadOnly = true;
      this.PorcentajePerfil.Visible = false;
      // 
      // CantAnios
      // 
      this.CantAnios.DataPropertyName = "CantAnios";
      this.CantAnios.HeaderText = "Antigüedad";
      this.CantAnios.Name = "CantAnios";
      this.CantAnios.ReadOnly = true;
      this.CantAnios.Visible = false;
      // 
      // IdEscalaAntiguedad
      // 
      this.IdEscalaAntiguedad.DataPropertyName = "IdEscalaAntiguedad";
      this.IdEscalaAntiguedad.HeaderText = "Id Escala Antigüedad";
      this.IdEscalaAntiguedad.Name = "IdEscalaAntiguedad";
      this.IdEscalaAntiguedad.ReadOnly = true;
      this.IdEscalaAntiguedad.Visible = false;
      // 
      // Porcentaje
      // 
      this.Porcentaje.DataPropertyName = "Porcentaje";
      this.Porcentaje.HeaderText = "Porcentaje";
      this.Porcentaje.Name = "Porcentaje";
      this.Porcentaje.ReadOnly = true;
      this.Porcentaje.Visible = false;
      // 
      // ucLiquidacion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnVerTodasLiquidaciones);
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.btnCrearLiquidacion);
      this.Controls.Add(this.mgLiquidacion);
      this.Name = "ucLiquidacion";
      this.Size = new System.Drawing.Size(900, 742);
      this.Style = MetroFramework.MetroColorStyle.Blue;
      this.Theme = MetroFramework.MetroThemeStyle.Light;
      this.UseStyleColors = true;
      ((System.ComponentModel.ISupportInitialize)(this.mgLiquidacion)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MetroFramework.Controls.MetroButton btnCrearLiquidacion;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    public MetroFramework.Controls.MetroGrid mgLiquidacion;
    private MetroFramework.Controls.MetroButton btnVerTodasLiquidaciones;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesde;
    private System.Windows.Forms.DataGridViewTextBoxColumn FechaHasta;
    private System.Windows.Forms.DataGridViewTextBoxColumn CantHorasTrab;
    private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdEscalaHoras;
    private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeHoras;
    private System.Windows.Forms.DataGridViewTextBoxColumn HorasOverBudget;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdEscalaPerfiles;
    private System.Windows.Forms.DataGridViewTextBoxColumn CantPerfiles;
    private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajePerfil;
    private System.Windows.Forms.DataGridViewTextBoxColumn CantAnios;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdEscalaAntiguedad;
    private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
  }
}
