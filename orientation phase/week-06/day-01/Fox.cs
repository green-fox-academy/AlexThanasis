using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_workshop
{
    class Fox
    {
        public Fox(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }

        //Exercise 10 Create a Fox class with 3 properties(name, type, color) 
        //Fill a list with at least 5 foxes, it's up to you how you name/create them! 
        //Write a LINQ Expression to find the foxes with green color! 
        //Write a LINQ Expression to find the foxes with green color and pallida type!

        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }


    }
}
