using System;

namespace gpro_desktop_windows.Models
{
  class ReporteLiq
  {
    public int Id { get; set; }
    public int IdEmpleado { get; set; }
    public string FullName
    {
      get { return ApellidoEmpleado + ", " + NombreEmpleado; }
    }
    public string ApellidoEmpleado { get; set; }
    public string NombreEmpleado { get; set; }
    public DateTime FechaDesde { get; set; }
    public DateTime FechaHasta { get; set; }
    public int CantHorasTrab { get; set; }
    public float Importe { get; set; }
    public int IdEscalaHoras { get; set; }
    public float PorcentajeHoras { get; set; }
    public int HorasOverBudget { get; set; }
    public int IdEscalaPerfiles { get; set; }
    public int CantPerfiles { get; set; }
    public float PorcentajePerfil { get; set; }
    public int CantAnios { get; set; }
    public int IdEscalaAntiguedad { get; set; }
    public float Porcentaje { get; set; }
  }
}
