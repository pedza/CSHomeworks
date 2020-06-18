using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenericsHomeWork.Entities
{
    public class PetStore<T> where T: Pet
    {
        private List<T> _pets;

        public PetStore()
        {
            _pets = new List<T>();
        }

        public void addPets(T item)
        {
            Console.WriteLine($"{item.Name} was added to the store");
            _pets.Add(item);
        }
        public void PrintPets()
        {
            foreach (T pet in _pets)
            {
                Console.WriteLine($"{pet.Name}");
            }
        }

        public void BuyPet(Pet name)
        {
           
            var item = _pets.FirstOrDefault(x => x == name);

            if(name == item)
            {
                _pets.Remove(item);

                Console.WriteLine($"You bought {item.Name}");

                item.PrintInfo();
            }
            else
            {
                Console.WriteLine($"Pet with name {name.Name} does not exist");
            }

            
        }
    }
}
