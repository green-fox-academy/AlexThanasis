using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordOne = Console.ReadLine();
            string wordTwo = Console.ReadLine();

            Console.WriteLine(IsAnagram(wordOne, wordTwo)); 
            
            Console.ReadLine();
        }

        public static bool IsAnagram (string input1, string input2)
        {
            bool isAnagram = false;
            if (input1.Length != input2.Length)
            {
                return false;
            }
            for (int i = 0; i < input1.Length; i++)
            {
                if (char.ToLower(input2[i]) == char.ToLower(input1[input1.Length - i - 1]))
                {
                    isAnagram = true;
                }
                else
                {
                    isAnagram = false;
                    break;
                }
                   
            }
            return isAnagram;
        }

    }
}