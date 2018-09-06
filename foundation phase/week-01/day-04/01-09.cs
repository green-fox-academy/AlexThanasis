using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Hello Alex!" + "\n");

            //2
           
            // Modify this program to print Humpty Dumpty riddle correctly
            Console.WriteLine("All the king's horses and all the king's men");
            Console.WriteLine("Humpty Dumpty had a great fall.");
            Console.WriteLine("Humpty Dumpty sat on a wall,");
            Console.WriteLine("Couldn't put Humpty together again.");
            
            Console.WriteLine("Correct version: \nHumpty Dumpty sat on a wall,\nHumpty Dumpty had a great fall.\nAll the king's horses and all the king's men\nCouldn't put Humpty together again.");
            


            //3
            Console.WriteLine("Hello Péter!");
            Console.WriteLine("Hello Andris!");
            Console.WriteLine("Hello Anna!" + "\n");

            //4
            Console.WriteLine("Alex");
            Console.WriteLine("32");
            Console.WriteLine("1.76" + "\n");

            //5
            int num1 = 22, num2 = 13;
            int add = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;
            float divFraction = (float)num1 / num2;
            int mod = num1 % num2;
            Console.WriteLine(add + "\t" + sub + "\t" + mul + "\t" + div + "\t" + divFraction + "\t" + mod + "\n");

            //6
            Console.WriteLine("An average Green Fox attendee codes 6 hours daily and the semester is 17 weeks long \n How many ours do we spend with coding average a workday?");
            int codingHours = 6, weeks = 17, workdays = 5, workHoursPerWeek = 52;
            int averageHoursCoding;

            averageHoursCoding = codingHours * weeks * workdays;
            Console.WriteLine("Hours is spent with coding in a semester by an attendee: " + averageHoursCoding);

            float percentageAverageHoursCoding = codingHours * workdays / (float)workHoursPerWeek;
            Console.WriteLine("The percentage of the coding hours in the semester if the average: " + percentageAverageHoursCoding + "\n");

            //7
            Console.WriteLine("What is your favourite number?");
            int favouriteNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your favourite number is: " + favouriteNumber + "\n");

            //8
            int a = 123;
            int b = 526;
            Console.WriteLine("Original variables and their values: \t a: \t" + a + "\t b: \t" + b + "\n");

            int a_temp = a;
            a = b;
            b = a_temp;
            Console.WriteLine("The variables and their swapped values: \t a: \t" + a + "\t b: \t" + b + "\n");

            //9
            double massInKg = 81.2;
            double heightInM = 1.78;
            double bmi = massInKg / (heightInM * heightInM);
            Console.WriteLine("His BMI is: " + bmi + "\n");

            Console.ReadLine();
        }
    }
}