using System;
using System.Collections.Generic;
using System.Text;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"
        }

        public static string AppendA (List<string> input)
        {
            
            StringBuilder output = new StringBuilder();
            foreach (string animalNames in input)
            {
                output
                    .Append(animalNames)
                    .Append("a,\n");
            }
            return output.ToString();
        }
    }
}