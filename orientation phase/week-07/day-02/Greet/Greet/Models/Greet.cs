using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greet.Models
{
    public class Greeting : IGreeting
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public Greeting()
        {
            Name = "Defaul";
            Text = "Tsah ";

        }

        public void GetName(string inputName)
        {
            Name = inputName;
        }

        public string GreetSomeone(string inputName)
        {
            string text = "Hello there, " + inputName;
            return text;
        }
    }
}
