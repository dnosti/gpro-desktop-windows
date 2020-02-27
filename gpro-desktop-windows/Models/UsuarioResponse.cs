using System;

namespace gpro_desktop_windows.Models
{
  class UsuarioResponse
  {
    public int Id { get; set; }
    public string Username { get; set; }
    public int IdEmpleado { get; set; }
    public int IdRol { get; set; }
    public string ApellidoEmpleado { get; set; }
    public string NombreEmpleado { get; set; }
    public int Dni { get; set; }
  }
}
