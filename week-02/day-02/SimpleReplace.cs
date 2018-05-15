using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            string example = "In a dishwasher far far away";

            //example.replace("dishwasher", "galaxy");

            example = example.Replace("dishwasher", "galaxy");
            Console.WriteLine(example);

            // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away
            Console.ReadLine();

        }
    }
}