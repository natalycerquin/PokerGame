using System;
using System.Collections.Generic;
using System.Text;

namespace PokerGame.Exceptions
{
    public class CantidadJugadoresException : Exception
    {
        public CantidadJugadoresException()
        {
        }

        public CantidadJugadoresException(string message)
            : base(message)
        {
        }

        public CantidadJugadoresException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
