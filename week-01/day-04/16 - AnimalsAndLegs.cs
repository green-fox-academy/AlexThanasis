using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            int chikensNum = Int32.Parse(Console.ReadLine());
            int pigsNum = Int32.Parse(Console.ReadLine());

            int chickenLegs = 2;
            int pigLegs = 4;

            Console.WriteLine("Total number of legs: " + (chickenLegs * chikensNum + pigLegs * pigsNum));
            Console.ReadLine();
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
        }
    }
}