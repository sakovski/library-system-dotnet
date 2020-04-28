using Library.src.command.add;
using Library.src.command.delete;
using Library.src.command.exit;
using Library.src.command.rent;
using Library.src.command.report;
using Library.src.command.search;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.command
{
    public class MenuCommandExecutorProvider
    {
        private CommandExecutor addNewBookCommandExecutor = new AddNewBookCommandExecutor();
        private CommandExecutor deleteBookCommandExecutor = new DeleteBookCommandExecutor();
        private CommandExecutor searchBookByPropertyCommandExecutor = new SearchBookByPropertyCommandExecutor();
        private CommandExecutor searchBooksByTimeUnrentedCommandExecutor = new SearchBooksByWeeksUnrentedCommandExecutor();
        private CommandExecutor rentBookCommandExecutor = new RentBookCommandExecutor();
        private CommandExecutor returnBookCommandExecutor = new ReturnBookCommandExecutor();
        private CommandExecutor readersReportCommandExecutor = new LibraryUsersReportCommandExecutor();
        private CommandExecutor exitCommandExecutor = new ExitCommandExecutor();

        public CommandExecutor GetExecutor(string userInput)
        {
            if (userInput.Equals("1"))
            {
                return addNewBookCommandExecutor;
            }
            if (userInput.Equals("2"))
            {
                return deleteBookCommandExecutor;
            }
            if (userInput.Equals("3"))
            {
                return searchBookByPropertyCommandExecutor;
            }
            if (userInput.Equals("4"))
            {
                return searchBooksByTimeUnrentedCommandExecutor;
            }
            if (userInput.Equals("5"))
            {
                return rentBookCommandExecutor;
            }
            if (userInput.Equals("6"))
            {
                return returnBookCommandExecutor;
            }
            if (userInput.Equals("7"))
            {
                return readersReportCommandExecutor;
            }
            if (userInput.Equals("Q"))
            {
                return exitCommandExecutor;
            }
            throw new InvalidMenuChoiceException("Wrong menu choice: " + userInput);
        }
    }
}
