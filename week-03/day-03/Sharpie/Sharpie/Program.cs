using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie sharpieOne = new Sharpie("Green", 15.3f);
            sharpieOne.Use();
            sharpieOne.Use();
            Console.WriteLine(sharpieOne.GetInkAmount);
        }
    }
}
