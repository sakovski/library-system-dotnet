using Library.src.book.persistence.model;
using Library.src.libraryuser.persistence.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Library.src.parser
{
    public class XmlDbParser : DbParser
    {
        private static readonly string ELEMENT_BOOKS = "Books";
        private static readonly string ELEMENT_BOOK = "Book";
        private static readonly string ATTRIBUTE_IS_RENTED = "isRented";
        private static readonly string ELEMENT_TITLE = "Title";
        private static readonly string ELEMENT_AUTHOR = "Author";
        private static readonly string ELEMENT_ISBN = "Isbn";
        private static readonly string ELEMENT_LAST_RENTED = "LastRented";
        private static readonly string ELEMENT_LAST_RENTED_BY = "LastRentedBy";
        private static readonly string ELEMENT_LAST_RENTED_BY_FIRSTNAME = "Firstname";
        private static readonly string ELEMENT_LAST_RENTED_BY_LASTNAME = "Lastname";

        public XmlDbParser(string pathToDbFile) : base(pathToDbFile)
        {
        }

        public override List<Book> ParseBooks()
        {
            var queryDocument = XDocument.Load(pathToDbFile);

            return queryDocument.Element(ELEMENT_BOOKS).Elements(ELEMENT_BOOK)
                .ToBook()
                .ToList();
        }

        public override void SaveBooks(List<Book> books)
        {
            var document = new XDocument();
            var documentTree = new XElement(ELEMENT_BOOKS,
                from record in books
                select new XElement(ELEMENT_BOOK,
                    new XAttribute(ATTRIBUTE_IS_RENTED, record.IsRented),
                    new XElement(ELEMENT_TITLE, record.Title),
                    new XElement(ELEMENT_AUTHOR, record.Author),
                    new XElement(ELEMENT_ISBN, record.Isbn),
                    new XElement(ELEMENT_LAST_RENTED, record.LastRented),
                    new XElement(ELEMENT_LAST_RENTED_BY, 
                        new XElement(ELEMENT_LAST_RENTED_BY_FIRSTNAME, record.LastRentedBy.Firstname),
                        new XElement(ELEMENT_LAST_RENTED_BY_LASTNAME, record.LastRentedBy.Lastname)
                    )
                )
            );

            document.Add(documentTree);
            document.Save(pathToDbFile);
        }
    }
}
