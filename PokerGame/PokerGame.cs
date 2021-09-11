using PokerGame.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokerGame
{
    public class PokerGame
    {
        public List<Jugador> Jugadores = new List<Jugador>();
        public List<Carta> Cartas = new List<Carta>();

        public PokerGame()
        {  }

        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }

        public void Barajear()
        {
            for (int i = 1; i <= 4; i++)
            {
                string simbolo = i switch
                {
                    1 => "Corazones",
                    2 => "Diamantes",
                    3 => "Espadas",
                    _ => "Trebol",
                };

                for (int j = 1; j <= 13; j++)
                {
                    Cartas.Add(new Carta
                    {
                        Valor = j,
                        Simbolo = simbolo
                    });
                }
            }
        }

        public int ContarCartas(string simbolo)
        {
            var total = 0;
            foreach (var carta in Cartas)
            {
                if (carta.Simbolo == simbolo)
                {
                    total += 1;
                }
            }
            return total;
        }


        public void ValidarCartas()
        {
            foreach (var carta in Cartas)
            {
                var repeticiones = 0;
                foreach (var carta1 in Cartas)
                {
                    if (carta.Valor == carta1.Valor && carta.Simbolo == carta1.Simbolo)
                    {
                        repeticiones += 1;
                    }
                }
                if (repeticiones > 1)
                {
                    throw new CartaRepetidaException();
                }
            }
        }


        public void Jugar()
        {
            if (Jugadores.Count < 2 || Jugadores.Count > 5)
            {
                throw new CantidadJugadoresException("Se requiere minimo dos jugadores");
            }

            Barajear();


            ValidarCartas();
        }
    }
}
