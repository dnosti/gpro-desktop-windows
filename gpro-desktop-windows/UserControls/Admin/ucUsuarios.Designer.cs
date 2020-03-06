namespace gpro_desktop_windows.UsersControls
{
  partial class ucUsuarios
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnCrearUsuario = new MetroFramework.Controls.MetroButton();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.btnBuscar = new MetroFramework.Controls.MetroButton();
      this.btnLimpiar = new MetroFramework.Controls.MetroButton();
      this.textBoxDato = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.textBoxDNI = new MetroFramework.Controls.MetroTextBox();
      this.mgUsuarios = new MetroFramework.Controls.MetroGrid();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescripcionRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.apellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnVerTodosUsuarios = new MetroFramework.Controls.MetroButton();
      ((System.ComponentModel.ISupportInitialize)(this.mgUsuarios)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCrearUsuario
      // 
      this.btnCrearUsuario.Location = new System.Drawing.Point(100, 66);
      this.btnCrearUsuario.Name = "btnCrearUsuario";
      this.btnCrearUsuario.Size = new System.Drawing.Size(137, 25);
      this.btnCrearUsuario.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnCrearUsuario.TabIndex = 0;
      this.btnCrearUsuario.Text = "Crear Usuario";
      this.btnCrearUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnCrearUsuario.UseSelectable = true;
      this.btnCrearUsuario.UseStyleColors = true;
      this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(100, 108);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(121, 19);
      this.metroLabel1.TabIndex = 2;
      this.metroLabel1.Text = "Apellido / Nombre";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(498, 108);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(31, 19);
      this.metroLabel2.TabIndex = 2;
      this.metroLabel2.Text = "DNI";
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
      // textBoxDato
      // 
      // 
      // 
      // 
      this.textBoxDato.CustomButton.Image = null;
      this.textBoxDato.CustomButton.Location = new System.Drawing.Point(353, 1);
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
      this.metroLabel3.Location = new System.Drawing.Point(722, 15);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(159, 25);
      this.metroLabel3.TabIndex = 5;
      this.metroLabel3.Text = "Gestión [ Usuarios ]";
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
      // textBoxDNI
      // 
      // 
      // 
      // 
      this.textBoxDNI.CustomButton.Image = null;
      this.textBoxDNI.CustomButton.Location = new System.Drawing.Point(353, 1);
      this.textBoxDNI.CustomButton.Name = "";
      this.textBoxDNI.CustomButton.Size = new System.Drawing.Size(23, 23);
      this.textBoxDNI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxDNI.CustomButton.TabIndex = 1;
      this.textBoxDNI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxDNI.CustomButton.UseSelectable = true;
      this.textBoxDNI.CustomButton.Visible = false;
      this.textBoxDNI.Lines = new string[0];
      this.textBoxDNI.Location = new System.Drawing.Point(498, 128);
      this.textBoxDNI.MaxLength = 32767;
      this.textBoxDNI.Name = "textBoxDNI";
      this.textBoxDNI.PasswordChar = '\0';
      this.textBoxDNI.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxDNI.SelectedText = "";
      this.textBoxDNI.SelectionLength = 0;
      this.textBoxDNI.SelectionStart = 0;
      this.textBoxDNI.ShortcutsEnabled = true;
      this.textBoxDNI.Size = new System.Drawing.Size(377, 25);
      this.textBoxDNI.TabIndex = 7;
      this.textBoxDNI.UseSelectable = true;
      this.textBoxDNI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxDNI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // mgUsuarios
      // 
      this.mgUsuarios.AllowUserToResizeRows = false;
      this.mgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.mgUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mgUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.mgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.mgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.IdEmpleado,
            this.IdRol,
            this.DescripcionRole,
            this.apellidoEmpleado,
            this.nombreEmpleado,
            this.Dni});
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle5.Format = "d";
      dataGridViewCellStyle5.NullValue = null;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.mgUsuarios.DefaultCellStyle = dataGridViewCellStyle5;
      this.mgUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgUsuarios.EnableHeadersVisualStyles = false;
      this.mgUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgUsuarios.Location = new System.Drawing.Point(100, 213);
      this.mgUsuarios.Name = "mgUsuarios";
      this.mgUsuarios.ReadOnly = true;
      this.mgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
      this.mgUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgUsuarios.Size = new System.Drawing.Size(774, 425);
      this.mgUsuarios.TabIndex = 8;
      this.mgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgEmpleados_CellClick);
      this.mgUsuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.mgEmpleados_CellPainting);
      // 
      // Id
      // 
      this.Id.DataPropertyName = "id";
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Visible = false;
      // 
      // Username
      // 
      this.Username.DataPropertyName = "Username";
      this.Username.HeaderText = "Username";
      this.Username.Name = "Username";
      this.Username.ReadOnly = true;
      // 
      // IdEmpleado
      // 
      this.IdEmpleado.DataPropertyName = "IdEmpleado";
      this.IdEmpleado.HeaderText = "Id Empleado";
      this.IdEmpleado.Name = "IdEmpleado";
      this.IdEmpleado.ReadOnly = true;
      this.IdEmpleado.Visible = false;
      // 
      // IdRol
      // 
      this.IdRol.DataPropertyName = "IdRol";
      this.IdRol.HeaderText = "Id Role";
      this.IdRol.Name = "IdRol";
      this.IdRol.ReadOnly = true;
      this.IdRol.Visible = false;
      // 
      // DescripcionRole
      // 
      this.DescripcionRole.DataPropertyName = "Descripcion";
      this.DescripcionRole.HeaderText = "Descripción";
      this.DescripcionRole.Name = "DescripcionRole";
      this.DescripcionRole.ReadOnly = true;
      this.DescripcionRole.Visible = false;
      // 
      // apellidoEmpleado
      // 
      this.apellidoEmpleado.DataPropertyName = "apellidoEmpleado";
      this.apellidoEmpleado.HeaderText = "Apellido";
      this.apellidoEmpleado.Name = "apellidoEmpleado";
      this.apellidoEmpleado.ReadOnly = true;
      // 
      // nombreEmpleado
      // 
      this.nombreEmpleado.DataPropertyName = "nombreEmpleado";
      this.nombreEmpleado.HeaderText = "Nombre";
      this.nombreEmpleado.Name = "nombreEmpleado";
      this.nombreEmpleado.ReadOnly = true;
      // 
      // Dni
      // 
      this.Dni.DataPropertyName = "Dni";
      this.Dni.HeaderText = "DNI";
      this.Dni.Name = "Dni";
      this.Dni.ReadOnly = true;
      // 
      // btnVerTodosUsuarios
      // 
      this.btnVerTodosUsuarios.Location = new System.Drawing.Point(254, 66);
      this.btnVerTodosUsuarios.Name = "btnVerTodosUsuarios";
      this.btnVerTodosUsuarios.Size = new System.Drawing.Size(137, 25);
      this.btnVerTodosUsuarios.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnVerTodosUsuarios.TabIndex = 12;
      this.btnVerTodosUsuarios.Text = "Ver todos los Usuarios";
      this.btnVerTodosUsuarios.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnVerTodosUsuarios.UseSelectable = true;
      this.btnVerTodosUsuarios.UseStyleColors = true;
      this.btnVerTodosUsuarios.Click += new System.EventHandler(this.btnVerTodosUsuarios_Click);
      // 
      // ucUsuarios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnVerTodosUsuarios);
      this.Controls.Add(this.mgUsuarios);
      this.Controls.Add(this.textBoxDNI);
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.btnCrearUsuario);
      this.Controls.Add(this.textBoxDato);
      this.Name = "ucUsuarios";
      this.Size = new System.Drawing.Size(900, 742);
      this.Style = MetroFramework.MetroColorStyle.Blue;
      this.Theme = MetroFramework.MetroThemeStyle.Light;
      this.UseStyleColors = true;
      ((System.ComponentModel.ISupportInitialize)(this.mgUsuarios)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MetroFramework.Controls.MetroButton btnCrearUsuario;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroButton btnBuscar;
    private MetroFramework.Controls.MetroButton btnLimpiar;
    private MetroFramework.Controls.MetroTextBox textBoxDato;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    private MetroFramework.Controls.MetroTextBox textBoxDNI;
    public MetroFramework.Controls.MetroGrid mgUsuarios;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Username;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionRole;
    private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
    private MetroFramework.Controls.MetroButton btnVerTodosUsuarios;
  }
}
