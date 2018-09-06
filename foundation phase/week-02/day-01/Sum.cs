using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arrayToSum = new int[]
            {
                10, 20, 30, 40
            };

            Console.WriteLine(Sum(arrayToSum));

            Console.ReadLine();

            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer
        }

        public static int Sum (int[] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }
    }
}