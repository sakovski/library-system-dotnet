using Library.src.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.parser
{
    public class DbParserResolver
    {
        public DbParser ResolveDbParser(String pathToDbFile)
        {
            if (pathToDbFile.EndsWith(Constants.JSON_FILE_EXTENSION))
            {
                return new JsonDbParser(pathToDbFile);
            }
            else if (pathToDbFile.EndsWith(Constants.XML_FILE_EXTENSION))
            {
                return new XmlDbParser(pathToDbFile);
            }

            throw new NotSupportedException("Application support only XML and JSON files.");
        }
    }
}
