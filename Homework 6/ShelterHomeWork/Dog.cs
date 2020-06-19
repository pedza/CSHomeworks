using System;
using System.Collections.Generic;
using System.Text;

namespace ShelterHomeWork
{
    public class Dog
    {
        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public static void Validate(Dog dog)
        {
            if (dog.Id >= 0 && dog.Name.Length >= 2)
            {

                Console.WriteLine($"The dog {dog.Name} is validated ");
           
                DogShelter.Shelter.Add(dog);
            }
            else
            {
                Console.WriteLine($"The dog {dog.Name} is not valid");
            }
        }
    }
}
