using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = {"Pedza", "Ivica", "Dejan", "Vesna" };
            string[] studentsG2= { "Krsto", "Zlatko", "Petko" };
            Console.WriteLine("Enter a number of the Group (between 1 and 2)");
            int groupInput = Convert.ToInt32(Console.ReadLine());

            if (groupInput == 1)
            {
                Console.WriteLine("The students from G1 are:");
                for(int i =0; i<studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }

            }
            else if (groupInput == 2)
            {
                Console.WriteLine("The students from G2 are:");
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine(studentsG2[i]);
                }
            }
            else { Console.WriteLine("The group doesnt exist"); }

        }
    }
}
