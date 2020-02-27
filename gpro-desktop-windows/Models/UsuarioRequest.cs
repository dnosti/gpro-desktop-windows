using System;

namespace gpro_desktop_windows.Models
{
  class UsuarioRequest
  {
    public int Id { get; set; }
    public string Username { get; set; }
    public int IdEmpleado { get; set; }
    public int IdRol { get; set; }
    public string Password { get; set; }
  }
}
