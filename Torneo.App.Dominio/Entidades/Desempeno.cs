using System;
using System.Collections.Generic;
namespace Torneo.App.Dominio
{
    
    /// Modela un Desempeño
    /// </summary>   
    public class Desempeno 
    {
        public int Id {get;set;}
        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }
        public int PartidosEmpatados { get; set; }
        public int PartidosPerdidos { get; set; }
        public int GolesFavor { get; set; }
        public int GolesContra { get; set; }
        public int Puntos { get; set; }
        
      
     
    }
}