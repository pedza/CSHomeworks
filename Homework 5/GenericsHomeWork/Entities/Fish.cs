using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsHomeWork.Entities
{
    class Fish : Pet
    {
        public Fish(string name, string type, int age, string color, string size) : base(name, type, age)
        {
            Color = color;

            Size = size;


        }

        public string Color { get; set; }
        public string Size { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"The fish {Name}, has {Color} color, and is {Size} in size");
        }
    }
}
