using System;
using System.Collections.Generic;
using System.Text;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.WriteLine(MakingMatches(girls, boys));
            Console.ReadLine();
        }

        public static string MakingMatches (List<string>inputGirls, List<string>inputBoys)
        {
            StringBuilder matches = new StringBuilder();
            for (int i = 0; i < inputGirls.Count; i++)
            {
                matches.Append(inputGirls[i]).Append(", ").Append(inputBoys[i]).Append(",\n");
            }
            
            return matches.ToString();
        }
    }
}