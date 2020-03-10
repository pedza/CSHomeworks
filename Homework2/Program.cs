using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is the biggest num");
                if (num1 % 2 == 0)
                {
                    Console.WriteLine($"{num1} is even number");
                }
                else
                {
                    Console.WriteLine($"{num1} is odd number");
                }
            }

            else
            {
            
            Console.WriteLine($"{num2} is the biggest num");

            if (num2 % 2 == 0)
            {
                Console.WriteLine($"{num2} is even number");

            }
            else
            {
                Console.WriteLine($"{num2} is odd number");
            }

            }

        }
    }
}
