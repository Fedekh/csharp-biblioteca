using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Book : Document
    {
        private int NumberPages { get; set; }

        public Book(string code, string title, int year, string sector, string scaffale, Author author, int numberPages) :
            base (code, title, year,sector,scaffale, author)
        {
            NumberPages = numberPages;
        }
    }

}
