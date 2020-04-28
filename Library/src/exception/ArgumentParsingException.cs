using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.exception
{
    class ArgumentParsingException : ApplicationInitializationException
    {
        public ArgumentParsingException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
