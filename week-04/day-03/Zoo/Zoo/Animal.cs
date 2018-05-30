using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private int hunger;
        private int gender;

        public Animal()
        {
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Hunger { get => hunger; set => hunger = value; }
        public int Gender { get => gender; set => gender = value; }

        public abstract void Greet();
        public abstract string WantChild();
        public abstract void Feed();
        public string GetName()
        {
            return Name;
        }
    }
}
