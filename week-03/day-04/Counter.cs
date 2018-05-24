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
            Console.WriteLine(Counter(8));
            Console.ReadLine();
        }

        public static int Counter(int n)
        {
            if(n > 0)
            {
                Console.WriteLine(n--);
                return Counter(n);
            }
            else
            {
                return 0;
            }
        }

    }


}
