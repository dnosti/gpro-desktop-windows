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
  }
}
