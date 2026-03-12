using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Exceptions
{
    internal class InvalidssnException : Exception
    {
        public InvalidssnException()
         : base("The provided SSN is invalid")
        { }

        public InvalidssnException(string message)
            : base(message)
        { }

        public InvalidssnException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
