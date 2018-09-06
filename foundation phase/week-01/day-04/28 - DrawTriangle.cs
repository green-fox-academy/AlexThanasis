using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            //28

            Console.WriteLine("How long should be drawn the diagonal of the triangle?");

            int diagonal = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            
            for (int i = 0; i < diagonal; i++)
            {
                Console.WriteLine();
                for (int j= 0; j <= i; j++)
                {
                    Console.Write("*");
                }


            }

            Console.ReadLine();
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
        }
    }
}