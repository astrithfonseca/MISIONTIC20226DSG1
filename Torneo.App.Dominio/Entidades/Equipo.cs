using System;
namespace Torneo.App.Dominio
{
public class Equipo
{
public int Id { get; set; }
public string NombreEquipo { get; set; }
public DirectorTecnico DirectorTecnico{ set; get; }
public Desempeno Desempeno { set; get; }
}
}