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
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.
            String story = "it's a story of an x: there was once a little x who wants to be a different x";
            Console.WriteLine(CharsToX(story));
            Console.ReadLine();
        }

        public static string CharsToX(string input)
        {
            string output = String.Empty;
            if (0 >= input.Length - 1)
            {
                return input[0].ToString().Replace('x', 'y');
            }
            else
            {
                output += input[0].ToString().Replace('x', 'y');
                return output + CharsToX(input.Remove(0, 1));
            }
            
        }

    }
}

