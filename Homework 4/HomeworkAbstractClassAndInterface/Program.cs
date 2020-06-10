using HomeworkAbstractClassAndInterface.Class;
using System;

namespace HomeworkAbstractClassAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Teacher Teacher1 = new Teacher(350, "teacher", 55546, "Math");
            Teacher Teacher2 = new Teacher(456, "teacher", 554687, "geography");

            Student Student1 = new Student(456, "student", 45547, 10 );
            Student Student2 = new Student(456, "student", 45547, 8);

            Teacher1.PrintUser();
            Teacher2.PrintUser();
            Student1.PrintUser();
            Student2.PrintUser();

            Console.ReadLine();
        }
    }
}
