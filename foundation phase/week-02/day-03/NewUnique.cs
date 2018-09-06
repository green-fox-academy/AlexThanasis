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
            Console.WriteLine(CountLines(path));
            string[] urlArray = new string[500];
            urlArray = GetUniqueIPAddresses(path);
            foreach (var item in urlArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------");

            urlArray = GetUniqueIP(path);
            foreach (var item in urlArray)
            {
                Console.WriteLine(item);
            }

            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.

            Console.ReadLine();
        }

        public static int CountLines(string input)
        {
            int numberOfLines = 0;

            try
            {
                StreamReader sr = new StreamReader(input);
                while (sr.ReadLine() != null)
                {
                    numberOfLines++;
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

        public static string[] GetUniqueIP (string input)
        {
            string[] resultArray = new string[200];
            try
            {
                string lines = "";
                StreamReader sr = new StreamReader(input);
                while (lines != null)
                {
                    int i = 0;
                    lines = sr.ReadLine();
                    if (lines != null)
                    {
                        resultArray[i] = lines.Substring(27, 11);
                    }
                    i++;
                }
                sr.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ooops, could not read the file");
                Console.WriteLine(e.Message);
            }
            List<String> addresses = new List<string>();

            foreach (var item in resultArray)
            {
                if (!addresses.Contains(item))
                {
                    addresses.Add(item);
                }
            }

            return addresses.ToArray();
        }


        public static string[] Unique(string[] inputArray)
        {
            
            List<String> addresses = new List<string>();

            foreach (var item in inputArray)
            {
                if (!addresses.Contains(item))
                {
                    addresses.Add(item);
                }
            }
            
            string[] uniqueResultsArray = new string[addresses.Count];
            for (int i = 0; i < addresses.Count; i++)
            {
                uniqueResultsArray[i] = addresses[i];
            }
            return uniqueResultsArray;
        }

        public static string[] GetUniqueIPAddresses(string input)
        {
            string[] resultArray = new string[CountLines(input)];
            try
            {   
                string lines = "";
                StreamReader sr = new StreamReader(input);
                while (lines != null)
                {
                    int i = 0;
                    lines = sr.ReadLine();
                    if (lines != null)
                    {
                        resultArray[i] = lines.Substring(27, 11);
                    }
                    i++;
                }
                sr.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ooops, could not read the file");
                Console.WriteLine(e.Message);
            }
           return Unique(resultArray);
            
        }
        /*
        public static string[] UniqueIPs(string file1)
        {
            StreamReader reader = new StreamReader(file1);
            List<string> listOfUniqs = new List<string>();
            //int index = 0; //number of the uniq IPs
            string line = " ";
            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                {
                    if (listOfUniqs.Contains(line.Substring(27, 11)) != true)
                    {
                        listOfUniqs.Add(line.Substring(27, 11));
                        //index += 1; //number of the uniq IPs
                    }
                }
            }
            //Console.WriteLine(index); //number of the uniq IPs
            return listOfUniqs.ToArray();
        } */

    }
}