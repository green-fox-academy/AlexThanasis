using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] s = new int[]
            {
                1, 2, 3, 8, 5, 6
            };
            
            int order = 3;
            int toChangeNum = 4;

            s[order] = toChangeNum;
            Console.WriteLine(s[order]);

            
            // - Create an array variable named `s`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element
            Console.ReadLine();
        }
    }
}