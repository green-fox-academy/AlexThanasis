using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Console.WriteLine("\n~~~~~ The Magical Number Guessing Game ~~~~~\n");
            Console.WriteLine("Ladies and Gentleman, let me introduce to You our World famous Guessing Game!\n");
            bool newGame = true;
            do
            {

                Console.WriteLine("What is your name?\n");
                string userName = Console.ReadLine();
                Console.WriteLine("\nHello {0}", userName + ", I think on an integer number between 0 and 100. You must guess what is that number! \nDon't worry I'll help!\n");
                int number = r.Next(0, 101);
                bool round = true;


                do
                {

                    Console.WriteLine("Guess a number between 0 and 100!");
                    int guess = Int32.Parse(Console.ReadLine());
                    if (number == guess)
                    {
                        Console.WriteLine("\n ~~~ Coooongratulations, You won! ~~~ \n");
                        round = false;
                    }
                    else if (number < guess)
                    {
                        Console.WriteLine("The number is lower!");
                    }
                    else
                    {
                        Console.WriteLine("The number is higher!");
                    }

                } while (round);


                bool questionNewGame = true;
                do
                {
                    Console.WriteLine("Do You want a new game? Please press 'y' or 'n'!");
                    char newGameChar = Char.Parse(Console.ReadLine());

                    if (newGameChar == 'y')
                    {
                        newGame = true;
                        questionNewGame = false;
                    }
                    else if (newGameChar == 'n')
                    {
                        newGame = false;
                        questionNewGame = false;
                    }
                    else
                    {
                        questionNewGame = true;
                    }
                } while (questionNewGame);

            } while (newGame);

            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8
        }
    }
}