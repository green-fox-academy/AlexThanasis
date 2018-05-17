using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DivideByZero
{
    public class DivideByZero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please give a number, ten will be divided with it");
            int number = Int32.Parse(Console.ReadLine());
            Divide(number);
            
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0

            Console.ReadLine();

        }

        public static void Divide (int number)
        {
            try
            {
                number = 10/ number;
                Console.WriteLine(number);
            }
            catch (DivideByZeroException dividedByZero)
            {
                Console.WriteLine("Hey man!!! \nWtf was that???\nDon't You know that we don't divide zero???");
                Console.WriteLine(dividedByZero.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ooop, something gone wrong!");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}