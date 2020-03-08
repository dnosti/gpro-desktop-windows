using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpro_desktop_windows.Models
{
  class HoraTrab
  {
    public int IdHoraTrabajada { get; set; }
    public int PerfilIdPerfil { get; set; }
    public int IdEmpleado { get; set; }
    public int ProyectoIdProyecto { get; set; }
    public int TareaIdTarea { get; set; }
    public int CatidadHorasTrab { get; set; }
    public DateTime FechaHorasTrab { get; set; }
    public string EstadoHorasTrab { get; set; }
  }
}
