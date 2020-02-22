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
  public partial class ucCliente : MetroFramework.Controls.MetroUserControl
  {
    public ucCliente()
    {
      InitializeComponent();
      mgClientes.Visible = false;

      /* Botón Editar en DataGrid */
      DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
      btnEditar.Name = "Editar";
      mgClientes.Columns.Add(btnEditar);
      mgClientes.Columns[8].HeaderText = "";

      /* Botón Ver en DataGrid */
      DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
      btnVer.Name = "Ver";
      mgClientes.Columns.Add(btnVer);
      mgClientes.Columns[9].HeaderText = "";
    }

    private void mgClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgClientes.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonEditar = this.mgClientes.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
        Icon icoEditar = Properties.Resources.editar;
        e.Graphics.DrawIcon(icoEditar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

        this.mgClientes.Rows[e.RowIndex].Height = icoEditar.Height + 8;
        this.mgClientes.Columns[e.ColumnIndex].Width = icoEditar.Width + 8;

        e.Handled = true;
      }

      if (e.ColumnIndex >= 0 && this.mgClientes.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
      {
        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        DataGridViewButtonCell cellButtonVer = this.mgClientes.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
        Icon icoVer = Properties.Resources.ver;
        e.Graphics.DrawIcon(icoVer, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

        this.mgClientes.Rows[e.RowIndex].Height = icoVer.Height + 8;
        this.mgClientes.Columns[e.ColumnIndex].Width = icoVer.Width + 8;

        e.Handled = true;
      }
    }

    private void mgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex >= 0 && this.mgClientes.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
      {
        string Id = mgClientes.Rows[e.RowIndex].Cells["Id"].Value.ToString();
        EditarClienteForm editarClienteForm = new EditarClienteForm(Id);
        DataGridViewRow editarCliente = mgClientes.Rows[e.RowIndex];
        editarClienteForm.textBoxidCliente.Text = editarCliente.Cells["idCliente"].Value.ToString();
        editarClienteForm.textBoxRSocial.Text = editarCliente.Cells["razonSocialCliente"].Value.ToString();
        editarClienteForm.textBoxApellido.Text = editarCliente.Cells["apellidoCliente"].Value.ToString();
        editarClienteForm.textBoxNombre.Text = editarCliente.Cells["nombreCliente"].Value.ToString();
        editarClienteForm.textBoxDomicilio.Text = editarCliente.Cells["direccionCliente"].Value.ToString();
        editarClienteForm.textBoxTelefono.Text = editarCliente.Cells["telefonoCliente"].Value.ToString();
        editarClienteForm.textBoxEMail.Text = editarCliente.Cells["emailCliente"].Value.ToString();
        editarClienteForm.ShowDialog();
        string cuit = editarClienteForm.cuit;
        if (!string.IsNullOrEmpty(cuit))
          buscarCliente("/cliente/cuit/", cuit, true);
      }
      if (e.ColumnIndex >= 0 && this.mgClientes.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
      {
        VerClienteForm verClienteForm = new VerClienteForm();
        DataGridViewRow verCliente = mgClientes.Rows[e.RowIndex];
        verClienteForm.textBoxidCliente.Text = verCliente.Cells["idCliente"].Value.ToString();
        verClienteForm.textBoxRSocial.Text = verCliente.Cells["razonSocialCliente"].Value.ToString();
        verClienteForm.textBoxApellido.Text = verCliente.Cells["apellidoCliente"].Value.ToString();
        verClienteForm.textBoxNombre.Text = verCliente.Cells["nombreCliente"].Value.ToString();
        verClienteForm.textBoxDomicilio.Text = verCliente.Cells["direccionCliente"].Value.ToString();
        verClienteForm.textBoxTelefono.Text = verCliente.Cells["telefonoCliente"].Value.ToString();
        verClienteForm.textBoxEMail.Text = verCliente.Cells["emailCliente"].Value.ToString();
        verClienteForm.Show();
      }
    }

    private void btnCrearCliente_Click(object sender, EventArgs e)
    {
      CrearClienteForm crearClienteForm = new CrearClienteForm();
      crearClienteForm.ShowDialog();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      textBoxDato.Clear();
      textBoxCUIT.Clear();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      string path = "";
      string payload = "";
      bool getbycuit = false;

      if (string.IsNullOrEmpty(textBoxDato.Text) && string.IsNullOrEmpty(textBoxCUIT.Text))
      {
        MessageBox.Show(this,"Complete el formulario para realizar la búsqueda.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (string.IsNullOrEmpty(textBoxCUIT.Text))
      {
        path = "/cliente/dato/";
        payload = textBoxDato.Text;
        buscarCliente(path, payload, getbycuit);
      }
      else
      {
        path = "/cliente/cuit/";
        payload = textBoxCUIT.Text;
        if (!payload.All(char.IsDigit))
        {
          MessageBox.Show("En CUIT solo ingrese números.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }
        getbycuit = true;
        buscarCliente(path, payload, getbycuit);
      }
    }

    private void buscarCliente(string path, string payload, bool getbycuit)
    {
      Cliente clienteResponse = null;
      List<Cliente> clienteResponses = null;

      HttpClient client = HttpUtils.configHttpClient();
      HttpResponseMessage response = HttpUtils.getCliente(client, path, payload);

      string stringCR = response.Content.ReadAsStringAsync().Result;

      if (getbycuit)
      {
        clienteResponse = JsonConvert.DeserializeObject<Cliente>(stringCR);
        clienteResponses = new List<Cliente>();
        clienteResponses.Add(clienteResponse);
      }
      else
      {
        clienteResponses = JsonConvert.DeserializeObject<List<Cliente>>(stringCR);
      }

      if (response.IsSuccessStatusCode)
      {
        mgClientes.Visible = true;
        if (getbycuit) { mgClientes.DataSource = clienteResponses; }
        else { mgClientes.DataSource = clienteResponses; }
      }
      else
      {
        MessageBox.Show("No se encontró el cliente.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textBoxDato.Clear(); textBoxCUIT.Clear();
      }
    }
  }
}
