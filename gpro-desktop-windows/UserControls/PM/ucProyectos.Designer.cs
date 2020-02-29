namespace gpro_desktop_windows.UsersControls
{
  partial class ucProyectos
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
      this.btnCrearProyecto = new MetroFramework.Controls.MetroButton();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.btnBuscar = new MetroFramework.Controls.MetroButton();
      this.btnLimpiar = new MetroFramework.Controls.MetroButton();
      this.textBoxProyecto = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.textBoxEstado = new MetroFramework.Controls.MetroTextBox();
      this.mgProyectos = new MetroFramework.Controls.MetroGrid();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TituloProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescripciónProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EstadoProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnVerTodosProyectos = new MetroFramework.Controls.MetroButton();
      ((System.ComponentModel.ISupportInitialize)(this.mgProyectos)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCrearProyecto
      // 
      this.btnCrearProyecto.Location = new System.Drawing.Point(100, 66);
      this.btnCrearProyecto.Name = "btnCrearProyecto";
      this.btnCrearProyecto.Size = new System.Drawing.Size(137, 25);
      this.btnCrearProyecto.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnCrearProyecto.TabIndex = 0;
      this.btnCrearProyecto.Text = "Crear Proyecto";
      this.btnCrearProyecto.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnCrearProyecto.UseSelectable = true;
      this.btnCrearProyecto.UseStyleColors = true;
      this.btnCrearProyecto.Click += new System.EventHandler(this.btnCrearProyecto_Click);
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(100, 108);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(61, 19);
      this.metroLabel1.TabIndex = 2;
      this.metroLabel1.Text = "Proyecto";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(498, 108);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(48, 19);
      this.metroLabel2.TabIndex = 2;
      this.metroLabel2.Text = "Estado";
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
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
      this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
      // 
      // textBoxProyecto
      // 
      // 
      // 
      // 
      this.textBoxProyecto.CustomButton.Image = null;
      this.textBoxProyecto.CustomButton.Location = new System.Drawing.Point(353, 1);
      this.textBoxProyecto.CustomButton.Name = "";
      this.textBoxProyecto.CustomButton.Size = new System.Drawing.Size(23, 23);
      this.textBoxProyecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxProyecto.CustomButton.TabIndex = 1;
      this.textBoxProyecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxProyecto.CustomButton.UseSelectable = true;
      this.textBoxProyecto.CustomButton.Visible = false;
      this.textBoxProyecto.Lines = new string[0];
      this.textBoxProyecto.Location = new System.Drawing.Point(100, 128);
      this.textBoxProyecto.MaxLength = 32767;
      this.textBoxProyecto.Name = "textBoxProyecto";
      this.textBoxProyecto.PasswordChar = '\0';
      this.textBoxProyecto.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxProyecto.SelectedText = "";
      this.textBoxProyecto.SelectionLength = 0;
      this.textBoxProyecto.SelectionStart = 0;
      this.textBoxProyecto.ShortcutsEnabled = true;
      this.textBoxProyecto.Size = new System.Drawing.Size(377, 25);
      this.textBoxProyecto.TabIndex = 3;
      this.textBoxProyecto.UseSelectable = true;
      this.textBoxProyecto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxProyecto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
      this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel3.ForeColor = System.Drawing.Color.Black;
      this.metroLabel3.Location = new System.Drawing.Point(716, 15);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(167, 25);
      this.metroLabel3.TabIndex = 5;
      this.metroLabel3.Text = "Gestión [ Proyectos ]";
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
      // textBoxEstado
      // 
      // 
      // 
      // 
      this.textBoxEstado.CustomButton.Image = null;
      this.textBoxEstado.CustomButton.Location = new System.Drawing.Point(353, 1);
      this.textBoxEstado.CustomButton.Name = "";
      this.textBoxEstado.CustomButton.Size = new System.Drawing.Size(23, 23);
      this.textBoxEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxEstado.CustomButton.TabIndex = 1;
      this.textBoxEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxEstado.CustomButton.UseSelectable = true;
      this.textBoxEstado.CustomButton.Visible = false;
      this.textBoxEstado.Lines = new string[0];
      this.textBoxEstado.Location = new System.Drawing.Point(498, 128);
      this.textBoxEstado.MaxLength = 32767;
      this.textBoxEstado.Name = "textBoxEstado";
      this.textBoxEstado.PasswordChar = '\0';
      this.textBoxEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxEstado.SelectedText = "";
      this.textBoxEstado.SelectionLength = 0;
      this.textBoxEstado.SelectionStart = 0;
      this.textBoxEstado.ShortcutsEnabled = true;
      this.textBoxEstado.Size = new System.Drawing.Size(377, 25);
      this.textBoxEstado.TabIndex = 7;
      this.textBoxEstado.UseSelectable = true;
      this.textBoxEstado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxEstado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.Id,
            this.IdCliente,
            this.TituloProyecto,
            this.DescripciónProyecto,
            this.EstadoProyecto,
            this.NombreCliente,
            this.ApellidoCliente});
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
      this.mgProyectos.Location = new System.Drawing.Point(100, 213);
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
      this.mgProyectos.Size = new System.Drawing.Size(774, 425);
      this.mgProyectos.TabIndex = 8;
      // 
      // Id
      // 
      this.Id.DataPropertyName = "IdProyecto";
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Visible = false;
      // 
      // IdCliente
      // 
      this.IdCliente.DataPropertyName = "ClienteId";
      this.IdCliente.HeaderText = "Id Cliente";
      this.IdCliente.Name = "IdCliente";
      this.IdCliente.ReadOnly = true;
      this.IdCliente.Visible = false;
      // 
      // TituloProyecto
      // 
      this.TituloProyecto.DataPropertyName = "TituloProyecto";
      this.TituloProyecto.HeaderText = "Proyecto";
      this.TituloProyecto.Name = "TituloProyecto";
      this.TituloProyecto.ReadOnly = true;
      // 
      // DescripciónProyecto
      // 
      this.DescripciónProyecto.DataPropertyName = "DescripcionProyecto";
      this.DescripciónProyecto.HeaderText = "Descripción";
      this.DescripciónProyecto.Name = "DescripciónProyecto";
      this.DescripciónProyecto.ReadOnly = true;
      // 
      // EstadoProyecto
      // 
      this.EstadoProyecto.DataPropertyName = "EstadoProyecto";
      this.EstadoProyecto.HeaderText = "Estado";
      this.EstadoProyecto.Name = "EstadoProyecto";
      this.EstadoProyecto.ReadOnly = true;
      // 
      // NombreCliente
      // 
      this.NombreCliente.DataPropertyName = "NombreCliente";
      this.NombreCliente.HeaderText = "Nombre";
      this.NombreCliente.Name = "NombreCliente";
      this.NombreCliente.ReadOnly = true;
      this.NombreCliente.Visible = false;
      // 
      // ApellidoCliente
      // 
      this.ApellidoCliente.DataPropertyName = "ApellidoCliente";
      this.ApellidoCliente.HeaderText = "Apellido";
      this.ApellidoCliente.Name = "ApellidoCliente";
      this.ApellidoCliente.ReadOnly = true;
      this.ApellidoCliente.Visible = false;
      // 
      // btnVerTodosProyectos
      // 
      this.btnVerTodosProyectos.Location = new System.Drawing.Point(254, 66);
      this.btnVerTodosProyectos.Name = "btnVerTodosProyectos";
      this.btnVerTodosProyectos.Size = new System.Drawing.Size(137, 25);
      this.btnVerTodosProyectos.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnVerTodosProyectos.TabIndex = 9;
      this.btnVerTodosProyectos.Text = "Ver todos los Proyectos";
      this.btnVerTodosProyectos.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnVerTodosProyectos.UseSelectable = true;
      this.btnVerTodosProyectos.UseStyleColors = true;
      this.btnVerTodosProyectos.Click += new System.EventHandler(this.btnVerTodosProyectos_Click);
      // 
      // ucProyectos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnVerTodosProyectos);
      this.Controls.Add(this.mgProyectos);
      this.Controls.Add(this.textBoxEstado);
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.btnCrearProyecto);
      this.Controls.Add(this.textBoxProyecto);
      this.Name = "ucProyectos";
      this.Size = new System.Drawing.Size(900, 742);
      this.Style = MetroFramework.MetroColorStyle.Blue;
      this.Theme = MetroFramework.MetroThemeStyle.Light;
      this.UseStyleColors = true;
      ((System.ComponentModel.ISupportInitialize)(this.mgProyectos)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MetroFramework.Controls.MetroButton btnCrearProyecto;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroButton btnBuscar;
    private MetroFramework.Controls.MetroButton btnLimpiar;
    private MetroFramework.Controls.MetroTextBox textBoxProyecto;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    private MetroFramework.Controls.MetroTextBox textBoxEstado;
    public MetroFramework.Controls.MetroGrid mgProyectos;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn TituloProyecto;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescripciónProyecto;
    private System.Windows.Forms.DataGridViewTextBoxColumn EstadoProyecto;
    private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
    private MetroFramework.Controls.MetroButton btnVerTodosProyectos;
  }
}
