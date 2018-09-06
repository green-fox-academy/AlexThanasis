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
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".

            String story = "it's a story of an x: there was once a little x who wants to be a different x";
            Console.WriteLine(Asterisk(story));
            Console.ReadLine();
        }

        public static string Asterisk(string input)
        {
            string output = String.Empty;
            if (0 >= input.Length - 1)
            {
                return input[0].ToString().Insert(1, "*");
            }
            else
            {
                output += input[0] + "*";
                return output + Asterisk(input.Remove(0, 1));
            }
        }
    }
}

