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
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).
            
            Console.WriteLine(Ears(60));
            Console.ReadLine();
        }

        public static int Ears(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 2;
            }
            else
            {
                return 2 + Ears(n - 1);
            }
        }
    }
}
