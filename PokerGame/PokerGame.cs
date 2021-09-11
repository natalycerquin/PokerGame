using System;
using System.Collections.Generic;
using System.Text;

namespace PokerGame
{
    public class PokerGame
    {
        private List<Jugador> Jugadores = new List<Jugador>();
        private List<Carta> Cartas = new List<Carta>();

        public PokerGame()
        {  }

        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }

        public void Barajear()
        {

        }

        public void Jugar()
        {
            if (Jugadores.Count < 2 || Jugadores.Count > 5)
            {
                throw new Exception("Se requiere minimo dos jugadores");
            }
        }
    }
}
