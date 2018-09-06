using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CopyFile
{
    public class CopyFile
    {
        public static void Main(string[] args)
        {
            string input = "my-file.txt";
            Console.WriteLine(CopyFileLines(input));
            Console.WriteLine(File.ReadAllText("file.txt").ToString());

            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            Console.ReadLine();
        }

        public static bool CopyFileLines (string input)
        {
            try
            {
                File.WriteAllText("file.txt", File.ReadAllText(input));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ooops, could not read the file");
                Console.WriteLine(e.Message);
                return false;
            }

        }

    }
}