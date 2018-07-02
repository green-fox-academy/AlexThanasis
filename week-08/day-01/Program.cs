using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoJo
{
    class Program
    {
        static void Main(string[] args)
        {
            Poker poker = new Poker();
            List<int[]> filledCardSetForTest = new List<int[]>();
            filledCardSetForTest.Add(new int[] { 11, 2 });
            filledCardSetForTest.Add(new int[] { 11, 1 });
            filledCardSetForTest.Add(new int[] { 12, 2 });
            filledCardSetForTest.Add(new int[] { 10, 4 });
            filledCardSetForTest.Add(new int[] { 12, 3 });

            poker.IsFullHouse(filledCardSetForTest);
            Console.WriteLine(poker.IsFullHouse(filledCardSetForTest));
            Console.ReadLine();
        }
    }
}
