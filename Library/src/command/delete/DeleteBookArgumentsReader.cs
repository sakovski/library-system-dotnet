using Library.src.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.command.delete
{
    public class DeleteBookArgumentsReader
    {
        private UserInputReader userInputReader = new UserInputReader();

        public DeleteBookArguments readArgumentsFromUser()
        {
            return new DeleteBookArguments()
            {
                Title = readTitle(),
                Author = readAuthor(),
                IsbnNumber = readIsbnNumber()
            };
        }

        private string readAuthor()
        {
            Console.WriteLine("Author: ");
            return userInputReader.GetUserInput();
        }

        private string readIsbnNumber()
        {
            Console.WriteLine("ISBN number: ");
            return userInputReader.GetUserInput();
        }

        private string readTitle()
        {
            Console.WriteLine("Title: ");
            return userInputReader.GetUserInput();
        }
    }
}
