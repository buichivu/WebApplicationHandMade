using System;
using System.Collections.Generic;
using System.Text;

namespace handMadeShop.Utilities.Exceptions
{
    public class handMadeException : Exception
    {
        public handMadeException()
        {
        }

        public handMadeException(string message)
            : base(message)
        {
        }

        public handMadeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
