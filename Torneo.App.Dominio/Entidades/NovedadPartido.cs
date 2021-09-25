using System;
using System.Collections.Generic;
namespace Torneo.App.Dominio
{
    
    /// Modela un novedad
    /// </summary>   
    public class NovedadPartido 
    {
        public int Id { get; set; }
        public string Novedad {get;set;}
        public int JugadorInvolucrado { get; set; }
        public int TarjetasAmarilla { get; set; }
        public int TarjetasRojas { get; set; }
        public int Goles { get; set; }
        public DateTime FechaHora  { get; set; }
        
      
     
    }
}