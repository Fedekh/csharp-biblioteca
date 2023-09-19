using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document
    {
        protected string Code { get; set; }
        protected string Title { get; set; }
        protected int Year { get; set; }
        protected string Sector { get; set; }
        protected string Scaffale { get; set; }
        protected Author Author{ get; }

        public Document(string code, string title, int year, string sector, string scaffale, Author author)
        {
            Code = code;
            Title = title;
            Year = year;
            Sector = sector;
            Scaffale = scaffale;
            Author = author;
        }

        public string GetLocationDocument(string sector, string scaffale)
        {
            return $"Il documento si trova nel settore {sector}, allo scaffale {scaffale}";
        }

        public void SetAuthor(Author author)
        {
            Author = author;
        }
    }
}
