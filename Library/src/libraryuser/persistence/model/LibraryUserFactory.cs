using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Library.src.libraryuser.persistence.model
{
    public static class LibraryUserFactory
    {
        public static LibraryUser FromXmlElement(XElement libraryUser)
        {
            return new LibraryUser()
            {
                Firstname = libraryUser.Element("Firstname").Value,
                Lastname = libraryUser.Element("Lastname").Value
            };
        }
    }
}
