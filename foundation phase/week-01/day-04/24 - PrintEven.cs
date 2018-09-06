using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            //24
            Console.WriteLine("Printing out all of the even numbers from 0 to 500");
            for (int i = 1; i < 501; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            

            Console.ReadLine();
            // Create a program that prints all the even numbers between 0 and 500
        }
    }
}