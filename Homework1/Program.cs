using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number between 1- 3");
           int number= Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("You Got a new Car");
                    break;

                case 2:
                    Console.WriteLine("You got a new plane");
                    break;
                case 3:
                    Console.WriteLine("you got a new bike");
                    break;
                default:
                    Console.WriteLine("Not a valid number");
                    break;
            }
        }
    }
}
