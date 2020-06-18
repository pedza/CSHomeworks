using GenericsHomeWork.Entities;
using System;
using System.Collections.Generic;

namespace GenericsHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Sparky", "Shepard", 5, "bone", false);
            Dog dog2 = new Dog("Spic", "Doga", 4, "meat", true);
            Dog dog3 = new Dog("Balto", "Doberman", 2, "pizza", true);

            Cat cat1 = new Cat("Tom", "domestic", 1, 9, true);
            Cat cat2 = new Cat("Smokey", "Siamese", 3, 5, false);
            Cat cat3 = new Cat("Sammy", "Persian", 6, 2, false);

            Fish fish1 = new Fish("Nemo", "Mollies", 1, "Yellow", "medium");
            Fish fish2 = new Fish("Bubbles", "Zebra Danios", 2, "Blue", "small");
            Fish fish3 = new Fish("Captain", "Platies", 2, "Black", "big");

            PetStore<Dog> dogStore = new PetStore<Dog>();
            dogStore.addPets(dog1);
            dogStore.addPets(dog2);
            dogStore.PrintPets();
            dogStore.BuyPet(dog3);
            Console.WriteLine("================================");

            PetStore<Cat> catStore = new PetStore<Cat>();
            catStore.addPets(cat3);
            catStore.addPets(cat1);
            catStore.PrintPets();
            catStore.BuyPet(cat3);
            Console.WriteLine("================================");

            PetStore<Fish> fishStore = new PetStore<Fish>();
            fishStore.addPets(fish2);
            fishStore.addPets(fish3);
            fishStore.PrintPets();
            fishStore.BuyPet(fish3);
            Console.ReadLine();
        }
    }
}
