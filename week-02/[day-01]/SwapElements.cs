using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = { "first", "second", "third" };

            string temp = abc[2];
            abc[2] = abc[0];
            abc[0] = temp;

            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine(abc[i]);
            }

            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            Console.ReadLine();
        }
    }
}