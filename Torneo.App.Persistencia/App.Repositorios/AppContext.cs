using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Arbitro> Arbitros { get; set; }
        public DbSet<DirectorTecnico> DirectoresTecnico { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Estadio> Estadios { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Partidos> Partidoss { get; set; }
        public DbSet<Desempeno> Desempenos { get; set; }
        public DbSet<NovedadPartido> Novedades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TorneoData");
            }
        }

    }
}