namespace gpro_desktop_windows.Forms
{
  partial class HorasTrabajadasForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnCerrar = new MetroFramework.Controls.MetroButton();
      this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
      this.metroTabPagePerfil = new MetroFramework.Controls.MetroTabPage();
      this.mgPorPerfil = new MetroFramework.Controls.MetroGrid();
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
      this.metroTabPagePerfilDetalle = new System.Windows.Forms.TabPage();
      this.mgDetalle = new MetroFramework.Controls.MetroGrid();
      this.DescrPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HorasRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ValorH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EstadoH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tbHorasAdeudadas = new MetroFramework.Controls.MetroTextBox();
      this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
      this.metroTabPagePeriodo = new MetroFramework.Controls.MetroTabPage();
      this.btnBuscar = new MetroFramework.Controls.MetroButton();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.fechaFin = new MetroFramework.Controls.MetroDateTime();
      this.ComboBoxPerfiles = new MetroFramework.Controls.MetroComboBox();
      this.fechaInicio = new MetroFramework.Controls.MetroDateTime();
      this.metroTabControl.SuspendLayout();
      this.metroTabPagePerfil.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.mgPorPerfil)).BeginInit();
      this.metroTabPagePerfilDetalle.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.mgDetalle)).BeginInit();
      this.metroTabPagePeriodo.SuspendLayout();
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
      // metroTabControl
      // 
      this.metroTabControl.Controls.Add(this.metroTabPagePerfil);
      this.metroTabControl.Controls.Add(this.metroTabPagePerfilDetalle);
      this.metroTabControl.Controls.Add(this.metroTabPagePeriodo);
      this.metroTabControl.Location = new System.Drawing.Point(22, 67);
      this.metroTabControl.Name = "metroTabControl";
      this.metroTabControl.SelectedIndex = 1;
      this.metroTabControl.Size = new System.Drawing.Size(745, 242);
      this.metroTabControl.TabIndex = 50;
      this.metroTabControl.UseSelectable = true;
      // 
      // metroTabPagePerfil
      // 
      this.metroTabPagePerfil.Controls.Add(this.mgPorPerfil);
      this.metroTabPagePerfil.HorizontalScrollbarBarColor = true;
      this.metroTabPagePerfil.HorizontalScrollbarHighlightOnWheel = false;
      this.metroTabPagePerfil.HorizontalScrollbarSize = 10;
      this.metroTabPagePerfil.Location = new System.Drawing.Point(4, 38);
      this.metroTabPagePerfil.Name = "metroTabPagePerfil";
      this.metroTabPagePerfil.Size = new System.Drawing.Size(737, 200);
      this.metroTabPagePerfil.TabIndex = 0;
      this.metroTabPagePerfil.Text = "Por Perfil";
      this.metroTabPagePerfil.VerticalScrollbarBarColor = true;
      this.metroTabPagePerfil.VerticalScrollbarHighlightOnWheel = false;
      this.metroTabPagePerfil.VerticalScrollbarSize = 10;
      // 
      // mgPorPerfil
      // 
      this.mgPorPerfil.AllowUserToResizeRows = false;
      this.mgPorPerfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.mgPorPerfil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgPorPerfil.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mgPorPerfil.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.mgPorPerfil.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgPorPerfil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.mgPorPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgPorPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
      this.mgPorPerfil.DefaultCellStyle = dataGridViewCellStyle2;
      this.mgPorPerfil.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgPorPerfil.EnableHeadersVisualStyles = false;
      this.mgPorPerfil.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgPorPerfil.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgPorPerfil.Location = new System.Drawing.Point(0, 17);
      this.mgPorPerfil.Name = "mgPorPerfil";
      this.mgPorPerfil.ReadOnly = true;
      this.mgPorPerfil.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgPorPerfil.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.mgPorPerfil.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgPorPerfil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgPorPerfil.Size = new System.Drawing.Size(737, 196);
      this.mgPorPerfil.TabIndex = 51;
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
      this.HorasPerfil.HeaderText = "Horas Trabajadas";
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
      // metroTabPagePerfilDetalle
      // 
      this.metroTabPagePerfilDetalle.BackColor = System.Drawing.SystemColors.Window;
      this.metroTabPagePerfilDetalle.Controls.Add(this.mgDetalle);
      this.metroTabPagePerfilDetalle.Controls.Add(this.tbHorasAdeudadas);
      this.metroTabPagePerfilDetalle.Controls.Add(this.metroLabel4);
      this.metroTabPagePerfilDetalle.Location = new System.Drawing.Point(4, 38);
      this.metroTabPagePerfilDetalle.Name = "metroTabPagePerfilDetalle";
      this.metroTabPagePerfilDetalle.Size = new System.Drawing.Size(737, 200);
      this.metroTabPagePerfilDetalle.TabIndex = 2;
      this.metroTabPagePerfilDetalle.Text = "Por Perfil (Detalle)";
      // 
      // mgDetalle
      // 
      this.mgDetalle.AllowUserToResizeRows = false;
      this.mgDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.mgDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mgDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.mgDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.mgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescrPerfil,
            this.IdPer,
            this.HorasEst,
            this.HorasTot,
            this.HorasRes,
            this.ValorH,
            this.EstadoH});
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.mgDetalle.DefaultCellStyle = dataGridViewCellStyle5;
      this.mgDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgDetalle.EnableHeadersVisualStyles = false;
      this.mgDetalle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgDetalle.Location = new System.Drawing.Point(0, 45);
      this.mgDetalle.Name = "mgDetalle";
      this.mgDetalle.ReadOnly = true;
      this.mgDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
      this.mgDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgDetalle.Size = new System.Drawing.Size(737, 153);
      this.mgDetalle.TabIndex = 52;
      // 
      // DescrPerfil
      // 
      this.DescrPerfil.DataPropertyName = "DescripcionPerfil";
      this.DescrPerfil.HeaderText = "Perfil";
      this.DescrPerfil.Name = "DescrPerfil";
      this.DescrPerfil.ReadOnly = true;
      // 
      // IdPer
      // 
      this.IdPer.DataPropertyName = "IdPerfil";
      this.IdPer.HeaderText = "Id";
      this.IdPer.Name = "IdPer";
      this.IdPer.ReadOnly = true;
      this.IdPer.Visible = false;
      // 
      // HorasEst
      // 
      this.HorasEst.DataPropertyName = "HorasEstimadas";
      this.HorasEst.HeaderText = "Horas Estimadas";
      this.HorasEst.Name = "HorasEst";
      this.HorasEst.ReadOnly = true;
      // 
      // HorasTot
      // 
      this.HorasTot.DataPropertyName = "HorasTotales";
      this.HorasTot.HeaderText = "Horas Totales";
      this.HorasTot.Name = "HorasTot";
      this.HorasTot.ReadOnly = true;
      // 
      // HorasRes
      // 
      this.HorasRes.DataPropertyName = "HorasRestantes";
      this.HorasRes.HeaderText = "Horas Restantes";
      this.HorasRes.Name = "HorasRes";
      this.HorasRes.ReadOnly = true;
      // 
      // ValorH
      // 
      this.ValorH.DataPropertyName = "ValorHora";
      this.ValorH.HeaderText = "Valor Hora";
      this.ValorH.Name = "ValorH";
      this.ValorH.ReadOnly = true;
      // 
      // EstadoH
      // 
      this.EstadoH.DataPropertyName = "EstadoHorasTrab";
      this.EstadoH.HeaderText = "Estado";
      this.EstadoH.Name = "EstadoH";
      this.EstadoH.ReadOnly = true;
      this.EstadoH.Visible = false;
      // 
      // tbHorasAdeudadas
      // 
      // 
      // 
      // 
      this.tbHorasAdeudadas.CustomButton.Image = null;
      this.tbHorasAdeudadas.CustomButton.Location = new System.Drawing.Point(34, 1);
      this.tbHorasAdeudadas.CustomButton.Name = "";
      this.tbHorasAdeudadas.CustomButton.Size = new System.Drawing.Size(23, 23);
      this.tbHorasAdeudadas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
      this.tbHorasAdeudadas.CustomButton.TabIndex = 1;
      this.tbHorasAdeudadas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
      this.tbHorasAdeudadas.CustomButton.UseSelectable = true;
      this.tbHorasAdeudadas.CustomButton.Visible = false;
      this.tbHorasAdeudadas.Enabled = false;
      this.tbHorasAdeudadas.Lines = new string[0];
      this.tbHorasAdeudadas.Location = new System.Drawing.Point(669, 11);
      this.tbHorasAdeudadas.MaxLength = 32767;
      this.tbHorasAdeudadas.Name = "tbHorasAdeudadas";
      this.tbHorasAdeudadas.PasswordChar = '\0';
      this.tbHorasAdeudadas.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.tbHorasAdeudadas.SelectedText = "";
      this.tbHorasAdeudadas.SelectionLength = 0;
      this.tbHorasAdeudadas.SelectionStart = 0;
      this.tbHorasAdeudadas.ShortcutsEnabled = true;
      this.tbHorasAdeudadas.Size = new System.Drawing.Size(58, 25);
      this.tbHorasAdeudadas.TabIndex = 1;
      this.tbHorasAdeudadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.tbHorasAdeudadas.UseSelectable = true;
      this.tbHorasAdeudadas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
      this.tbHorasAdeudadas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
      // 
      // metroLabel4
      // 
      this.metroLabel4.AutoSize = true;
      this.metroLabel4.Location = new System.Drawing.Point(517, 13);
      this.metroLabel4.Name = "metroLabel4";
      this.metroLabel4.Size = new System.Drawing.Size(147, 19);
      this.metroLabel4.TabIndex = 0;
      this.metroLabel4.Text = "Total Horas Adeudadas:";
      // 
      // metroTabPagePeriodo
      // 
      this.metroTabPagePeriodo.Controls.Add(this.btnBuscar);
      this.metroTabPagePeriodo.Controls.Add(this.metroLabel3);
      this.metroTabPagePeriodo.Controls.Add(this.metroLabel2);
      this.metroTabPagePeriodo.Controls.Add(this.metroLabel1);
      this.metroTabPagePeriodo.Controls.Add(this.fechaFin);
      this.metroTabPagePeriodo.Controls.Add(this.ComboBoxPerfiles);
      this.metroTabPagePeriodo.Controls.Add(this.fechaInicio);
      this.metroTabPagePeriodo.HorizontalScrollbarBarColor = true;
      this.metroTabPagePeriodo.HorizontalScrollbarHighlightOnWheel = false;
      this.metroTabPagePeriodo.HorizontalScrollbarSize = 10;
      this.metroTabPagePeriodo.Location = new System.Drawing.Point(4, 38);
      this.metroTabPagePeriodo.Name = "metroTabPagePeriodo";
      this.metroTabPagePeriodo.Size = new System.Drawing.Size(737, 200);
      this.metroTabPagePeriodo.TabIndex = 1;
      this.metroTabPagePeriodo.Text = "Por Período";
      this.metroTabPagePeriodo.VerticalScrollbarBarColor = true;
      this.metroTabPagePeriodo.VerticalScrollbarHighlightOnWheel = false;
      this.metroTabPagePeriodo.VerticalScrollbarSize = 10;
      // 
      // btnBuscar
      // 
      this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnBuscar.Location = new System.Drawing.Point(613, 77);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(124, 24);
      this.btnBuscar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnBuscar.TabIndex = 51;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnBuscar.UseSelectable = true;
      this.btnBuscar.UseStyleColors = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.Location = new System.Drawing.Point(503, 11);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(67, 19);
      this.metroLabel3.TabIndex = 62;
      this.metroLabel3.Text = "Fecha Fin:";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(235, 11);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(80, 19);
      this.metroLabel2.TabIndex = 61;
      this.metroLabel2.Text = "Fecha Inicio:";
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(0, 11);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(41, 19);
      this.metroLabel1.TabIndex = 60;
      this.metroLabel1.Text = "Perfil:";
      // 
      // fechaFin
      // 
      this.fechaFin.Location = new System.Drawing.Point(503, 36);
      this.fechaFin.MinimumSize = new System.Drawing.Size(4, 29);
      this.fechaFin.Name = "fechaFin";
      this.fechaFin.Size = new System.Drawing.Size(234, 29);
      this.fechaFin.TabIndex = 59;
      // 
      // ComboBoxPerfiles
      // 
      this.ComboBoxPerfiles.FormattingEnabled = true;
      this.ComboBoxPerfiles.ItemHeight = 23;
      this.ComboBoxPerfiles.Location = new System.Drawing.Point(0, 36);
      this.ComboBoxPerfiles.Name = "ComboBoxPerfiles";
      this.ComboBoxPerfiles.Size = new System.Drawing.Size(201, 29);
      this.ComboBoxPerfiles.TabIndex = 58;
      this.ComboBoxPerfiles.UseSelectable = true;
      // 
      // fechaInicio
      // 
      this.fechaInicio.Location = new System.Drawing.Point(235, 36);
      this.fechaInicio.MinimumSize = new System.Drawing.Size(4, 29);
      this.fechaInicio.Name = "fechaInicio";
      this.fechaInicio.Size = new System.Drawing.Size(234, 29);
      this.fechaInicio.TabIndex = 57;
      // 
      // HorasTrabajadasForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(790, 368);
      this.Controls.Add(this.metroTabControl);
      this.Controls.Add(this.btnCerrar);
      this.MaximizeBox = false;
      this.Name = "HorasTrabajadasForm";
      this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
      this.Text = "Horas Trabajadas";
      this.Load += new System.EventHandler(this.HorasTrabajadasForm_Load);
      this.metroTabControl.ResumeLayout(false);
      this.metroTabPagePerfil.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.mgPorPerfil)).EndInit();
      this.metroTabPagePerfilDetalle.ResumeLayout(false);
      this.metroTabPagePerfilDetalle.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.mgDetalle)).EndInit();
      this.metroTabPagePeriodo.ResumeLayout(false);
      this.metroTabPagePeriodo.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private MetroFramework.Controls.MetroButton btnCerrar;
    private MetroFramework.Controls.MetroTabControl metroTabControl;
    private MetroFramework.Controls.MetroTabPage metroTabPagePerfil;
    private MetroFramework.Controls.MetroTabPage metroTabPagePeriodo;
    public MetroFramework.Controls.MetroGrid mgPorPerfil;
    private MetroFramework.Controls.MetroDateTime fechaInicio;
    private MetroFramework.Controls.MetroDateTime fechaFin;
    public MetroFramework.Controls.MetroComboBox ComboBoxPerfiles;
    private MetroFramework.Controls.MetroButton btnBuscar;
    private MetroFramework.Controls.MetroLabel metroLabel3;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private System.Windows.Forms.TabPage metroTabPagePerfilDetalle;
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
    private MetroFramework.Controls.MetroLabel metroLabel4;
    private MetroFramework.Controls.MetroTextBox tbHorasAdeudadas;
    public MetroFramework.Controls.MetroGrid mgDetalle;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescrPerfil;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdPer;
    private System.Windows.Forms.DataGridViewTextBoxColumn HorasEst;
    private System.Windows.Forms.DataGridViewTextBoxColumn HorasTot;
    private System.Windows.Forms.DataGridViewTextBoxColumn HorasRes;
    private System.Windows.Forms.DataGridViewTextBoxColumn ValorH;
    private System.Windows.Forms.DataGridViewTextBoxColumn EstadoH;
  }
}