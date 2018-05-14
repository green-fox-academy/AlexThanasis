using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //15

            Console.WriteLine("KM-Mile converter and reverse");
            Console.WriteLine("\nChoose mode:\n Press 1 to convert km to mile \tPress 2 convert mile to km:");
            int mode = Int32.Parse(Console.ReadLine());
            double mileToKm = 1.609344, kmToMile = 0.621371192, km, mile;
            
            switch (mode)
            {
                case 1:
                    Console.WriteLine("Converting miles to km:");
                    mile = Double.Parse(Console.ReadLine());
                    km = mile * mileToKm;
                    Console.WriteLine("In km: " + km);
                    break;
                case 2:
                    Console.WriteLine("Converting km to miles:");
                    km = Double.Parse(Console.ReadLine());
                    mile = km * kmToMile;
                    Console.WriteLine("In miles: " + mile);
                    break;
                default:
                    Console.WriteLine("Invalid value chosen");
                    break;
            } 

            Console.ReadLine();

            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
        }
    }
}