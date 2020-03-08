namespace gpro_desktop_windows.Forms
{
  partial class VerHorasForm
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnCancelar = new MetroFramework.Controls.MetroButton();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.mgHorasTrab = new MetroFramework.Controls.MetroGrid();
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
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mgHorasTrab)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCancelar
      // 
      this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnCancelar.Location = new System.Drawing.Point(562, 271);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(124, 34);
      this.btnCancelar.Style = MetroFramework.MetroColorStyle.Blue;
      this.btnCancelar.TabIndex = 54;
      this.btnCancelar.Text = "Cerrar";
      this.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Light;
      this.btnCancelar.UseSelectable = true;
      this.btnCancelar.UseStyleColors = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
      // 
      // errorProvider1
      // 
      this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider1.ContainerControl = this;
      // 
      // mgHorasTrab
      // 
      this.mgHorasTrab.AllowUserToResizeRows = false;
      this.mgHorasTrab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.mgHorasTrab.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgHorasTrab.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mgHorasTrab.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.mgHorasTrab.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgHorasTrab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.mgHorasTrab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.mgHorasTrab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
      this.mgHorasTrab.DefaultCellStyle = dataGridViewCellStyle2;
      this.mgHorasTrab.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.mgHorasTrab.EnableHeadersVisualStyles = false;
      this.mgHorasTrab.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.mgHorasTrab.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.mgHorasTrab.Location = new System.Drawing.Point(23, 72);
      this.mgHorasTrab.Name = "mgHorasTrab";
      this.mgHorasTrab.ReadOnly = true;
      this.mgHorasTrab.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mgHorasTrab.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.mgHorasTrab.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.mgHorasTrab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mgHorasTrab.Size = new System.Drawing.Size(663, 183);
      this.mgHorasTrab.TabIndex = 55;
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
      // VerHorasForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(716, 332);
      this.Controls.Add(this.mgHorasTrab);
      this.Controls.Add(this.btnCancelar);
      this.MaximizeBox = false;
      this.Name = "VerHorasForm";
      this.Text = "Ver Horas Trabajadas";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mgHorasTrab)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private MetroFramework.Controls.MetroButton btnCancelar;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    public MetroFramework.Controls.MetroGrid mgHorasTrab;
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