using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter numberFirst = new Counter();
            Counter numberSecond = new Counter(10);
            numberFirst.Add(6);
            numberSecond.Add();
            Console.WriteLine(numberFirst.Get + " and "+  numberSecond.Get);
            numberFirst.Reset();
            numberSecond.Reset();
            Console.WriteLine("And now: {0} and {1}",  numberFirst.Get, numberSecond.Get);
        }
    }
}
