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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.mgProyectos = new MetroFramework.Controls.MetroGrid();
      this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TituloProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescripcionProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EstadoProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tareaLabel = new MetroFramework.Controls.MetroLabel();
      this.mgTarea = new MetroFramework.Controls.MetroGrid();
      this.ProyectoIdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PerfilEmpleadoIdPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PerfilEmpleadoIdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescripcionTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasEstimadasTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasOverbudgetTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnActualizar = new MetroFramework.Controls.MetroButton();
      ((System.ComponentModel.ISupportInitialize)(this.mgProyectos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mgTarea)).BeginInit();
      this.SuspendLayout();
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(100, 108);
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
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgProyectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
      this.mgProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.IdProyecto,
            this.TituloProyecto,
            this.DescripcionProyecto,
            this.EstadoProyecto});
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.mgProyectos.DefaultCellStyle = dataGridViewCellStyle8;
      this.mgProyectos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgProyectos.EnableHeadersVisualStyles = false;
      this.mgProyectos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgProyectos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgProyectos.Location = new System.Drawing.Point(100, 140);
      this.mgProyectos.Name = "mgProyectos";
      this.mgProyectos.ReadOnly = true;
      this.mgProyectos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgProyectos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
      this.mgProyectos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgProyectos.Size = new System.Drawing.Size(774, 270);
      this.mgProyectos.TabIndex = 8;
      this.mgProyectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgProyectos_CellClick);
      this.mgProyectos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.mgProyectos_CellPainting);
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
      // tareaLabel
      // 
      this.tareaLabel.AutoSize = true;
      this.tareaLabel.Location = new System.Drawing.Point(100, 423);
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
      dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
      this.mgTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgTarea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProyectoIdProyecto,
            this.IdTarea,
            this.PerfilEmpleadoIdPerfil,
            this.PerfilEmpleadoIdEmpleado,
            this.DescripcionTarea,
            this.HorasEstimadasTarea,
            this.HorasOverbudgetTarea});
      dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.mgTarea.DefaultCellStyle = dataGridViewCellStyle11;
      this.mgTarea.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgTarea.EnableHeadersVisualStyles = false;
      this.mgTarea.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgTarea.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgTarea.Location = new System.Drawing.Point(100, 454);
      this.mgTarea.Name = "mgTarea";
      this.mgTarea.ReadOnly = true;
      this.mgTarea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgTarea.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
      this.mgTarea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgTarea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgTarea.Size = new System.Drawing.Size(774, 91);
      this.mgTarea.TabIndex = 10;
      this.mgTarea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgTarea_CellClick);
      this.mgTarea.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.mgTarea_CellPainting);
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
      // btnActualizar
      // 
      this.btnActualizar.Location = new System.Drawing.Point(100, 66);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(137, 25);
      this.btnActualizar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnActualizar.TabIndex = 12;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnActualizar.UseSelectable = true;
      this.btnActualizar.UseStyleColors = true;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
      this.Controls.Add(this.btnActualizar);
      this.Name = "ucMiPanel";
      this.Size = new System.Drawing.Size(900, 742);
      this.Style = MetroFramework.MetroColorStyle.Blue;
      this.Theme = MetroFramework.MetroThemeStyle.Light;
      this.UseStyleColors = true;
      this.Load += new System.EventHandler(this.ucMiPanel_Load);
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
    private MetroFramework.Controls.MetroButton btnActualizar;
  }
}
