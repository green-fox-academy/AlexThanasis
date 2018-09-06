using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;

namespace TODO
{
    class Program
    {   
        static void Main(string[] args)
        {
            PrintIntro();
            Database databaseObject = new Database();
            string argsFromConsoleReadline = Console.ReadLine();
            string[] commandInputs = argsFromConsoleReadline.Split(",");
            Console.WriteLine(commandInputs.Length);
            string[] commands = { "-a", "-l", "-r", "-c", "-e" };
            for (int i = 0; i < commandInputs.Length; i++)
            {
                Console.WriteLine(commandInputs[i]);
                if (commands.Any(element => element.Equals(commandInputs[i])))
                {
                    if (commandInputs[i].Contains("-a"))
                    {
                        Database.Adding(commandInputs[i + 1], databaseObject);
                    }
                    if (commandInputs[i].Contains("-r"))
                    {
                        Database.Removing(Int32.Parse(commandInputs[i + 1].Trim()), databaseObject);
                    }
                    if (commandInputs[i].Contains("-c"))
                    {
                        Database.Complete(Int32.Parse(commandInputs[i + 1].Trim()), databaseObject);
                    }
                    if (commandInputs[i].Contains("-e"))
                    {
                        Database.Clear(databaseObject);
                    }
                    if (commandInputs[i].Contains("-l"))
                    {
                        Database.Loading(databaseObject);
                    }
                }
            }
            Console.ReadLine();
        }
        
        public static void PrintIntro()
        {
            string path = @"../../../files/printinfo.txt";
            string printIntroContent = File.ReadAllText(path);
            Console.WriteLine(printIntroContent);
        }
        
    }
}
