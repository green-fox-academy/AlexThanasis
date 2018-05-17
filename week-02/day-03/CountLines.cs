using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PrintEachLine
{
    public class PrintEachLine
    {
        public static void Main(string[] args)
        {
            string input = "my-file.txt";
            Console.WriteLine(CountLines(input));

            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            
            Console.ReadLine();
        }

        public static int CountLines (string input)
        {
            int numberOfLines = 0;
            string textData = "";
            try
            {
                StreamReader sr = new StreamReader(input);
                while (textData != null)
                {
                    textData = sr.ReadLine();
                    if (textData != null)
                    {
                        numberOfLines++;
                        Console.WriteLine(textData);
                    }
                }
                sr.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ooops, could not read the file");
                Console.WriteLine(e.Message);
            }

            return numberOfLines;
        }

    }
}