using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //15

            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int num3 = Int32.Parse(Console.ReadLine());
            int num4 = Int32.Parse(Console.ReadLine());
            int num5 = Int32.Parse(Console.ReadLine());
            int sum = num1 + num2 + num3 + num4 + num5;
            float average= (float)sum / 5;
            Console.WriteLine("sum: " + sum + " \naverage: " + average);

            Console.ReadLine();
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4


        }
    }
}