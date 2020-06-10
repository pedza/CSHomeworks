using HomeworkAbstractClassAndInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkAbstractClassAndInterface.Class
{
    public class Student : User, IStudent
    {
        public Student(int id, string username, int password, int grades):base(id, username, password)
        {
            Grades = grades;
        }
        public int Grades { get; set; }

        public override void PrintUser()
        {
            Console.WriteLine($"Grades: {Grades}");
        }
    }
}
