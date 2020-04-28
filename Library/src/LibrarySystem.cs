using Library.src.book.persistence;
using Library.src.command;
using Library.src.core;
using Library.src.exception;
using Library.src.menu;
using Library.src.parser;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src
{
    public class LibrarySystem
    {

        private DbParserResolver dbParserResolver = new DbParserResolver();
        private MenuPrinter menuPrinter = new MenuPrinter();
        private UserInputReader userInputReader = new UserInputReader();
        private MenuCommandExecutorProvider menuCommandExecutorProvider = new MenuCommandExecutorProvider();

        public void run(string[] arguments)
        {
            try
            {
                var pathToDbFile = new ArgumentsParser().ParseArguments(arguments);
                var dbParser = dbParserResolver.ResolveDbParser(pathToDbFile);
                var dbManager = new DbManager(dbParser);
                InitializeDb(dbManager);

                menuPrinter.PrintWelcomeMessage();

                while (true)
                {
                    try
                    {
                        menuPrinter.PrintMenu();
                        var commandExecutor = menuCommandExecutorProvider.GetExecutor(userInputReader.GetUserInput());
                        commandExecutor.Execute();
                        dbManager.SaveDbState();
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error while initializing the application:\n{exception}");
                return;
            }      
        }

        private void InitializeDb(DbManager dbManager)
        {
            dbManager.InitializeDb();
            Console.WriteLine("Library loaded!");
        }
    }
}
