using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gpro_desktop_windows.Forms;
using gpro_desktop_windows.Models;
using System.Net.Http;
using gpro_desktop_windows.Utils;
using Newtonsoft.Json;
using MetroFramework;

namespace gpro_desktop_windows.UsersControls
{
  public partial class ucCliente : MetroFramework.Controls.MetroUserControl
  {
    public ucCliente()
    {
      InitializeComponent();
      mgClientes.Visible = false;
    }

    private void btnCrearCliente_Click(object sender, EventArgs e)
    {
      CrearClienteForm crearClienteForm = new CrearClienteForm();
      crearClienteForm.Show();
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
      Cliente clienteResponse = null;
      List<Cliente> clienteResponses = null;

      if (string.IsNullOrEmpty(textBoxDato.Text) && string.IsNullOrEmpty(textBoxCUIT.Text))
      {
        MetroMessageBox.Show(this,"Complete el formulario para realizar la búsqueda.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (string.IsNullOrEmpty(textBoxCUIT.Text))
      {
        path = "/cliente/dato/";
        payload = textBoxDato.Text;
      }
      else
      {
        path = "/cliente/cuit/";
        payload = textBoxCUIT.Text;
        if (!payload.All(char.IsDigit))
        {
          MetroMessageBox.Show(this,"En CUIT solo ingrese números.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }
        getbycuit = true;
      }

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
        mgClientes.Columns.Remove("Id");
      }
      else
      {
        MetroMessageBox.Show(this,"No se encontró el cliente.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textBoxDato.Clear(); textBoxCUIT.Clear();
      }
    }
  }
}
