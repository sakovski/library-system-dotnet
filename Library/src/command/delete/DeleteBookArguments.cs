using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.command.delete
{
    public class DeleteBookArguments
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string IsbnNumber { get; set; }
    }
}
