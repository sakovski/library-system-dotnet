using Library.src.book.persistence.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.src.book.persistence
{
    public class InMemoryBookRepository : IBookRepository
    {
        private static readonly List<Book> booksEntities = new List<Book>();

        public Book Save(Book book)
        {
            booksEntities.Add(book);
            return book;
        }

        public List<Book> SaveAll(List<Book> books)
        {
            booksEntities.AddRange(books);
            return booksEntities;
        }

        public Book Update(Book book)
        {
            var existingBook = FindById(book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Isbn = book.Isbn;
                existingBook.LastRented = book.LastRented;
                existingBook.LastRentedBy = book.LastRentedBy;
                existingBook.IsRented = book.IsRented;
            }

            return existingBook;
        }

        public void Delete(Book book)
        {
            var bookToDelete = FindById(book.Id);
            booksEntities.Remove(bookToDelete);
        }

        public Book FindById(int id)
        {
            return booksEntities.FirstOrDefault(book => book.Id == id);
        }

        public List<Book> FindAllByTitle(string title)
        {
            return booksEntities.Where(book => book.Title.Contains(title, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        public List<Book> FindAllByIsbn(string isbn)
        {
            return booksEntities.Where(book => book.Isbn.Contains(isbn, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Book> FindAllByAuthor(string author)
        {
            return booksEntities.Where(book => book.Author.Contains(author, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        public List<Book> FindAllByAuthorAndTitleAndIsbn(string author, string title, string isbn)
        {
            return booksEntities
                .Where(book => book.Author.Contains(author, StringComparison.InvariantCultureIgnoreCase))
                .Where(book => book.Isbn.Contains(isbn, StringComparison.OrdinalIgnoreCase))
                .Where(book => book.Title.Contains(title, StringComparison.InvariantCultureIgnoreCase))
                .ToList();
        }

        public List<Book> FindAll()
        {
            return booksEntities;
        }
    }
}
