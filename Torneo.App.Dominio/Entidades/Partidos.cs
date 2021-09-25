using System;
using System.Collections.Generic;
namespace Torneo.App.Dominio
{
    
    /// Modela un novedad
    /// </summary>   
    public class Partidos
    {
        public int Id {get;set;}
        public DateTime FechaHora  { get; set; }
        public Equipo EquipoLocal { get; set; }
        public int MarcadorLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public int MarcadorVisitante  { get; set; }
        public Estadio Estadio { get; set; }
        public Arbitro Arbitro { get; set; }
           }
}

        
      