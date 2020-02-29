namespace gpro_desktop_windows.UsersControls
{
  partial class ucEmpleados
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
      this.btnCrearEmpleado = new MetroFramework.Controls.MetroButton();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.btnBuscar = new MetroFramework.Controls.MetroButton();
      this.btnLimpiar = new MetroFramework.Controls.MetroButton();
      this.textBoxDato = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.textBoxDNI = new MetroFramework.Controls.MetroTextBox();
      this.mgEmpleados = new MetroFramework.Controls.MetroGrid();
      this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.apellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.mgEmpleados)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCrearEmpleado
      // 
      this.btnCrearEmpleado.Location = new System.Drawing.Point(100, 66);
      this.btnCrearEmpleado.Name = "btnCrearEmpleado";
      this.btnCrearEmpleado.Size = new System.Drawing.Size(137, 25);
      this.btnCrearEmpleado.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnCrearEmpleado.TabIndex = 0;
      this.btnCrearEmpleado.Text = "Crear Empleado";
      this.btnCrearEmpleado.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnCrearEmpleado.UseSelectable = true;
      this.btnCrearEmpleado.UseStyleColors = true;
      this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
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
      this.metroLabel3.Location = new System.Drawing.Point(706, 15);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(177, 25);
      this.metroLabel3.TabIndex = 5;
      this.metroLabel3.Text = "Gestión [ Empleados ]";
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
      // mgEmpleados
      // 
      this.mgEmpleados.AllowUserToResizeRows = false;
      this.mgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.mgEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mgEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.mgEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.mgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.apellidoEmpleado,
            this.nombreEmpleado,
            this.fechaIngreso,
            this.Telefono,
            this.Domicilio,
            this.Localidad,
            this.Provincia,
            this.Dni,
            this.Nacionalidad,
            this.FullName});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle2.Format = "d";
      dataGridViewCellStyle2.NullValue = null;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.mgEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
      this.mgEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgEmpleados.EnableHeadersVisualStyles = false;
      this.mgEmpleados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgEmpleados.Location = new System.Drawing.Point(100, 213);
      this.mgEmpleados.Name = "mgEmpleados";
      this.mgEmpleados.ReadOnly = true;
      this.mgEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.mgEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgEmpleados.Size = new System.Drawing.Size(774, 425);
      this.mgEmpleados.TabIndex = 8;
      this.mgEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgEmpleados_CellClick);
      this.mgEmpleados.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.mgEmpleados_CellPainting);
      // 
      // IdEmpleado
      // 
      this.IdEmpleado.DataPropertyName = "idEmpleado";
      this.IdEmpleado.HeaderText = "Id";
      this.IdEmpleado.Name = "IdEmpleado";
      this.IdEmpleado.ReadOnly = true;
      this.IdEmpleado.Visible = false;
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
      // fechaIngreso
      // 
      this.fechaIngreso.DataPropertyName = "fechaIngreso";
      this.fechaIngreso.HeaderText = "Fecha de Ingreso";
      this.fechaIngreso.Name = "fechaIngreso";
      this.fechaIngreso.ReadOnly = true;
      this.fechaIngreso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // Telefono
      // 
      this.Telefono.DataPropertyName = "Telefono";
      this.Telefono.HeaderText = "Teléfono";
      this.Telefono.Name = "Telefono";
      this.Telefono.ReadOnly = true;
      // 
      // Domicilio
      // 
      this.Domicilio.DataPropertyName = "Domicilio";
      this.Domicilio.HeaderText = "Dirección";
      this.Domicilio.Name = "Domicilio";
      this.Domicilio.ReadOnly = true;
      this.Domicilio.Visible = false;
      // 
      // Localidad
      // 
      this.Localidad.DataPropertyName = "Localidad";
      this.Localidad.HeaderText = "Localidad";
      this.Localidad.Name = "Localidad";
      this.Localidad.ReadOnly = true;
      this.Localidad.Visible = false;
      // 
      // Provincia
      // 
      this.Provincia.DataPropertyName = "Provincia";
      this.Provincia.HeaderText = "Provincia";
      this.Provincia.Name = "Provincia";
      this.Provincia.ReadOnly = true;
      this.Provincia.Visible = false;
      // 
      // Dni
      // 
      this.Dni.DataPropertyName = "Dni";
      this.Dni.HeaderText = "DNI";
      this.Dni.Name = "Dni";
      this.Dni.ReadOnly = true;
      // 
      // Nacionalidad
      // 
      this.Nacionalidad.DataPropertyName = "Nacionalidad";
      this.Nacionalidad.HeaderText = "Nacionalidad";
      this.Nacionalidad.Name = "Nacionalidad";
      this.Nacionalidad.ReadOnly = true;
      this.Nacionalidad.Visible = false;
      // 
      // FullName
      // 
      this.FullName.DataPropertyName = "FullName";
      this.FullName.HeaderText = "Nombre Completo";
      this.FullName.Name = "FullName";
      this.FullName.ReadOnly = true;
      this.FullName.Visible = false;
      // 
      // ucEmpleados
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.mgEmpleados);
      this.Controls.Add(this.textBoxDNI);
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.btnCrearEmpleado);
      this.Controls.Add(this.textBoxDato);
      this.Name = "ucEmpleados";
      this.Size = new System.Drawing.Size(900, 742);
      this.Style = MetroFramework.MetroColorStyle.Blue;
      this.Theme = MetroFramework.MetroThemeStyle.Light;
      this.UseStyleColors = true;
      ((System.ComponentModel.ISupportInitialize)(this.mgEmpleados)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MetroFramework.Controls.MetroButton btnCrearEmpleado;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroButton btnBuscar;
    private MetroFramework.Controls.MetroButton btnLimpiar;
    private MetroFramework.Controls.MetroTextBox textBoxDato;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    private MetroFramework.Controls.MetroTextBox textBoxDNI;
    public MetroFramework.Controls.MetroGrid mgEmpleados;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleado;
    private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
    private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
    private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
    private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
    private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
    private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
  }
}
