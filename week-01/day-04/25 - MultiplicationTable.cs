using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            //25

            Console.WriteLine("***Multuplication Table*** \n Ladies and Gentlemen! Let me introduce You the world famous Mega-Multiplicator! \n Give me a number:");
            int num = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + " * " + num + " = " + i * num); 
            }
            Console.WriteLine("Tadaaaa...");

            Console.ReadLine();

            // Create a program that asks for a number and prints the multiplication table with that number
            //
            // Example:
            // The number 15 should print:
            //
            // 1 * 15 = 15
            // 2 * 15 = 30
            // 3 * 15 = 45
            // 4 * 15 = 60
            // 5 * 15 = 75
            // 6 * 15 = 90
            // 7 * 15 = 105
            // 8 * 15 = 120
            // 9 * 15 = 135
            // 10 * 15 = 150
        }
    }
}