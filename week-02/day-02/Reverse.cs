using System;
using System.Text;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(ReverseString(reversed));
        }

        public static string ReverseString (String input)
        {
            StringBuilder output = new StringBuilder(input);
            
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[input.Length - i - 1];
            }
            
            return output.ToString();
        }
    }
}