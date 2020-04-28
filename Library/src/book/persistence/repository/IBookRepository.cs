using Library.src.book.persistence.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.book.persistence
{
    public interface IBookRepository
    {
        Book Save(Book book);
        List<Book> SaveAll(List<Book> books);
        Book Update(Book book);
        void Delete(Book book);
        Book FindById(int id);
        List<Book> FindAllByTitle(string title);
        List<Book> FindAllByIsbn(string isbn);
        List<Book> FindAllByAuthor(string author);
        List<Book> FindAllByAuthorAndTitleAndIsbn(string author, string title, string isbn);
        List<Book> FindAll();
    }
}
