using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrome = Console.ReadLine();

            Console.WriteLine(Palindrome(palindrome)); 
            
            Console.ReadLine();
        }

        public static string Palindrome (string input)
        {
            string palindrome = input;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                palindrome += input[i];
            }
            return palindrome;
        }

    }
}