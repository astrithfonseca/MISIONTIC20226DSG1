using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
        //private readonly AppContext _appContext = new AppContext();

        private readonly AppContext _appContext;
        public RepositorioJugador(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Jugador AddJugador(Jugador Jugador)
        {
            var JugadorAdicionado = _appContext.Jugadores.Add(Jugador);
            _appContext.SaveChanges();
            return JugadorAdicionado.Entity;
        }

        public void DeleteJugador(int idJugador)
        {
            var JugadorEncontrado = _appContext.Jugadores.Find(idJugador);
            if (JugadorEncontrado == null)
                return;
            _appContext.Jugadores.Remove(JugadorEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Jugador> GetAllJugadores()
        {
            return _appContext.Jugadores;
        }

        public Jugador GetJugador(int idJugador)
        {
            return _appContext.Jugadores.Find(idJugador);
        }

        public Jugador UpdateJugador(Jugador Jugador)
        {
            var JugadorEncontrado = _appContext.Jugadores.Find(Jugador.Id);
            if (JugadorEncontrado != null)
            {
                JugadorEncontrado.Documento = Jugador.Documento;
                JugadorEncontrado.Nombre = Jugador.Nombre;
                JugadorEncontrado.Apellidos = Jugador.Apellidos;
                JugadorEncontrado.NumeroTelefono = Jugador.NumeroTelefono;
                JugadorEncontrado.Numero = Jugador.Numero;
                JugadorEncontrado.Posicion = Jugador.Posicion;
                _appContext.SaveChanges();
            }
            return JugadorEncontrado;
        }
    }
}