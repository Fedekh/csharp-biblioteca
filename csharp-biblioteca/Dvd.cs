using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        public int Duration { get; private set; }

        public Dvd(string code, string title, int year, string sector, string scaffale, Author author, int duration)
            : base(code, title, year, sector, scaffale, author)
        {
            Duration = duration;
        }
    }
}
