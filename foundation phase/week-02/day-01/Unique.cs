using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Int32.Parse(Console.ReadLine());
            int[] arrayOfNum = new int[length];
            for (int i = 0; i < length; i++)
            {
                arrayOfNum[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine(Unique(arrayOfNum);
            
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once

            //  Example
            //Console.WriteLine(Unique({ 1, 11, 34, 11, 52, 61, 1, 34}));
            //  should print: `[1, 11, 34, 52, 61]`
            Console.ReadLine();
        }

        public static int[] Unique (int[] input)
        {
            int doubleCases;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == input[i])
                    {
                        doubleCases++;
                    }
                    input[j] = 
                }
            }  
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                
            }

            return output;
        }
    }
}
