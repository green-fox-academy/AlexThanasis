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
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"

            string path = "my-file.txt";
            string textData = "";
            try
            {
                StreamReader sr = new StreamReader(path);
                while (textData != null)
                {
                    textData = sr.ReadLine();
                    if (textData != null)
                    {
                        Console.WriteLine(textData);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ooops, could not read the file");
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();

        }

    }
}