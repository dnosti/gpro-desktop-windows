namespace gpro_desktop_windows.UsersControls
{
  partial class ucMiPanel
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.mgProyectos = new MetroFramework.Controls.MetroGrid();
      this.tareaLabel = new MetroFramework.Controls.MetroLabel();
      this.mgTarea = new MetroFramework.Controls.MetroGrid();
      this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TituloProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescripcionProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EstadoProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ProyectoIdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PerfilEmpleadoIdPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PerfilEmpleadoIdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescripcionTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasEstimadasTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasOverbudgetTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.mgProyectos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mgTarea)).BeginInit();
      this.SuspendLayout();
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(96, 62);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(106, 19);
      this.metroLabel1.TabIndex = 2;
      this.metroLabel1.Text = "[ Mis Proyectos ]";
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
      this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel3.ForeColor = System.Drawing.Color.Black;
      this.metroLabel3.Location = new System.Drawing.Point(719, 15);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(159, 25);
      this.metroLabel3.TabIndex = 5;
      this.metroLabel3.Text = "Gestión [ Mi Panel ]";
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
      // mgProyectos
      // 
      this.mgProyectos.AllowUserToResizeRows = false;
      this.mgProyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.mgProyectos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgProyectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mgProyectos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.mgProyectos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgProyectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.mgProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.IdProyecto,
            this.TituloProyecto,
            this.DescripcionProyecto,
            this.EstadoProyecto});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.mgProyectos.DefaultCellStyle = dataGridViewCellStyle2;
      this.mgProyectos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgProyectos.EnableHeadersVisualStyles = false;
      this.mgProyectos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgProyectos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgProyectos.Location = new System.Drawing.Point(96, 94);
      this.mgProyectos.Name = "mgProyectos";
      this.mgProyectos.ReadOnly = true;
      this.mgProyectos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgProyectos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.mgProyectos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgProyectos.Size = new System.Drawing.Size(774, 270);
      this.mgProyectos.TabIndex = 8;
      this.mgProyectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgProyectos_CellClick);
      this.mgProyectos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.mgProyectos_CellPainting);
      // 
      // tareaLabel
      // 
      this.tareaLabel.AutoSize = true;
      this.tareaLabel.Location = new System.Drawing.Point(96, 377);
      this.tareaLabel.Name = "tareaLabel";
      this.tareaLabel.Size = new System.Drawing.Size(130, 19);
      this.tareaLabel.TabIndex = 9;
      this.tareaLabel.Text = "[ Tarea en Proyecto ]";
      // 
      // mgTarea
      // 
      this.mgTarea.AllowUserToResizeRows = false;
      this.mgTarea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.mgTarea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mgTarea.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.mgTarea.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.mgTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgTarea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProyectoIdProyecto,
            this.IdTarea,
            this.PerfilEmpleadoIdPerfil,
            this.PerfilEmpleadoIdEmpleado,
            this.DescripcionTarea,
            this.HorasEstimadasTarea,
            this.HorasOverbudgetTarea});
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.mgTarea.DefaultCellStyle = dataGridViewCellStyle5;
      this.mgTarea.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgTarea.EnableHeadersVisualStyles = false;
      this.mgTarea.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgTarea.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgTarea.Location = new System.Drawing.Point(96, 408);
      this.mgTarea.Name = "mgTarea";
      this.mgTarea.ReadOnly = true;
      this.mgTarea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgTarea.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
      this.mgTarea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgTarea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgTarea.Size = new System.Drawing.Size(774, 91);
      this.mgTarea.TabIndex = 10;
      this.mgTarea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgTarea_CellClick);
      this.mgTarea.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.mgTarea_CellPainting);
      // 
      // IdEmpleado
      // 
      this.IdEmpleado.DataPropertyName = "IdEmpleado";
      this.IdEmpleado.HeaderText = "Id Empleado";
      this.IdEmpleado.Name = "IdEmpleado";
      this.IdEmpleado.ReadOnly = true;
      this.IdEmpleado.Visible = false;
      // 
      // IdProyecto
      // 
      this.IdProyecto.DataPropertyName = "IdProyecto";
      this.IdProyecto.HeaderText = "Id Proyecto";
      this.IdProyecto.Name = "IdProyecto";
      this.IdProyecto.ReadOnly = true;
      this.IdProyecto.Visible = false;
      // 
      // TituloProyecto
      // 
      this.TituloProyecto.DataPropertyName = "TituloProyecto";
      this.TituloProyecto.HeaderText = "Proyecto";
      this.TituloProyecto.Name = "TituloProyecto";
      this.TituloProyecto.ReadOnly = true;
      // 
      // DescripcionProyecto
      // 
      this.DescripcionProyecto.DataPropertyName = "DescripcionProyecto";
      this.DescripcionProyecto.HeaderText = "Descripción";
      this.DescripcionProyecto.Name = "DescripcionProyecto";
      this.DescripcionProyecto.ReadOnly = true;
      // 
      // EstadoProyecto
      // 
      this.EstadoProyecto.DataPropertyName = "EstadoProyecto";
      this.EstadoProyecto.HeaderText = "Estado";
      this.EstadoProyecto.Name = "EstadoProyecto";
      this.EstadoProyecto.ReadOnly = true;
      // 
      // ProyectoIdProyecto
      // 
      this.ProyectoIdProyecto.DataPropertyName = "ProyectoIdProyecto";
      this.ProyectoIdProyecto.HeaderText = "Id Proyecto";
      this.ProyectoIdProyecto.Name = "ProyectoIdProyecto";
      this.ProyectoIdProyecto.ReadOnly = true;
      this.ProyectoIdProyecto.Visible = false;
      // 
      // IdTarea
      // 
      this.IdTarea.DataPropertyName = "IdTarea";
      this.IdTarea.HeaderText = "Id Tarea";
      this.IdTarea.Name = "IdTarea";
      this.IdTarea.ReadOnly = true;
      this.IdTarea.Visible = false;
      // 
      // PerfilEmpleadoIdPerfil
      // 
      this.PerfilEmpleadoIdPerfil.DataPropertyName = "PerfilEmpleadoIdPerfil";
      this.PerfilEmpleadoIdPerfil.HeaderText = "Id Perfil";
      this.PerfilEmpleadoIdPerfil.Name = "PerfilEmpleadoIdPerfil";
      this.PerfilEmpleadoIdPerfil.ReadOnly = true;
      this.PerfilEmpleadoIdPerfil.Visible = false;
      // 
      // PerfilEmpleadoIdEmpleado
      // 
      this.PerfilEmpleadoIdEmpleado.DataPropertyName = "PerfilEmpleadoIdEmpleado";
      this.PerfilEmpleadoIdEmpleado.HeaderText = "Id Empleado";
      this.PerfilEmpleadoIdEmpleado.Name = "PerfilEmpleadoIdEmpleado";
      this.PerfilEmpleadoIdEmpleado.ReadOnly = true;
      this.PerfilEmpleadoIdEmpleado.Visible = false;
      // 
      // DescripcionTarea
      // 
      this.DescripcionTarea.DataPropertyName = "DescripcionTarea";
      this.DescripcionTarea.HeaderText = "Tarea";
      this.DescripcionTarea.Name = "DescripcionTarea";
      this.DescripcionTarea.ReadOnly = true;
      // 
      // HorasEstimadasTarea
      // 
      this.HorasEstimadasTarea.DataPropertyName = "HorasEstimadasTarea";
      this.HorasEstimadasTarea.HeaderText = "Horas Estimadas";
      this.HorasEstimadasTarea.Name = "HorasEstimadasTarea";
      this.HorasEstimadasTarea.ReadOnly = true;
      // 
      // HorasOverbudgetTarea
      // 
      this.HorasOverbudgetTarea.DataPropertyName = "HorasOverbudgetTarea";
      this.HorasOverbudgetTarea.HeaderText = "Horas Overbudget";
      this.HorasOverbudgetTarea.Name = "HorasOverbudgetTarea";
      this.HorasOverbudgetTarea.ReadOnly = true;
      this.HorasOverbudgetTarea.Visible = false;
      // 
      // ucMiPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.mgTarea);
      this.Controls.Add(this.tareaLabel);
      this.Controls.Add(this.mgProyectos);
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.metroLabel1);
      this.Name = "ucMiPanel";
      this.Size = new System.Drawing.Size(900, 742);
      this.Style = MetroFramework.MetroColorStyle.Blue;
      this.Theme = MetroFramework.MetroThemeStyle.Light;
      this.UseStyleColors = true;
      ((System.ComponentModel.ISupportInitialize)(this.mgProyectos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mgTarea)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    public MetroFramework.Controls.MetroGrid mgProyectos;
    private MetroFramework.Controls.MetroLabel tareaLabel;
    public MetroFramework.Controls.MetroGrid mgTarea;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdProyecto;
    private System.Windows.Forms.DataGridViewTextBoxColumn TituloProyecto;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProyecto;
    private System.Windows.Forms.DataGridViewTextBoxColumn EstadoProyecto;
    private System.Windows.Forms.DataGridViewTextBoxColumn ProyectoIdProyecto;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdTarea;
    private System.Windows.Forms.DataGridViewTextBoxColumn PerfilEmpleadoIdPerfil;
    private System.Windows.Forms.DataGridViewTextBoxColumn PerfilEmpleadoIdEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionTarea;
    private System.Windows.Forms.DataGridViewTextBoxColumn HorasEstimadasTarea;
    private System.Windows.Forms.DataGridViewTextBoxColumn HorasOverbudgetTarea;
  }
}
