using System;

namespace ShelterHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog dog1 = new Dog(123, "Sparky", "Yellow");
            Dog dog2 = new Dog(654, "Belco", "Black");
            Dog dog3 = new Dog(-123, "Rex", "Red");

            Dog.Validate(dog1);
            Dog.Validate(dog2);
            Dog.Validate(dog3);

            DogShelter.PrintAll();
            Console.ReadLine();
           
        }
    }
}
