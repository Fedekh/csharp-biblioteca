using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Author
    {
        public string Name { get; private set; }
        public string Lastname { get; private set; }

        public Author(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }
    }
}
