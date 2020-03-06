namespace gpro_desktop_windows.UsersControls
{
  partial class ucTareas
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.btnVerTodasTareas = new MetroFramework.Controls.MetroButton();
      this.mgTareas = new MetroFramework.Controls.MetroGrid();
      this.IdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TituloProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdEmpleadoPm = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdEmpleadoPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescripcionPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescripciónTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasEstimadasTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasOverbudgetTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.btnBuscar = new MetroFramework.Controls.MetroButton();
      this.btnCrearTarea = new MetroFramework.Controls.MetroButton();
      this.ComboBoxProyecto = new MetroFramework.Controls.MetroComboBox();
      this.ComboBoxEmpleado = new MetroFramework.Controls.MetroComboBox();
      this.btnLimpiar = new MetroFramework.Controls.MetroButton();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mgTareas)).BeginInit();
      this.SuspendLayout();
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
      this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel3.ForeColor = System.Drawing.Color.Black;
      this.metroLabel3.Location = new System.Drawing.Point(741, 15);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(140, 25);
      this.metroLabel3.TabIndex = 5;
      this.metroLabel3.Text = "Gestión [ Tareas ]";
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
      // errorProvider1
      // 
      this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider1.ContainerControl = this;
      // 
      // btnVerTodasTareas
      // 
      this.btnVerTodasTareas.Location = new System.Drawing.Point(254, 66);
      this.btnVerTodasTareas.Name = "btnVerTodasTareas";
      this.btnVerTodasTareas.Size = new System.Drawing.Size(137, 25);
      this.btnVerTodasTareas.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnVerTodasTareas.TabIndex = 18;
      this.btnVerTodasTareas.Text = "Ver todas las Tareas";
      this.btnVerTodasTareas.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnVerTodasTareas.UseSelectable = true;
      this.btnVerTodasTareas.UseStyleColors = true;
      this.btnVerTodasTareas.Click += new System.EventHandler(this.btnVerTodasTareas_Click);
      // 
      // mgTareas
      // 
      this.mgTareas.AllowUserToResizeRows = false;
      this.mgTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.mgTareas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgTareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mgTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.mgTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
      this.mgTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProyecto,
            this.TituloProyecto,
            this.IdEmpleadoPm,
            this.IdTarea,
            this.IdEmpleadoPerfil,
            this.DescripcionPerfil,
            this.IdEmpleado,
            this.Fullname,
            this.DescripciónTarea,
            this.HorasEstimadasTarea,
            this.HorasOverbudgetTarea});
      dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.mgTareas.DefaultCellStyle = dataGridViewCellStyle14;
      this.mgTareas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgTareas.EnableHeadersVisualStyles = false;
      this.mgTareas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgTareas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgTareas.Location = new System.Drawing.Point(100, 213);
      this.mgTareas.Name = "mgTareas";
      this.mgTareas.ReadOnly = true;
      this.mgTareas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgTareas.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
      this.mgTareas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgTareas.Size = new System.Drawing.Size(774, 425);
      this.mgTareas.TabIndex = 17;
      this.mgTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgTareas_CellClick);
      this.mgTareas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.mgTareas_CellPainting);
      // 
      // IdProyecto
      // 
      this.IdProyecto.DataPropertyName = "ProyectoIdProyecto";
      this.IdProyecto.HeaderText = "IdProyecto";
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
      // IdEmpleadoPm
      // 
      this.IdEmpleadoPm.DataPropertyName = "IdEmpleadoPm";
      this.IdEmpleadoPm.HeaderText = "Id Project Manager";
      this.IdEmpleadoPm.Name = "IdEmpleadoPm";
      this.IdEmpleadoPm.ReadOnly = true;
      this.IdEmpleadoPm.Visible = false;
      // 
      // IdTarea
      // 
      this.IdTarea.DataPropertyName = "IdTarea";
      this.IdTarea.HeaderText = "Id Tarea";
      this.IdTarea.Name = "IdTarea";
      this.IdTarea.ReadOnly = true;
      this.IdTarea.Visible = false;
      // 
      // IdEmpleadoPerfil
      // 
      this.IdEmpleadoPerfil.DataPropertyName = "PerfilEmpleadoIdPerfil";
      this.IdEmpleadoPerfil.HeaderText = "Id Perfil Empleado";
      this.IdEmpleadoPerfil.Name = "IdEmpleadoPerfil";
      this.IdEmpleadoPerfil.ReadOnly = true;
      this.IdEmpleadoPerfil.Visible = false;
      // 
      // DescripcionPerfil
      // 
      this.DescripcionPerfil.DataPropertyName = "DescripcionPerfil";
      this.DescripcionPerfil.HeaderText = "Descripción Perfl";
      this.DescripcionPerfil.Name = "DescripcionPerfil";
      this.DescripcionPerfil.ReadOnly = true;
      this.DescripcionPerfil.Visible = false;
      // 
      // IdEmpleado
      // 
      this.IdEmpleado.DataPropertyName = "PerfilEmpleadoIdEmpleado";
      this.IdEmpleado.HeaderText = "Id Empleado";
      this.IdEmpleado.Name = "IdEmpleado";
      this.IdEmpleado.ReadOnly = true;
      this.IdEmpleado.Visible = false;
      // 
      // Fullname
      // 
      this.Fullname.DataPropertyName = "Fullname";
      this.Fullname.HeaderText = "Empleado";
      this.Fullname.Name = "Fullname";
      this.Fullname.ReadOnly = true;
      // 
      // DescripciónTarea
      // 
      this.DescripciónTarea.DataPropertyName = "DescripcionTarea";
      this.DescripciónTarea.HeaderText = "Tarea";
      this.DescripciónTarea.Name = "DescripciónTarea";
      this.DescripciónTarea.ReadOnly = true;
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
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(498, 108);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(69, 19);
      this.metroLabel2.TabIndex = 13;
      this.metroLabel2.Text = "Empleado";
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(100, 108);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(61, 19);
      this.metroLabel1.TabIndex = 14;
      this.metroLabel1.Text = "Proyecto";
      // 
      // btnBuscar
      // 
      this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnBuscar.Location = new System.Drawing.Point(642, 166);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(107, 25);
      this.btnBuscar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnBuscar.TabIndex = 11;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnBuscar.UseSelectable = true;
      this.btnBuscar.UseStyleColors = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // btnCrearTarea
      // 
      this.btnCrearTarea.Location = new System.Drawing.Point(100, 66);
      this.btnCrearTarea.Name = "btnCrearTarea";
      this.btnCrearTarea.Size = new System.Drawing.Size(137, 25);
      this.btnCrearTarea.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnCrearTarea.TabIndex = 12;
      this.btnCrearTarea.Text = "Crear Tarea";
      this.btnCrearTarea.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnCrearTarea.UseSelectable = true;
      this.btnCrearTarea.UseStyleColors = true;
      this.btnCrearTarea.Click += new System.EventHandler(this.btnCrearTarea_Click);
      // 
      // ComboBoxProyecto
      // 
      this.ComboBoxProyecto.FormattingEnabled = true;
      this.ComboBoxProyecto.ItemHeight = 23;
      this.ComboBoxProyecto.Location = new System.Drawing.Point(100, 128);
      this.ComboBoxProyecto.Name = "ComboBoxProyecto";
      this.ComboBoxProyecto.Size = new System.Drawing.Size(377, 29);
      this.ComboBoxProyecto.TabIndex = 35;
      this.ComboBoxProyecto.UseSelectable = true;
      // 
      // ComboBoxEmpleado
      // 
      this.ComboBoxEmpleado.FormattingEnabled = true;
      this.ComboBoxEmpleado.ItemHeight = 23;
      this.ComboBoxEmpleado.Location = new System.Drawing.Point(498, 128);
      this.ComboBoxEmpleado.Name = "ComboBoxEmpleado";
      this.ComboBoxEmpleado.Size = new System.Drawing.Size(376, 29);
      this.ComboBoxEmpleado.TabIndex = 36;
      this.ComboBoxEmpleado.UseSelectable = true;
      // 
      // btnLimpiar
      // 
      this.btnLimpiar.Location = new System.Drawing.Point(767, 166);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new System.Drawing.Size(107, 25);
      this.btnLimpiar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnLimpiar.TabIndex = 37;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnLimpiar.UseSelectable = true;
      this.btnLimpiar.UseStyleColors = true;
      this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
      // 
      // ucTareas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.btnVerTodasTareas);
      this.Controls.Add(this.mgTareas);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.btnCrearTarea);
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.ComboBoxProyecto);
      this.Controls.Add(this.ComboBoxEmpleado);
      this.Name = "ucTareas";
      this.Size = new System.Drawing.Size(900, 742);
      this.Style = MetroFramework.MetroColorStyle.Blue;
      this.Theme = MetroFramework.MetroThemeStyle.Light;
      this.UseStyleColors = true;
      this.Load += new System.EventHandler(this.ucTareas_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mgTareas)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private MetroFramework.Controls.MetroButton btnVerTodasTareas;
    public MetroFramework.Controls.MetroGrid mgTareas;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroButton btnBuscar;
    private MetroFramework.Controls.MetroButton btnCrearTarea;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdProyecto;
    private System.Windows.Forms.DataGridViewTextBoxColumn TituloProyecto;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleadoPm;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdTarea;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleadoPerfil;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPerfil;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescripciónTarea;
    private System.Windows.Forms.DataGridViewTextBoxColumn HorasEstimadasTarea;
    private System.Windows.Forms.DataGridViewTextBoxColumn HorasOverbudgetTarea;
    public MetroFramework.Controls.MetroComboBox ComboBoxProyecto;
    public MetroFramework.Controls.MetroComboBox ComboBoxEmpleado;
    private MetroFramework.Controls.MetroButton btnLimpiar;
  }
}
