using Library.src.book.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.command.delete
{
    public class DeleteBookCommandExecutor : CommandExecutor
    {
        private DeleteBookArgumentsReader deleteBookArgumentsReader = new DeleteBookArgumentsReader();
        private BookService bookService = new BookService();

        public void Execute()
        {
            Console.WriteLine("*Delete Book*");
            DeleteBookArguments deleteBookArguments = deleteBookArgumentsReader.readArgumentsFromUser();
            bookService.DeleteBooks(deleteBookArguments.Title, deleteBookArguments.Author, deleteBookArguments.IsbnNumber);
            Console.WriteLine("All books with given data deleted");
        }
    }
}
