using Library.src.book.persistence;
using Library.src.book.persistence.model;
using Library.src.parser;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src
{
    public class DbManager
    {
        private DbParser dbParser;
        private IBookRepository bookRepository = new InMemoryBookRepository();

        public DbManager(DbParser dbParser)
        {
            this.dbParser = dbParser;
        }

        public void InitializeDb()
        {
            var parsedBooks = dbParser.ParseBooks();
            bookRepository.SaveAll(parsedBooks);
        }

        public void SaveDbState()
        {
            var booksToSave = bookRepository.FindAll();
            dbParser.SaveBooks(booksToSave);
        }
    }
}
