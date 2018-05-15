using System;
using System.Collections.Generic;

namespace ElementFinder
{
    public class ElementFinder
    {
        public static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(ContainsSeven(List));
            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!
            Console.ReadLine();
        }

        public static string ContainsSeven (List<int>input)
        {
            foreach (var item in input)
            {
                if (item == 7)
                {
                    return "Hoorray";
                }
                
            }
            return "Noooooo";
        }
    }
}