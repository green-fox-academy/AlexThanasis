using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            //18
            int num = Int32.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("This number is an even number");
            }
            else
            {
                Console.WriteLine("This number is an odd number");
            }

            Console.ReadLine();
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.

        }
    }
}