using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokerGame.Tests
{
    class PokerGameTest
    {
        [Test]
        public void Caso01()
        {
            var game = new PokerGame();
            Assert.Throws(typeof(Exception), () => game.Jugar());
        }

        [Test]
        public void Caso02()
        {
            var game = new PokerGame();
            game.AgregarJugador(new Jugador { Nombre = "Jugador 1" });
            Assert.Throws(typeof(Exception), () => game.Jugar());
        }

        [Test]
        public void Caso03()
        {
            var game = new PokerGame();
            game.AgregarJugador(new Jugador { Nombre = "Jugador 1" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 2" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 3" });
            Assert.DoesNotThrow(() => game.Jugar());
        }

        [Test]
        public void Caso04()
        {
            var game = new PokerGame();
            game.AgregarJugador(new Jugador { Nombre = "Jugador 1" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 2" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 3" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 4" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 5" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 6" });
            Assert.Throws(typeof(Exception), () => game.Jugar());
        }
    }
}
