using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.src.menu
{
    public class MenuPrinter
    {
        public static readonly string WELCOME_MESSAGE = "Welcome to Library System!";
        public static readonly string HEADER_MESSAGE = "Please type a number from command list: ";

        private string Menu;

        public MenuPrinter()
        {
            Menu = BuildMenu();
        }

        public void PrintMenu()
        {
            Console.WriteLine(Menu);
        }

        public void PrintWelcomeMessage()
        {
            Console.WriteLine(WELCOME_MESSAGE);
        }

        private string BuildMenu()
        {
            return HEADER_MESSAGE + Environment.NewLine + string.Join(Environment.NewLine, MenuChoice.GetMenuChoicesCommands());
        }
    }
}
