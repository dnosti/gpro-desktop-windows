using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpro_desktop_windows.Models
{
    public class HoraTrabajada
    {
      public int IdProy { get; set; }
      public int TotalHorasProy { get; set; }
      public List<SumaPerfiles> SumaPorPerfil { get; set; }

    }
    public class SumaPerfiles
    {
      public int IdPerfil { get; set; }
      public int HorasPerfil { get; set; }
      public int HorasTotales { get; set; }
      public int HorasEstimadas { get; set; }
      public DateTime FechaHorasTrab { get; set; }
      public string DescripcionPerfil { get; set; }
      public float ValorHora { get; set; }
      public string Nombre { get; set; }
      public string Apellido { get; set; }

      public string FullName
      {
        get { return Apellido + ", " + Nombre; }
      }


  }
    public class HtrabPorRecDto
    {
      public int TotalHorasRec { get; set; }
      public List<SumaPerfiles> PorPerfil { get; set; }
      public List<HoraTrabajada> PorProyecto { get; set; }
    }
}
