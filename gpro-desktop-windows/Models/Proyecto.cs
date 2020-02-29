using System;

namespace gpro_desktop_windows.Models
{
  class Proyecto
  {
    public int IdProyecto { get; set; }
    public int ClienteId { get; set; }
    public string TituloProyecto { get; set; }
    public string DescripcionProyecto { get; set; }
    public string EstadoProyecto { get; set; }

    public string NombreCliente { get; set; }
    public string ApellidoCliente { get; set; }

    //public string EstadoProyecto1 { get; set; }
  }
}
