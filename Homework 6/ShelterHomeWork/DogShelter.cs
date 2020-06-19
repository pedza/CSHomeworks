using System;
using System.Collections.Generic;
using System.Text;

namespace ShelterHomeWork
{
    public static class DogShelter
    {
        public static List<Dog> Shelter = new List<Dog>();

        public static void PrintAll()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("List of dogs in Shelter");
            foreach (var dog in Shelter)
            {
                
                
                Console.WriteLine(dog.Name);
            }
        }
    }
}
