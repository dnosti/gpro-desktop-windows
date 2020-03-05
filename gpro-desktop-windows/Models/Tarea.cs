using System;

namespace gpro_desktop_windows.Models
{
  class Tarea
  {
    public int ProyectoIdProyecto { get; set; }
    public int IdTarea { get; set; }
    public int PerfilEmpleadoIdPerfil { get; set; }
    public int PerfilEmpleadoIdEmpleado { get; set; }
    public string DescripcionTarea { get; set; }
    public int HorasEstimadasTarea { get; set; }
    public int? HorasOverbudgetTarea { get; set; }
    /*
    public int ProyectoIdProyecto { get; set; }
    public string TituloProyecto { get; set; }
    public int IdTarea { get; set; }
    public int PerfilEmpleadoIdPerfil { get; set; }
    public string DescripcionPerfil { get; set; }
    public int PerfilEmpleadoIdEmpleado { get; set; }
    public string ApellidoEmpleado { get; set; }
    public string NombreEmpleado { get; set; }
    public string DescripcionTarea { get; set; }
    public int HorasEstimadasTarea { get; set; }
    public int? HorasOverbudgetTarea { get; set; }
    */
  }
}
