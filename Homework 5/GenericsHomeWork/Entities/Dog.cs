using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsHomeWork.Entities
{
    class Dog : Pet
    {
        public Dog(string name, string type, int age, string favoritefood, bool goodboy):base(name, type, age)
        {
            FavoriteFood = favoritefood;
            GoodBoy = goodboy;
        }

        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Name}'s favorite food is {FavoriteFood}");

            if(GoodBoy == true)
            {
                Console.WriteLine($"The dog {Name} is a good boy");
            }
            else
            {
                Console.WriteLine($"The dog {Name} is a bad boy");
            }
        }
    }
}
