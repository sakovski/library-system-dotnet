using Library.src.libraryuser.persistence.model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Library.src.book.persistence.model
{
    public static class BookExtensions
    {
        public static IEnumerable<Book> ToBook(this IEnumerable<XElement> books)
        {
            foreach (XElement book in books)
            {
                yield return BookFactory.FromXmlElement(book);
            }
        }
    }
}
