using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Mammal : Animal
    {
        public Mammal(string name)
        {
            Name = Name;
        }

        public override void Feed()
        {
            Hunger--;
        }

        public override void Greet()
        {
            Console.WriteLine("Awwww");
        }

        public override string WantChild()
        {
            return "want a child from my uterus";
        }
    }
}
