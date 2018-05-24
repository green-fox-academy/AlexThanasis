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
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.

            String story = "it's a story of an x: there was once a little x who wants to be a different x";
            Console.WriteLine(RemoveX(story));
            Console.ReadLine();
        }

        public static string RemoveX(string input)
        {
            string output = String.Empty;
            if (0 >= input.Length - 1)
            {
                return input[0].ToString().Replace('x', ' ');
            }
            else
            {
                if (input[0] != 'x')
                {
                    output += input[0];
                }
                else
                {
                    output += input[0].ToString().Replace('x', ' ');
                }
                return output + RemoveX(input.Remove(0, 1));
            }
        }
    }
}

