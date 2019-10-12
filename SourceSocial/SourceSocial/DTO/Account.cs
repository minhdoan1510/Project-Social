using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string username;
        private string password;
        private string name;

        public Account()
        {
            name = "";
        }
        public Account(string _username,string _password,string _name) { Username = _username; Password = _password; Name = _name; }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
    }
}
