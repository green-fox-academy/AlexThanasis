using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            //26

            int num1, num2;
            Console.WriteLine("Please, give me two numbers: ");
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());

            while (num1 > num2) { 
                Console.WriteLine("The second number should be bigger! \nPlease, give me two numbers again: ");
                    num1 = Int32.Parse(Console.ReadLine());
                    num2 = Int32.Parse(Console.ReadLine());
                                } 
            for (int i = num1; i < num2; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();

            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
        }
    }
}