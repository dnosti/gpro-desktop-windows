using gpro_desktop_windows.Models;
using gpro_desktop_windows.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace gpro_desktop_windows.Utils
{
  class HttpUtils
  {
    public static HttpClient configHttpClient()
    {
      string baseUrl = "http://localhost:60932";
      HttpClient client = new HttpClient();
      client.BaseAddress = new Uri(baseUrl);
      var contentType = new MediaTypeWithQualityHeaderValue("application/json");
      client.DefaultRequestHeaders.Accept.Add(contentType);
      client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Settings.Default.Token);

      return client;
    }


    /* Clientes */

    public static HttpResponseMessage getCliente(HttpClient client, string path, string payload)
    {
      HttpResponseMessage response = client.GetAsync(path + payload).Result;
      return response;
    }

    public static HttpResponseMessage postCliente(HttpClient client, Cliente payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PostAsync("/cliente/new/", contentData).Result;

      return response;
    }

    public static HttpResponseMessage putCliente(HttpClient client, Cliente payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PutAsync("/cliente/update/", contentData).Result;

      return response;
    }


    /* Empleados */

    public static HttpResponseMessage getEmpleado(HttpClient client, string path, string payload)
    {
      HttpResponseMessage response = client.GetAsync(path + payload).Result;
      return response;
    }

    public static HttpResponseMessage getEmpleados(HttpClient client, string path)
    {
      HttpResponseMessage response = client.GetAsync(path).Result;
      return response;
    }

    public static HttpResponseMessage postEmpleado(HttpClient client, Empleado payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PostAsync("/empleado/new/", contentData).Result;

      return response;
    }

    public static HttpResponseMessage putEmpleado(HttpClient client, Empleado payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PutAsync("/empleado/update/", contentData).Result;

      return response;
    }


    /* Usuarios */

    public static HttpResponseMessage getUsuario(HttpClient client, string path, string payload)
    {
      HttpResponseMessage response = client.GetAsync(path + payload).Result;
      return response;
    }

    public static HttpResponseMessage postUsuario(HttpClient client, UsuarioRequest payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PostAsync("/usuarios/register/", contentData).Result;

      return response;
    }

    public static HttpResponseMessage deleteUsuario(HttpClient client, string path, int payload)
    {
      HttpResponseMessage response = client.DeleteAsync(path + payload).Result;
      return response;
    }

    public static HttpResponseMessage putUsuario(HttpClient client, int id, UsuarioRequest payload)
    {
      string stringData = JsonConvert.SerializeObject(payload);
      var contentData = new StringContent(stringData, Encoding.UTF8, "application/json");

      HttpResponseMessage response = client.PutAsync("/usuarios/" + id, contentData).Result;

      return response;
    }


    /* Roles */

    public static HttpResponseMessage getRoles(HttpClient client, string path)
    {
      HttpResponseMessage response = client.GetAsync(path).Result;
      return response;
    }
  }
}
