using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            Console.WriteLine(Greet(al));
            Console.ReadLine();
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`
        }

        public static string Greet (string input)
        {
            return "Greetings dear, " + input;
        }
    }
}