using System;

namespace Class_3_Task_1_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arrayInt = new int[6];
            int sum = 0;
            for (int i = 0; i<6; i++)
            {
                Console.WriteLine($"enter humber {i+1}");
               arrayInt[i] = Convert.ToInt32(Console.ReadLine());

                if (arrayInt[i] % 2 == 0)
                {
                    sum += arrayInt[i];
                }

            };
            Console.WriteLine($"the sum of the even numbers is {sum}");
            Console.Read();

        }
    }
}
