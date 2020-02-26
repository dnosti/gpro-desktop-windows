using System;

namespace gpro_desktop_windows.Models
{
  class EmpleadoProyecto
  {
    public int IdEmpleado { get; set; }
    public int IdProyecto { get; set; }

    public string TituloProyecto { get; set; }
    public string DescripcionProyecto { get; set; }
    public string EstadoProyecto { get; set; }
  }
}
