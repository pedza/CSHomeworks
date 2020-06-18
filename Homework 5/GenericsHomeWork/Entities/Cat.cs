using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsHomeWork.Entities
{
    class Cat : Pet
    {
        public Cat(string name, string type, int age, int livesLeft, bool lazy) : base(name, type, age)
        {
            LivesLeft = livesLeft;

            Lazy = lazy;
        }
        

        public bool Lazy { get; set; }

        public int LivesLeft { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} has {LivesLeft} lives left");

            if (Lazy == true)
            {
                Console.WriteLine($"{Name} is a lazy cat");
            }
            else
            {
                Console.WriteLine($"{Name} is not a lazy cat");
            }
        }
    }
       
}
