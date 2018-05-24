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
            Console.WriteLine(NumberAdder(6));
            Console.ReadLine();
        }

        static int NumberAdder(int n)
        {
            if (n > 1)
            {
                return n + NumberAdder(n - 1);
            }
            else
            {
                return 1;
            }
        }
        // 1 2 3  4  5  6  7  8 n = 8
        // 1 3 6 10 15 21 28 36 
    }
}
