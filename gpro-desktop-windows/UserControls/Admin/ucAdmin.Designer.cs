namespace gpro_desktop_windows.UsersControls
{
  partial class ucAdmin
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
      this.mtClientes = new MetroFramework.Controls.MetroTile();
      this.mtEmpleados = new MetroFramework.Controls.MetroTile();
      this.mtUsuarios = new MetroFramework.Controls.MetroTile();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.mtLiquidacion = new MetroFramework.Controls.MetroTile();
      this.SuspendLayout();
      // 
      // mtClientes
      // 
      this.mtClientes.ActiveControl = null;
      this.mtClientes.Cursor = System.Windows.Forms.Cursors.Hand;
      this.mtClientes.Location = new System.Drawing.Point(100, 66);
      this.mtClientes.Name = "mtClientes";
      this.mtClientes.Size = new System.Drawing.Size(456, 119);
      this.mtClientes.TabIndex = 0;
      this.mtClientes.Text = "Clientes";
      this.mtClientes.UseSelectable = true;
      this.mtClientes.Click += new System.EventHandler(this.mtClientes_Click);
      // 
      // mtEmpleados
      // 
      this.mtEmpleados.ActiveControl = null;
      this.mtEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
      this.mtEmpleados.Location = new System.Drawing.Point(100, 205);
      this.mtEmpleados.Name = "mtEmpleados";
      this.mtEmpleados.Size = new System.Drawing.Size(456, 119);
      this.mtEmpleados.TabIndex = 0;
      this.mtEmpleados.Text = "Empleados";
      this.mtEmpleados.UseSelectable = true;
      this.mtEmpleados.Click += new System.EventHandler(this.mtEmpleados_Click);
      // 
      // mtUsuarios
      // 
      this.mtUsuarios.ActiveControl = null;
      this.mtUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
      this.mtUsuarios.Location = new System.Drawing.Point(100, 344);
      this.mtUsuarios.Name = "mtUsuarios";
      this.mtUsuarios.Size = new System.Drawing.Size(456, 119);
      this.mtUsuarios.TabIndex = 0;
      this.mtUsuarios.Text = "Usuarios";
      this.mtUsuarios.UseSelectable = true;
      this.mtUsuarios.Click += new System.EventHandler(this.mtUsuarios_Click);
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
      this.metroPanel1.TabIndex = 7;
      this.metroPanel1.UseCustomBackColor = true;
      this.metroPanel1.VerticalScrollbarBarColor = true;
      this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanel1.VerticalScrollbarSize = 10;
      // 
      // mtLiquidacion
      // 
      this.mtLiquidacion.ActiveControl = null;
      this.mtLiquidacion.Cursor = System.Windows.Forms.Cursors.Hand;
      this.mtLiquidacion.Location = new System.Drawing.Point(100, 484);
      this.mtLiquidacion.Name = "mtLiquidacion";
      this.mtLiquidacion.Size = new System.Drawing.Size(456, 75);
      this.mtLiquidacion.TabIndex = 8;
      this.mtLiquidacion.Text = "Liquidación";
      this.mtLiquidacion.UseSelectable = true;
      this.mtLiquidacion.Click += new System.EventHandler(this.mtLiquidacion_Click);
      // 
      // ucAdmin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.mtLiquidacion);
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.mtUsuarios);
      this.Controls.Add(this.mtEmpleados);
      this.Controls.Add(this.mtClientes);
      this.Name = "ucAdmin";
      this.Size = new System.Drawing.Size(900, 742);
      this.ResumeLayout(false);

    }

    #endregion

    private MetroFramework.Controls.MetroTile mtClientes;
    private MetroFramework.Controls.MetroTile mtEmpleados;
    private MetroFramework.Controls.MetroTile mtUsuarios;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    private MetroFramework.Controls.MetroTile mtLiquidacion;
  }
}
