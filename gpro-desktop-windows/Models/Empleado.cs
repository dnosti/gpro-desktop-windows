using System;
using System.Collections.Generic;

namespace gpro_desktop_windows.Models
{
  class Empleado
  {
    public int IdEmpleado { get; set; }
    public string ApellidoEmpleado { get; set; }
    public string NombreEmpleado { get; set; }
    public DateTime FechaIngreso { get; set; }
    public string Telefono { get; set; }
    public string Domicilio { get; set; }
    public string Localidad { get; set; }
    public string Provincia { get; set; }
    public int Dni { get; set; }
    public string Nacionalidad { get; set; }

    public string FullName
    {
      get { return ApellidoEmpleado + ", " + NombreEmpleado + " (DNI " + Dni + ")"; }
    }

    public List<EmpleadoProyecto> EmpleadoProyecto { get; set; }
  }
}
