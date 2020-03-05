using System;

namespace gpro_desktop_windows.Models
{
  class ProyectoRequest
  {
    public int IdProyecto { get; set; }
    public int ClienteId { get; set; }
    public string TituloProyecto { get; set; }
    public string DescripcionProyecto { get; set; }
    public string EstadoProyecto { get; set; }
    public int IdEmpleadoPm { get; set; }
  }
}
