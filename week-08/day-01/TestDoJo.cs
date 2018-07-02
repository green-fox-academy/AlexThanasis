using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoJo;

namespace TestDoJo
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestSample()
        {
            Assert.Pass();
        }

        Poker poker = new Poker();

        [Test]
        public void TestingTransformToInt()
        {
            string input = "J";
            int expectedValue = 11;
            int output = poker.TransformToInt(input);
            Assert.AreEqual(expectedValue, output);
        }

        [Test]
        public void TestingValueConverter()
        {
            string input = "J";
            int expectedValue = 11;
            int output = poker.ValueConverter(input);
            Assert.AreEqual(expectedValue, output);
        }

        [Test]
        public void TestingCardSplitter()
        {
            string input = "7D";
            int[] expectedValue = { 7, 1 } ;
            int[] output = poker.CardSplitter(input);
            Assert.AreEqual(expectedValue, output);
        }

        [Test]
        public void TestingWhoWins()
        {
            string result1 = "Royal Flush";
            string result2 = "Straight Flush";
            string output = poker.GetWhoWins(result1, result2);
            string testInput = "White Wins";
            Assert.AreEqual(output, testInput);
        }

        [Test]
        public void TestingIsOneKind()
        {
            List<int[]> filledCardSetForTest = new List<int[]>();
            filledCardSetForTest.Add(new int[]{ 14, 2});
            filledCardSetForTest.Add(new int[] { 13, 2 });
            filledCardSetForTest.Add(new int[] { 12, 2 });
            filledCardSetForTest.Add(new int[] { 11, 2 });
            filledCardSetForTest.Add(new int[] { 10, 2 });

            var output = poker.IsOneKind(filledCardSetForTest);
            bool expectedOutput = true;
            Assert.AreEqual(output, expectedOutput);
        }

        [Test]
        public void TestingIsRoyalFlush()
        {
            List<int[]> filledCardSetForTest = new List<int[]>();
            filledCardSetForTest.Add(new int[] { 14, 2 });
            filledCardSetForTest.Add(new int[] { 13, 2 });
            filledCardSetForTest.Add(new int[] { 12, 2 });
            filledCardSetForTest.Add(new int[] { 11, 2 });
            filledCardSetForTest.Add(new int[] { 10, 2 });

            var output = poker.IsRoyalFlush(filledCardSetForTest);
            bool expectedOutput = true;
            Assert.AreEqual(output, expectedOutput);
        }

        [Test]
        public void TestingIsStraigthFlush()
        {
            List<int[]> filledCardSetForTest = new List<int[]>();
            filledCardSetForTest.Add(new int[] { 14, 2 });
            filledCardSetForTest.Add(new int[] { 13, 2 });
            filledCardSetForTest.Add(new int[] { 12, 2 });
            filledCardSetForTest.Add(new int[] { 11, 2 });
            filledCardSetForTest.Add(new int[] { 4, 2 });

            var output = poker.IsStraightFlush(filledCardSetForTest);
            bool expectedOutput = true;
            Assert.AreEqual(output, expectedOutput);
        }

        [Test]
        public void TestingIsFourOfAKind()
        {
            List<int[]> filledCardSetForTest = new List<int[]>();
            filledCardSetForTest.Add(new int[] { 14, 2 });
            filledCardSetForTest.Add(new int[] { 13, 2 });
            filledCardSetForTest.Add(new int[] { 12, 2 });
            filledCardSetForTest.Add(new int[] { 11, 1 });
            filledCardSetForTest.Add(new int[] { 4, 2 });

            var output = poker.IsFourOfAKind(filledCardSetForTest);
            bool expectedOutput = true;
            Assert.AreEqual(output, expectedOutput);
        }
    }
}
