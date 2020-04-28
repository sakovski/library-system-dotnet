using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.menu
{
    public static class MenuChoice
    {

        public static readonly string MENU_COMMAND_ADD_BOOK = "1: Add book.";
        public static readonly string MENU_COMMAND_DELETE_BOOK = "2: Delete book.";
        public static readonly string MENU_COMMAND_SEARCH_BOOK_BY_PROPERTY = "3: Search book by name, author or ISBN number.";
        public static readonly string MENU_COMMAND_SEARCH_BOOK_BY_TIME_UNRENTED = "4: Search book by time being unrented.";
        public static readonly string MENU_COMMAND_RENT_BOOK = "5: Rent book.";
        public static readonly string MENU_COMMAND_RETURN_BOOK = "6: Return book.";
        public static readonly string MENU_COMMAND_PRINT_READERS_REPORT = "7: Print library users report.";
        public static readonly string MENU_COMMAND_EXIT = "Q: Exit.";

        private static List<string> menuChoicesCommands = new List<string>()
        {
            MENU_COMMAND_ADD_BOOK,
            MENU_COMMAND_DELETE_BOOK,
            MENU_COMMAND_SEARCH_BOOK_BY_PROPERTY,
            MENU_COMMAND_SEARCH_BOOK_BY_TIME_UNRENTED,
            MENU_COMMAND_RENT_BOOK,
            MENU_COMMAND_RETURN_BOOK,
            MENU_COMMAND_PRINT_READERS_REPORT,
            MENU_COMMAND_EXIT
        };

        public static List<string> GetMenuChoicesCommands()
        {
            return menuChoicesCommands;
        }
    }
}
