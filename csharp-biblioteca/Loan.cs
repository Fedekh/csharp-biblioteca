using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Loan
    {
        public User User { get; set; }
        public Document Document { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
    }
}
