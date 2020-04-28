using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.core
{
    public class UserInputReader
    {
        private static readonly string USER_INPUT_INDICATOR = "> ";

        public string GetUserInput()
        {
            Console.WriteLine(USER_INPUT_INDICATOR);
            return Console.ReadLine();
        }
    }
}
