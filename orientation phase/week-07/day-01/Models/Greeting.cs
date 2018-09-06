using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public static long IdCount = 0;
        public string Content { get; set; }

        public Greeting()
        {
            Id = 1;
            Content = "Hello Alex";
        }

        public Greeting(string input)
        {
            Content = input;
            IdCount++;
            Id = IdCount;
        }

        public long GetId()
        {
            return Id;
        }
    }
}
