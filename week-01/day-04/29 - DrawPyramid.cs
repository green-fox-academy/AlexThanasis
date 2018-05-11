using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            //29

            Console.WriteLine("What is the height of the pyramid?");

            int height = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < height - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write("*");
                                    }
            }

            Console.ReadLine();

            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
        }
    }
}