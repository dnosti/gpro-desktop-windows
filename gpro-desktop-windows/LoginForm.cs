using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gpro_desktop_windows.Models;
using gpro_desktop_windows.Properties;
using gpro_desktop_windows.Utils;
using MetroFramework;
using Newtonsoft.Json;

namespace gpro_desktop_windows
{
  public partial class LoginForm : MetroFramework.Forms.MetroForm
  {
    public LoginForm()
    {
      InitializeComponent();
      textBoxUser.Focus();
    }

    private void btnIniciar_Click(object sender, EventArgs e)
    {
      UserRequest user = new UserRequest();
      user.Username = textBoxUser.Text;
      user.Password = textBoxPass.Text;

      string stringData = JsonConvert.SerializeObject(user);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");
      try
      {
        HttpResponseMessage response = Settings.Default.Client.PostAsync("/usuarios/authenticate", contentData).Result;

        string stringUR = response.Content.ReadAsStringAsync().Result;
        UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(stringUR);

        if (response.IsSuccessStatusCode)
        {
          Settings.Default.Token = userResponse.Token;
          Settings.Default.Username = userResponse.Username;
          Settings.Default.Role = userResponse.Rol;
          Settings.Default.IdEmpleado = userResponse.IdEmpleado;
          Settings.Default.Client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Settings.Default.Token);
          var contentType = new MediaTypeWithQualityHeaderValue("application/json");
          Settings.Default.Client.DefaultRequestHeaders.Accept.Add(contentType);

          LoginForm.ActiveForm.Hide();

          MainForm mainForm = new MainForm();
          mainForm.Show();
        }
        else
        {
          MetroMessageBox.Show(this, "Usuario o contraseña incorrectos.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
          textBoxUser.Clear();
          textBoxPass.Clear();
        }
      }
      catch (Exception)
      {
        MetroMessageBox.Show(this, "Sin conexión.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textBoxUser.Clear();
        textBoxPass.Clear();
      }
    }

    private void lfclosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
      Settings.Default.Client = new HttpClient();
      string baseUrl = "http://localhost:60932";
      Settings.Default.Client.BaseAddress = new Uri(baseUrl);
    }
  }
}
