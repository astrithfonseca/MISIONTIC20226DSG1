// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Torneo.App.Persistencia;

namespace Torneo.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210924213238_Entidades")]
    partial class Entidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Torneo.App.Dominio.Desempeno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GolesContra")
                        .HasColumnType("int");

                    b.Property<int>("GolesFavor")
                        .HasColumnType("int");

                    b.Property<int>("PartidosEmpatados")
                        .HasColumnType("int");

                    b.Property<int>("PartidosGanados")
                        .HasColumnType("int");

                    b.Property<int>("PartidosJugados")
                        .HasColumnType("int");

                    b.Property<int>("PartidosPerdidos")
                        .HasColumnType("int");

                    b.Property<int>("Puntos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Desempenos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DesempenoId")
                        .HasColumnType("int");

                    b.Property<int?>("DirectorTecnicoId")
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DesempenoId");

                    b.HasIndex("DirectorTecnicoId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Estadio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEstadio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estadios");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int?>("EstadioId")
                        .HasColumnType("int");

                    b.Property<string>("NombreMunicipio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.HasIndex("EstadioId");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("Torneo.App.Dominio.NovedadPartido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("Goles")
                        .HasColumnType("int");

                    b.Property<int>("JugadorInvolucrado")
                        .HasColumnType("int");

                    b.Property<string>("Novedad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TarjetasAmarilla")
                        .HasColumnType("int");

                    b.Property<int>("TarjetasRojas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Novedades");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Partidos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ArbitroId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoLocalId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoVisitanteId")
                        .HasColumnType("int");

                    b.Property<int?>("EstadioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("MarcadorLocal")
                        .HasColumnType("int");

                    b.Property<int>("MarcadorVisitante")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArbitroId");

                    b.HasIndex("EquipoLocalId");

                    b.HasIndex("EquipoVisitanteId");

                    b.HasIndex("EstadioId");

                    b.ToTable("Partidoss");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Arbitro", b =>
                {
                    b.HasBaseType("Torneo.App.Dominio.Persona");

                    b.Property<string>("Colegio")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Arbitro");
                });

            modelBuilder.Entity("Torneo.App.Dominio.DirectorTecnico", b =>
                {
                    b.HasBaseType("Torneo.App.Dominio.Persona");

                    b.HasDiscriminator().HasValue("DirectorTecnico");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Jugador", b =>
                {
                    b.HasBaseType("Torneo.App.Dominio.Persona");

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Posicion")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("EquipoId");

                    b.HasDiscriminator().HasValue("Jugador");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Equipo", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Desempeno", "Desempeno")
                        .WithMany()
                        .HasForeignKey("DesempenoId");

                    b.HasOne("Torneo.App.Dominio.DirectorTecnico", "DirectorTecnico")
                        .WithMany()
                        .HasForeignKey("DirectorTecnicoId");

                    b.Navigation("Desempeno");

                    b.Navigation("DirectorTecnico");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Municipio", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.HasOne("Torneo.App.Dominio.Estadio", "Estadio")
                        .WithMany()
                        .HasForeignKey("EstadioId");

                    b.Navigation("Equipo");

                    b.Navigation("Estadio");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Partidos", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Arbitro", "Arbitro")
                        .WithMany()
                        .HasForeignKey("ArbitroId");

                    b.HasOne("Torneo.App.Dominio.Equipo", "EquipoLocal")
                        .WithMany()
                        .HasForeignKey("EquipoLocalId");

                    b.HasOne("Torneo.App.Dominio.Equipo", "EquipoVisitante")
                        .WithMany()
                        .HasForeignKey("EquipoVisitanteId");

                    b.HasOne("Torneo.App.Dominio.Estadio", "Estadio")
                        .WithMany()
                        .HasForeignKey("EstadioId");

                    b.Navigation("Arbitro");

                    b.Navigation("EquipoLocal");

                    b.Navigation("EquipoVisitante");

                    b.Navigation("Estadio");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Jugador", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.Navigation("Equipo");
                });
#pragma warning restore 612, 618
        }
    }
}
