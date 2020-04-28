using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.command
{
    public class InvalidMenuChoiceException : Exception
    {
        public InvalidMenuChoiceException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
