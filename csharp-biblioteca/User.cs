using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        private string Name { get; set; }
        private string Lastname { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string Phone { get; set; }

        public User(string name, string lastname, string email, string password, string phone)
        {
            Name = name;
            Lastname = lastname;
            Email = email;
            Password = password;
            Phone = phone;
        }
    }
}
