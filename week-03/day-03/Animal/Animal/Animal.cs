using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        public int hunger = 50;
        public int thirst = 50;

        public Animal(int hunger, int thirst)
        {
            this.hunger = 50;
            this.thirst = 50;
        }

        public Animal()
        {
            
        }

        public void eat()
        {
            hunger--;
        }

        public void drink()
        {
            thirst--;
        }

        public void play()
        {
            hunger++;
            thirst++;
        }

        public void GetValues ()
        {
            Console.WriteLine(hunger);
            Console.WriteLine(thirst);
        }
    }
}
