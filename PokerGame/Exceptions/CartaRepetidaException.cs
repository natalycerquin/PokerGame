using System;
using System.Collections.Generic;
using System.Text;

namespace PokerGame.Exceptions
{
    public class CartaRepetidaException : Exception
    {
        public CartaRepetidaException()
        {
        }

        public CartaRepetidaException(string message)
            : base(message)
        {
        }

        public CartaRepetidaException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
