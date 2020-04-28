using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.exception
{
    public class ApplicationInitializationException : Exception
    {
        public ApplicationInitializationException(string errorMessage, Exception inner) : base(errorMessage, inner)
        { 
        }

        public ApplicationInitializationException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
