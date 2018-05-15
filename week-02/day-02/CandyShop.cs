using System;
using System.Collections.Generic;
using System.Text;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.
           
            Console.WriteLine(Sweets(list));
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
            Console.ReadLine();
        }

        public static List<object> SweetsListCorrector(List<object> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                Type t = input[i].GetType();
                if (t.Equals(typeof(int)))
                {
                    input[i] = "Croissant";
                }
                else if (t.Equals(typeof(bool)))
                {
                    input[i] = "Ice cream";
                }
                        
            }
            return input;
        }

        public static string Sweets(List<object>input)
        {
            input = SweetsListCorrector(input);
            StringBuilder output = new StringBuilder();
            foreach (var item in input)
            {
                output.Append(item).Append(", ");
            }

            return output.ToString();
        }

    }
}