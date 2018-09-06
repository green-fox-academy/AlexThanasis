using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //21
            int numOfGirlz, numOfBoyz;

            Console.WriteLine("Hello there! \n Greeting at the party! Let's count the number of girlz!");
            numOfGirlz = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Now, let's count the number of boyz!");
            numOfBoyz = Int32.Parse(Console.ReadLine());

            int peopleKind = numOfGirlz + numOfBoyz;
            float ratioOfGirlz = (float)numOfGirlz / peopleKind;
            if (peopleKind >= 20)
            {
                if (ratioOfGirlz >= 0.40 && ratioOfGirlz <= 0.60)
                {
                    Console.WriteLine("The party is exellent!");
                }
                else if ((ratioOfGirlz < 0.40 && ratioOfGirlz > 0.01) || (ratioOfGirlz > 0.60))
                {
                    Console.WriteLine("Quite cool party!");
                }
                else
                {
                    Console.WriteLine("Sausage party!");
                }
            }
            else
            {
                Console.WriteLine("Average party!");
            }
            

            Console.ReadLine();
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
        }
    }
}