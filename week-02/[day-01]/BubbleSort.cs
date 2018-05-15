using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {


            //  Create a function that takes a list of numbers as parameter
            //  Returns a list where the elements are sorted in ascending numerical order
            //  Make a second boolean parameter, if it's `True` sort that list descending

            //  Example:
            int[] arrayVolOne = Bubble(new int[] { 34, 12, 24, 9, 5 });
            for (int i = 0; i < arrayVolOne.Length; i++)
            {
                Console.Write(arrayVolOne[i] + " ");

            }
            //  should print [5, 9, 12, 24, 34]
            //Console.WriteLine(AdvancedBubble(new int[] { 34, 12, 24, 9, 5 }, true));
            //  should print [34, 24, 12, 9, 5]
            Console.ReadLine();
        }

        public static int[] Bubble (int[] input)
        {
            int temp = 0;
            for (int write = 0; write < input.Length; write++)
            {
                for (int sort = 0; sort < input.Length - 1; sort++)
                {
                    if (input[sort] > input[sort + 1])
                    {
                        temp = input[sort + 1];
                        input[sort + 1] = input[sort];
                        input[sort] = temp;
                    }
                }
            }
            return input;

        }
    }
}