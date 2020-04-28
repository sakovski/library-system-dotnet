using Library.src.book.persistence.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.parser
{
    public abstract class DbParser
    {
        protected string pathToDbFile;

        public DbParser(string pathToDbFile)
        {
            this.pathToDbFile = pathToDbFile;
        }

        public abstract List<Book> ParseBooks();

        public abstract void SaveBooks(List<Book> books);
    }
}
