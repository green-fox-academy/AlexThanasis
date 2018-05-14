using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aj = { 3, 4, 5, 6, 7 };
            int[] temp_aj = new int[aj.Length];
            aj.CopyTo(temp_aj, 0);
            for (int i = 0; i < aj.Length; i++)
            {
                aj[i] = temp_aj[aj.Length - i - 1];
                Console.WriteLine(aj[i]);
            }

            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            Console.ReadLine();
        }
    }
}