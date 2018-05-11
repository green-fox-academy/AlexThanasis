using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            //31

            Console.WriteLine("What is the length if a side of the square?");

            int length = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    for (int k = 0; k < length; k++)
                    {
                        Console.Write("%");
                    }
                    Console.WriteLine();
                }
                
                for ( i = 1; i < length - 1; i++)
                {
                    Console.Write("%");
                    for (int l = 1; l < length - 1; l++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("%");
                    Console.WriteLine();
                }
                if (i == length)
                {
                    for (int k = 0; k < length - 1; k++)
                    {
                        Console.Write("%");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadLine();

            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was
        }
    }
}