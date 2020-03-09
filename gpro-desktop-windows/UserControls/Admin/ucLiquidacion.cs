using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gpro_desktop_windows.Models;
using System.Net.Http;
using gpro_desktop_windows.Utils;
using Newtonsoft.Json;
using MetroFramework;
using gpro_desktop_windows.Forms;


namespace gpro_desktop_windows.UsersControls
{
  public partial class ucLiquidacion : MetroFramework.Controls.MetroUserControl
  {
    public ucLiquidacion()
    {
      InitializeComponent();
      mgLiquidacion.Visible = false;

      /* Botón Reporte en DataGrid */
      DataGridViewButtonColumn btnReporte = new DataGridViewButtonColumn();
      btnReporte.Name = "Reporte";
      mgLiquidacion.Columns.Add(btnReporte);
      mgLiquidacion.Columns[18].HeaderText = "";
    }

    private void btnCrearLiquidacion_Click(object sender, EventArgs e)
    {
      CrearLiquidacionForm crearLiquidacionForm = new CrearLiquidacionForm();
      crearLiquidacionForm.ShowDialog();
    }

    private void btnVerTodasLiquidaciones_Click(object sender, EventArgs e)
    {
      getLiquidaciones();
    }

    private void getLiquidaciones()
    {
      List<ReporteLiq> reporteLiquidacion = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getLiquidaciones(client, "/liquidacion/");

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (response.IsSuccessStatusCode)
      {
        mgLiquidacion.Visible = true;
        reporteLiquidacion = JsonConvert.DeserializeObject<List<ReporteLiq>>(stringCR);
        mgLiquidacion.DataSource = reporteLiquidacion;
      }
      else
      {
        MessageBox.Show("No se encontraron liquidaciones.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void mgLiquidacion_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgLiquidacion.Columns[e.ColumnIndex].Name == "Reporte" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonReporte = this.mgLiquidacion.Rows[e.RowIndex].Cells["Reporte"] as DataGridViewButtonCell;
        Icon icoReporte = Properties.Resources.reporte;
        e.Graphics.DrawIcon(icoReporte, e.CellBounds.Left + 4, e.CellBounds.Top + 4);

        this.mgLiquidacion.Rows[e.RowIndex].Height = icoReporte.Height + 8;
        this.mgLiquidacion.Columns[e.ColumnIndex].Width = icoReporte.Width + 8;

        DataGridViewCell cell = this.mgLiquidacion.Rows[e.RowIndex].Cells[e.ColumnIndex];
        cell.ToolTipText = "Generar Reporte";

        e.Handled = true;
      }
    }

      //private void mgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
      //{
      //  if (e.ColumnIndex >= 0 && this.mgLiquidacion.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      //  {
      //    string Id = mgLiquidacion.Rows[e.RowIndex].Cells["Id"].Value.ToString();
      //    EditarClienteForm editarClienteForm = new EditarClienteForm(Id);
      //    DataGridViewRow editarCliente = mgLiquidacion.Rows[e.RowIndex];
      //    editarClienteForm.textBoxidCliente.Text = editarCliente.Cells["idCliente"].Value.ToString();
      //    editarClienteForm.textBoxRSocial.Text = editarCliente.Cells["razonSocialCliente"].Value.ToString();
      //    editarClienteForm.textBoxApellido.Text = editarCliente.Cells["apellidoCliente"].Value.ToString();
      //    editarClienteForm.textBoxNombre.Text = editarCliente.Cells["nombreCliente"].Value.ToString();
      //    editarClienteForm.textBoxDomicilio.Text = editarCliente.Cells["direccionCliente"].Value.ToString();
      //    editarClienteForm.textBoxTelefono.Text = editarCliente.Cells["telefonoCliente"].Value.ToString();
      //    editarClienteForm.textBoxEMail.Text = editarCliente.Cells["emailCliente"].Value.ToString();
      //    editarClienteForm.ShowDialog();
      //    string cuit = editarClienteForm.cuit;
      //    if (!string.IsNullOrEmpty(cuit))
      //      buscarCliente("/cliente/cuit/", cuit, true);
      //  }
      //}
    }
}


