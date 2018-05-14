using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] r = new int[]
            {
                54, 23, 66, 12
            };

            int[] startend = new int[]
            {
                1, 2
            };

            Console.WriteLine(Sum(r, startend));

            Console.ReadLine();

            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer
        }

        public static int Sum(int[] input, int[] counter)
        {
            int sum = 0;
            int start = counter[0];
            int end = counter[1];
            while (start < end + 1)
            {
                sum += input[start];
                start++;
            }
            return sum;
        }
    }
}