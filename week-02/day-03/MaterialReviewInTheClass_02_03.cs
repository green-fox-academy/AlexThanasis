using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            FirstSolution();
            Console.WriteLine("Give me one word");
            string userInput = Console.ReadLine();;
            WriteFirstSolution(userInput);
            SecondSolution();
            WriteSecondSolution(userInput);
            SecondSolution();

            Console.ReadLine();

        }
        
        public static void FirstSolution()
        {
            string data = "";
            StreamReader sr = new StreamReader("file.txt");
            while (data != null)
            {
                data = sr.ReadLine();
                if (data != null)
                {   
                    Console.WriteLine(data);
                }
                
            }
            sr.Dispose();
        }

        public static void SecondSolution()
        {
            Console.WriteLine(File.ReadAllText("file.txt"));
        }

        public static void WriteFirstSolution(string solution)
        {
            File.WriteAllText("file.txt", solution);
        }

        public static void WriteSecondSolution(string solution)
        {
            StreamWriter sw = new StreamWriter("file.txt");
            sw.WriteLine(solution);
            sw.Dispose();
        }
    }
}