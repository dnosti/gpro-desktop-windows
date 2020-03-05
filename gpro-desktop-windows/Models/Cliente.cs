using System;

namespace gpro_desktop_windows.Models
{
  class Cliente
  {
    public int Id { get; set; }
    public Int64 IdCliente { get; set; }
    public string RazonSocialCliente { get; set; }
    public string ApellidoCliente { get; set; }
    public string NombreCliente { get; set; }
    public string DireccionCliente { get; set; }
    public string TelefonoCliente { get; set; }
    public string EmailCliente { get; set; }

    public string FullName
    {
      get { return "(" + RazonSocialCliente +") " + ApellidoCliente + ", " + NombreCliente + " (CUIT " + IdCliente + ")"; }
    }
  }
}
