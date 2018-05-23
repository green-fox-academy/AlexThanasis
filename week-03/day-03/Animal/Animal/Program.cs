using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal horse = new Animal();
            horse.drink();
            Animal cat = new Animal(50, 50);
            cat.drink();
            cat.play();
            horse.GetValues();
            cat.GetValues();
        }
    }
}
