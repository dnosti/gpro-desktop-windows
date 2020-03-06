namespace gpro_desktop_windows.UsersControls
{
  partial class ucClientes
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
      this.btnCrearCliente = new MetroFramework.Controls.MetroButton();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.btnBuscar = new MetroFramework.Controls.MetroButton();
      this.btnLimpiar = new MetroFramework.Controls.MetroButton();
      this.textBoxDato = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.textBoxCUIT = new MetroFramework.Controls.MetroTextBox();
      this.mgClientes = new MetroFramework.Controls.MetroGrid();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.razonSocialCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.apellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.direccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.telefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.emailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnVerTodosClientes = new MetroFramework.Controls.MetroButton();
      ((System.ComponentModel.ISupportInitialize)(this.mgClientes)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCrearCliente
      // 
      this.btnCrearCliente.Location = new System.Drawing.Point(100, 66);
      this.btnCrearCliente.Name = "btnCrearCliente";
      this.btnCrearCliente.Size = new System.Drawing.Size(137, 25);
      this.btnCrearCliente.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnCrearCliente.TabIndex = 0;
      this.btnCrearCliente.Text = "Crear Cliente";
      this.btnCrearCliente.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnCrearCliente.UseSelectable = true;
      this.btnCrearCliente.UseStyleColors = true;
      this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(100, 108);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(208, 19);
      this.metroLabel1.TabIndex = 2;
      this.metroLabel1.Text = "Apellido / Nombre / Razón Social";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(498, 108);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(37, 19);
      this.metroLabel2.TabIndex = 2;
      this.metroLabel2.Text = "CUIT";
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
      this.metroLabel3.Location = new System.Drawing.Point(730, 15);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(153, 25);
      this.metroLabel3.TabIndex = 5;
      this.metroLabel3.Text = "Gestión [ Clientes ]";
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
      // textBoxCUIT
      // 
      // 
      // 
      // 
      this.textBoxCUIT.CustomButton.Image = null;
      this.textBoxCUIT.CustomButton.Location = new System.Drawing.Point(353, 1);
      this.textBoxCUIT.CustomButton.Name = "";
      this.textBoxCUIT.CustomButton.Size = new System.Drawing.Size(23, 23);
      this.textBoxCUIT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.textBoxCUIT.CustomButton.TabIndex = 1;
      this.textBoxCUIT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.textBoxCUIT.CustomButton.UseSelectable = true;
      this.textBoxCUIT.CustomButton.Visible = false;
      this.textBoxCUIT.Lines = new string[0];
      this.textBoxCUIT.Location = new System.Drawing.Point(498, 128);
      this.textBoxCUIT.MaxLength = 32767;
      this.textBoxCUIT.Name = "textBoxCUIT";
      this.textBoxCUIT.PasswordChar = '\0';
      this.textBoxCUIT.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.textBoxCUIT.SelectedText = "";
      this.textBoxCUIT.SelectionLength = 0;
      this.textBoxCUIT.SelectionStart = 0;
      this.textBoxCUIT.ShortcutsEnabled = true;
      this.textBoxCUIT.Size = new System.Drawing.Size(377, 25);
      this.textBoxCUIT.TabIndex = 7;
      this.textBoxCUIT.UseSelectable = true;
      this.textBoxCUIT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.textBoxCUIT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // mgClientes
      // 
      this.mgClientes.AllowUserToResizeRows = false;
      this.mgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.mgClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.mgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.mgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.idCliente,
            this.razonSocialCliente,
            this.apellidoCliente,
            this.nombreCliente,
            this.direccionCliente,
            this.telefonoCliente,
            this.emailCliente,
            this.FullName});
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.mgClientes.DefaultCellStyle = dataGridViewCellStyle5;
      this.mgClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgClientes.EnableHeadersVisualStyles = false;
      this.mgClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgClientes.Location = new System.Drawing.Point(100, 213);
      this.mgClientes.Name = "mgClientes";
      this.mgClientes.ReadOnly = true;
      this.mgClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
      this.mgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgClientes.Size = new System.Drawing.Size(774, 425);
      this.mgClientes.TabIndex = 8;
      this.mgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgClientes_CellClick);
      this.mgClientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.mgClientes_CellPainting);
      // 
      // Id
      // 
      this.Id.DataPropertyName = "id";
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Visible = false;
      // 
      // idCliente
      // 
      this.idCliente.DataPropertyName = "idCliente";
      this.idCliente.HeaderText = "CUIT";
      this.idCliente.Name = "idCliente";
      this.idCliente.ReadOnly = true;
      // 
      // razonSocialCliente
      // 
      this.razonSocialCliente.DataPropertyName = "razonSocialCliente";
      this.razonSocialCliente.HeaderText = "Razón Social";
      this.razonSocialCliente.Name = "razonSocialCliente";
      this.razonSocialCliente.ReadOnly = true;
      // 
      // apellidoCliente
      // 
      this.apellidoCliente.DataPropertyName = "apellidoCliente";
      this.apellidoCliente.HeaderText = "Apellido";
      this.apellidoCliente.Name = "apellidoCliente";
      this.apellidoCliente.ReadOnly = true;
      // 
      // nombreCliente
      // 
      this.nombreCliente.DataPropertyName = "nombreCliente";
      this.nombreCliente.HeaderText = "Nombre";
      this.nombreCliente.Name = "nombreCliente";
      this.nombreCliente.ReadOnly = true;
      // 
      // direccionCliente
      // 
      this.direccionCliente.DataPropertyName = "direccionCliente";
      this.direccionCliente.HeaderText = "Dirección";
      this.direccionCliente.Name = "direccionCliente";
      this.direccionCliente.ReadOnly = true;
      this.direccionCliente.Visible = false;
      // 
      // telefonoCliente
      // 
      this.telefonoCliente.DataPropertyName = "telefonoCliente";
      this.telefonoCliente.HeaderText = "Teléfono";
      this.telefonoCliente.Name = "telefonoCliente";
      this.telefonoCliente.ReadOnly = true;
      this.telefonoCliente.Visible = false;
      // 
      // emailCliente
      // 
      this.emailCliente.DataPropertyName = "emailCliente";
      this.emailCliente.HeaderText = "E-Mail";
      this.emailCliente.Name = "emailCliente";
      this.emailCliente.ReadOnly = true;
      this.emailCliente.Visible = false;
      // 
      // FullName
      // 
      this.FullName.DataPropertyName = "FullName";
      this.FullName.HeaderText = "FullName";
      this.FullName.Name = "FullName";
      this.FullName.ReadOnly = true;
      this.FullName.Visible = false;
      // 
      // btnVerTodosClientes
      // 
      this.btnVerTodosClientes.Location = new System.Drawing.Point(254, 66);
      this.btnVerTodosClientes.Name = "btnVerTodosClientes";
      this.btnVerTodosClientes.Size = new System.Drawing.Size(137, 25);
      this.btnVerTodosClientes.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnVerTodosClientes.TabIndex = 10;
      this.btnVerTodosClientes.Text = "Ver todos los Clientes";
      this.btnVerTodosClientes.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnVerTodosClientes.UseSelectable = true;
      this.btnVerTodosClientes.UseStyleColors = true;
      this.btnVerTodosClientes.Click += new System.EventHandler(this.btnVerTodosClientes_Click);
      // 
      // ucClientes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnVerTodosClientes);
      this.Controls.Add(this.mgClientes);
      this.Controls.Add(this.textBoxCUIT);
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.btnCrearCliente);
      this.Controls.Add(this.textBoxDato);
      this.Name = "ucClientes";
      this.Size = new System.Drawing.Size(900, 742);
      this.Style = MetroFramework.MetroColorStyle.Blue;
      this.Theme = MetroFramework.MetroThemeStyle.Light;
      this.UseStyleColors = true;
      ((System.ComponentModel.ISupportInitialize)(this.mgClientes)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MetroFramework.Controls.MetroButton btnCrearCliente;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroButton btnBuscar;
    private MetroFramework.Controls.MetroButton btnLimpiar;
    private MetroFramework.Controls.MetroTextBox textBoxDato;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    private MetroFramework.Controls.MetroTextBox textBoxCUIT;
    public MetroFramework.Controls.MetroGrid mgClientes;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn apellidoCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn direccionCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn emailCliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
    private MetroFramework.Controls.MetroButton btnVerTodosClientes;
  }
}
