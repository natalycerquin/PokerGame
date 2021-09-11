using NUnit.Framework;
using PokerGame.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerGame.Tests
{
    class PokerGameTest
    {
        [Test]
        public void Caso01()
        {
            var game = new PokerGame();
            Assert.Throws(typeof(CantidadJugadoresException), () => game.Jugar());
        }

        [Test]
        public void Caso02()
        {
            var game = new PokerGame();
            game.AgregarJugador(new Jugador { Nombre = "Jugador 1" });
            Assert.Throws(typeof(CantidadJugadoresException), () => game.Jugar());
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
            Assert.DoesNotThrow(() => game.Jugar());
        }

        [Test]
        public void Caso05()
        {
            var game = new PokerGame();
            game.AgregarJugador(new Jugador { Nombre = "Jugador 1" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 2" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 3" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 4" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 5" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 6" });
            Assert.Throws(typeof(CantidadJugadoresException), () => game.Jugar());
        }

        [Test]
        public void Caso06()
        {
            var game = new PokerGame();
            game.AgregarJugador(new Jugador { Nombre = "Jugador 1" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 2" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 3" });
            game.Barajear();
            var totalCartas = game.Cartas.Count;
            Assert.AreEqual(52, totalCartas);
        }

        [Test]
        public void Caso07()
        {
            var game = new PokerGame();
            game.AgregarJugador(new Jugador { Nombre = "Jugador 1" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 2" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 3" });
            game.Barajear();
            game.ValidarCartas();
            Assert.DoesNotThrow(() => game.Jugar());
        }

        [Test]
        public void Caso08()
        {
            var game = new PokerGame();
            game.AgregarJugador(new Jugador { Nombre = "Jugador 1" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 2" });
            game.AgregarJugador(new Jugador { Nombre = "Jugador 3" });
            game.Barajear();
            game.ValidarCartas();
            var totalDiamantesgame.ContarCartas();
            Assert.DoesNotThrow(() => game.Jugar());
        }
    }
}
