using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsHomeWork.Entities
{
    public abstract class Pet
    {
        public Pet(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;

        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public abstract void PrintInfo();
        
    }
}
