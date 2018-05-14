using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 6;
            int factoredNum = Factorio(number);
            Console.WriteLine(factoredNum);

            Console.WriteLine();

            //another version
            Console.WriteLine(Factorio2(number));
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            Console.ReadLine();
        }

        public static int Factorio (int input)
        {
            if (input <= 1)
            {
                return 1;
            }
            else
            {
                return input * Factorio(input - 1);
            }
        }
        
        public static int Factorio2(int input)
        {
            if (input <= 1)
            {
                return 1;
            }
            else
            {
                int result = 1;
                int multiplicator = input;
                for (int i = input; i > 1; i--)
                {
                    result *= i;
                }
                return result;
            }
        }
    }
}