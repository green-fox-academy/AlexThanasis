using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            //32

            Console.WriteLine("What is the length if a side of the square with a diagonal?");

            int length = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                if (i == 0 || i == length)
                {
                    for (int k = 0; k < length; k++)
                    {
                        Console.Write("%");
                    }
                    Console.WriteLine();
                }

                for (i = 1; i < length - 1; i++)
                {
                    Console.Write("%");
                    for (int l = 1; l < length - 1; l++)
                    {
                        if (i == l)
                        {
                            Console.Write("%");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    }
                    Console.Write("%");
                    Console.WriteLine();
                }
            }
           
            for (int k = 0; k < length; k++)
            {
                Console.Write("%");
            }
            

            Console.ReadLine();

            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was
        }
    }
}