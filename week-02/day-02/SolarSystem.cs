using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            List<string> planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };


            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.

            Console.WriteLine(PutSaturn(planetList));
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"
            Console.ReadLine();
        }

        public static string PutSaturn (List<string> input)
        {
            input.Insert(5, "Saturn");
            StringBuilder solarSystemBuilder = new StringBuilder();
            foreach (string items in input)
            {
                solarSystemBuilder
                    .Append(items)
                    .Append(",\n");
            }
            return solarSystemBuilder.ToString();
        }

    }
}