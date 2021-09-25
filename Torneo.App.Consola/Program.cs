using System;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Consola
{
    class Program
    {
        //private static IRepositorioJugador _repoJugador= new RepositorioJugador();
        private static IRepositorioJugador _repoJugador= new RepositorioJugador(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddJugador();
            BuscarJugador(1);
            //MostrarJugadores();
        }

        private static void AddJugador()
        {
            var Jugador = new Jugador
            {
                Nombre = "Juan Martin",
                Apellidos = "Benavides",
                NumeroTelefono = "310520",
                Documento = 1094,
                Numero = 8,
                Posicion = "Delantero"
            };
            _repoJugador.AddJugador(Jugador);
        }
        private static void BuscarJugador(int idJugador)
        {
            var Jugador = _repoJugador.GetJugador(idJugador);
            Console.WriteLine(Jugador.Nombre+" "+Jugador.Apellidos);
        }
        private static void MostrarJugadores()
        {
            var Jugadores = _repoJugador.GetAllJugadores();
            foreach (var Jugador in Jugadores)
            {
                Console.WriteLine(Jugador.Nombre+" "+Jugador.Apellidos);
            }
        }

    }
}