using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[4, 4];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        array[i, j] = 1;
                    }
                   /* else
                    {
                        array[i, j] = 0;
                    }*/
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            Console.ReadLine();
        }
    }
}