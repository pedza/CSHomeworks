using HomeworkAbstractClassAndInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkAbstractClassAndInterface.Class
{
    public class Teacher : User, ITeacher
    {
        public Teacher(int id, string username, int password, string subject): base(id, username, password)
        {
            Subject = subject;
        }

        public string Subject { get; set; }

        public override void PrintUser()
        {
           Console.WriteLine($"Subject: {Subject}");
        }
    }
}
