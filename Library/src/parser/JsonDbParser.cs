using Library.src.book.persistence.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Library.src.parser
{
    public class JsonDbParser : DbParser
    {
        private readonly JsonSerializerOptions serializerOptions;
        public JsonDbParser(string pathToDbFile) : base(pathToDbFile)
        {
            serializerOptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public override List<Book> ParseBooks()
        {
            var jsonString = File.ReadAllText(pathToDbFile);
            return JsonSerializer.Deserialize<List<Book>>(jsonString, serializerOptions);
        }

        public override void SaveBooks(List<Book> books)
        {
            var jsonString = JsonSerializer.Serialize(books, serializerOptions);
            File.WriteAllText(pathToDbFile, jsonString);
        }
    }
}
