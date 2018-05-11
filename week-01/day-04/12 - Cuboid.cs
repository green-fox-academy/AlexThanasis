using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //12
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double sideA, sideB, sideC;
            
                Console.WriteLine("Give the length of the side A!");
                sideA = Double.Parse(Console.ReadLine());
                Console.WriteLine("Give the length of the side B!");
                sideB = Double.Parse(Console.ReadLine());
                Console.WriteLine("Give the length of the side C!");
                sideC = Double.Parse(Console.ReadLine());
            Console.WriteLine("The sides You gave: " + sideA + "\t" + +sideB + "\t" + +sideC);
            double volume, area;
            volume = sideA * sideB * sideC;
            area = sideA * sideB * 2 + sideB * sideC * 2 + sideC * sideA * 2;
            Console.WriteLine("Area" + area + "\n Volume: " + volume);
            Console.ReadLine();
        }
    }
}