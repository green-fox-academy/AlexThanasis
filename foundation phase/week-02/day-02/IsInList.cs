using System;
using System.Collections.Generic;

namespace IsInList
{
    public class IsInList
    {
        public static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            Console.WriteLine(CheckNums(list));
            Console.ReadLine(); 

        }

        public static bool CheckNums (List<int>input)
        {
            List<int> elements = new List<int>();
            elements.Add(4);
            elements.Add(8);
            elements.Add(12);
            elements.Add(16);
            int counter = 0;
            foreach (var num in input)
            {
                foreach (var item in elements)
                {
                    if(num == item)
                    {
                        counter++;
                        break;
                    }

                }
            }
            if (counter >= elements.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}