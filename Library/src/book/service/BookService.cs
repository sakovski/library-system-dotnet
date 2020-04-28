using Library.src.book.persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.book.service
{
    public class BookService
    {
        private IBookRepository bookRepository = new InMemoryBookRepository();
        
        public void DeleteBooks(string title, string author, string isbnNumber)
        {
            var booksToDelete = bookRepository.FindAllByAuthorAndTitleAndIsbn(author, title, isbnNumber);
            booksToDelete.ForEach(book => bookRepository.Delete(book));
        }
    }
}
