using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a recursive function called `refactorio`
            // that returns it's input's factorial

            Console.WriteLine(Refactorio(5));
            Console.ReadLine();
        }

        public static int Refactorio(int input)
        {
            if (input == 0)
            {
                return 0;
            }
            else if (input == 1)
            {
                return 1;
            }
            else
            {
                return input * Refactorio(input - 1);
            }
        }
    }
}

