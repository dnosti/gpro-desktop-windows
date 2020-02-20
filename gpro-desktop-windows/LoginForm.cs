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
      string baseUrl = "http://localhost:60932";
      HttpClient client = new HttpClient();
      client.BaseAddress = new Uri(baseUrl);
      var contentType = new MediaTypeWithQualityHeaderValue("application/json");
      client.DefaultRequestHeaders.Accept.Add(contentType);

      UserRequest user = new UserRequest();
      user.Username = textBoxUser.Text;
      user.Password = textBoxPass.Text;

      string stringData = JsonConvert.SerializeObject(user);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PostAsync("/usuarios/authenticate", contentData).Result;

      string stringUR = response.Content.ReadAsStringAsync().Result;
      UserResponse userResponse = JsonConvert.DeserializeObject<UserResponse>(stringUR);

      if (response.IsSuccessStatusCode)
      {
        Settings.Default.Token = userResponse.Token;
        Settings.Default.Username = userResponse.Username;
        Settings.Default.Role = userResponse.Rol;

        LoginForm.ActiveForm.Hide();

        MainForm mainForm = new MainForm();
        mainForm.Show();
      }
      else
      {
        MetroMessageBox.Show(this,"Usuario o contraseña incorrectos.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        textBoxUser.Clear();
        textBoxPass.Clear();
      }
    }
  }
}
