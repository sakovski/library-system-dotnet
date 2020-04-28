using Library.src;
using Library.src.parser;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            new LibrarySystem().run(args);
        }
    }
}
