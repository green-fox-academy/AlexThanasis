using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the size of chess table? \n");
            int size = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the figure? \n");
            char figure = Char.Parse(Console.ReadLine());
            Console.WriteLine();

            bool evenRow = true;
            bool evenCol = true;

            for (int i = 0; i < size; i++)
            {
                
                for (int k = 0; k < size; k++)
                {
                    if (evenRow == false)
                    {
                        evenCol = !evenCol;
                    }
                    
                    if (evenCol == true)
                    {
                        Console.Write(" ") ;
                    }
                    else
                    {
                        Console.Write(figure);
                    }
                    evenCol = !evenCol;
                }
                evenRow = !evenRow;
                Console.WriteLine(" ");

            }
            Console.ReadLine();

            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
        }


    }



    
}