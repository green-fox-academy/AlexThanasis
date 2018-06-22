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
            Database.Adding("kvét venni", databaseObject);
            string[] commandInputs = argsFromConsoleReadline.Split(",");
            string[] commands = { "-a", "-m", "-l", "-r", "-c", "-e" };
            for (int i = 0; i < commandInputs.Length; i++)
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
                    Database.Removing(Int32.Parse(commandInputs[i + 1].Trim()), databaseObject);
                }
                if (commands.Any(element => element.Equals(commandInputs[i])))
                {
                    CommandFinder(commandInputs[i], databaseObject);
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

        public static void CommandFinder(string input, Database inputdb)
        {
            if (input.Equals("-l"))
            {
                Database.Loading(inputdb);
            }
        }
    }
}
