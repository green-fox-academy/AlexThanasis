using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            //Doubling

            int baseNum = 123;
            Console.WriteLine(Doubling(baseNum));

            Console.ReadLine();

            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `doubling(baseNum)`

        }

        public static int Doubling (int inputNum)
        {
            return inputNum * 2;
        }



    }
}