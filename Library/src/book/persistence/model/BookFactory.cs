using Library.src.libraryuser.persistence.model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Library.src.book.persistence.model
{
    public static class BookFactory
    {
        public static Book FromXmlElement(XElement book)
        {
            return new Book
            {
                Title = book.Element("Title").Value,
                Isbn = book.Element("Isbn").Value,
                IsRented = bool.Parse(book.Attribute("isRented").Value),
                LastRented = DateTime.Parse(book.Element("LastRented").Value),
                Author = book.Element("Author").Value,
                LastRentedBy = LibraryUserFactory.FromXmlElement(book.Element("LastRentedBy"))
            };
        }
    }
}
