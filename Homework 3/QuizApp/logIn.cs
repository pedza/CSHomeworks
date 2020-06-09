using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    public class user
    {
        public user(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public Role Role {get; set; }
    }
}
