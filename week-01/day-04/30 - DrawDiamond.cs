using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            //30

            Console.WriteLine("What is the length if a side of the diamond?");

            int lenght = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < lenght - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
            }
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < lenght * 2 - i * 2 - 1 ; j++)
                {
                    Console.Write("*");
                }
            }


            Console.WriteLine("\n");
            Console.WriteLine("Lucy in the sky with diaaaaamonds...");

            Console.ReadLine();

            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

        }
    }
}