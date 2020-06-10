using HomeworkAbstractClassAndInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkAbstractClassAndInterface.Class
{
    public abstract class User:IUser
    {
        public User(int id, string username, int password)
        {
            ID = id;
            Username = username;
            Password = password;
        }
        public int ID { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }

        public virtual void PrintUser()
        {
            Console.WriteLine($"{ID}, {Username}, {Password}");
        }
    }
}
