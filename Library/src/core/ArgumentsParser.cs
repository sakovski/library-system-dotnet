using Library.src.exception;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Library.src
{
    public class ArgumentsParser
    {
        public string ParseArguments(string[] arguments)
        {
            if (arguments.Length < 1 || arguments.Length > 1)
            {
                throw new ArgumentParsingException("Please provide the JSON or XML file as input parameter");
            }

            return arguments[0];
        }
    }
}
