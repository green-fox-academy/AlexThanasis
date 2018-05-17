using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logs
{
    public class Logs
    {
        public static void Main(string[] args)
        {
            
            string path = "log.txt";
            string[] urlArray = GetUniqueIP(path);
            foreach (var item in urlArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------");


            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.

            Console.ReadLine();
        }


        public static string[] GetUniqueIP (string input)
        {
            List<String> addresses = new List<string>();
            try
            {
                string lines = "";
                StreamReader sr = new StreamReader(input);
                while (lines != null)
                {
                    
                    lines = sr.ReadLine();
                    if (lines != null)
                    {
                        if (!addresses.Contains(lines.Substring(27, 11)))
                        {
                            addresses.Add(lines.Substring(27, 11));
                        }
                       
                    }
                }
                sr.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ooops, could not read the file");
                Console.WriteLine(e.Message);
            }
            return addresses.ToArray();
        }

        public static double GetRatio(string input)
        {
            try
            {
                string lines = "";
                StreamReader sr = new StreamReader(input);
                while (lines != null)
                {

                    lines = sr.ReadLine();
                    if (lines != null)
                    {
                        if (!addresses.Contains(lines.Substring(27, 11)))
                        {
                            addresses.Add(lines.Substring(27, 11));
                        }

                    }
                }
                sr.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ooops, could not read the file");
                Console.WriteLine(e.Message);
            }
        }

    }
}