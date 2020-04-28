using Library.src.libraryuser.persistence.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.book.persistence.model
{
    public class Book
    {
        private static int lastId = 0;
        public Book()
        {
            lastId++;
            Id = lastId;
        }
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public bool IsRented { get; set; }
        public DateTime LastRented { get; set; }
        public string Author { get; set; }

        public LibraryUser LastRentedBy { get; set; }
    }
}
