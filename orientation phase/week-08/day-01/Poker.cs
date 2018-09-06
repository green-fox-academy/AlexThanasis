using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoJo
{
    public class Poker
    {
        public List<int[]> cardSet = new List<int[]>();
        
        public int ValueConverter(string input)
        {
            int output = -1;
            if (input.Contains("T") || input.Contains("J") || input.Contains("Q") ||
                input.Contains("K") || input.Contains("A"))
            {
                return TransformToInt(input);
            }
            else if (Int32.Parse(input) < 10)
            {
                return Int32.Parse(input);
            }
            else
            {
                return output;
            }
        }

        public int TransformToInt(string input)
        {
            int output = -1;
            switch (input.Trim())
            {
                case "T":
                    output = 10;
                    break;
                case "J":
                    output = 11;
                    break;
                case "Q":
                    output = 12;
                    break;
                case "K":
                    output = 13;
                    break;
                case "A":
                    output = 14;
                    break;
                default:
                    break;
            }
            return output;
        }
        public int[] CardSplitter(string input)
        {
            string[] inputSplit = input.Split();
            int kind = 0;
            switch (input.Substring(1))
            {
                case "D":
                    kind = 1;
                    break;
                case "H":
                    kind = 2;
                    break;
                case "C":
                    kind = 3;
                    break;
                case "S":
                    kind = 4;
                    break;
                default:
                    break;
            }
            int[] output = { ValueConverter(input.Substring(0,1)), kind };
            return output;
        }

        public string GetWhoWins(string result1, string result2)
        {
            return "";
        }

        public int ConvertCases(List<int[]> input)
        {
            if (IsRoyalFlush(input))
            {
                return 1;
            }
            else if (IsStraightFlush(input))
            {
                return 2;
            }
            else if (IsFourOfAKind(input))
            {
                return 3;
            }
            else if (IsFullHouse(input))
            {
                return 4;
            }
            else if (IsFlush(input))
            {
                return 5;
            }
            else if (IsStraight(input))
            {
                return 6;
            }
            else if (IsThreeOfAKind(input))
            {
                return 7;
            }
            else if (IsTwoPair(input))
            {
                return 8;
            }
            else if (IsOnePair(input))
            {
                return 9;
            }
            else if (IsHighCard(input))
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }

        public bool IsHighCard(List<int[]> input)
        {
            return false;
        }

        public bool IsOnePair(List<int[]> input)
        {
            throw new NotImplementedException();
        }

        private bool IsTwoPair(List<int[]> input)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(List<int[]> input)
        {
            throw new NotImplementedException();
        }

        public bool IsStraight(List<int[]> input)
        {
            throw new NotImplementedException();
        }

        private bool IsFlush(List<int[]> input)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(List<int[]> input)
        {
            int findCounter1 = 0, findCounter2 = 0, findCounter3 = 0, findCounter4 = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[0][0] == input[i][0])
                {
                    findCounter1++;
                }
                if (input[0][0] != input[i][0])
                {
                    findCounter2 = input[i][0];
                }
            }
            for (int i = 0; i < input.Count; i++)
            {
                if (input[0][0] == input[i][0])
                {
                    findCounter2++;
                }
            }
            if (findCounter1 > 3 || findCounter2 > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFourOfAKind(List<int[]> input)
        {
            int findCounter1 = 0, findCounter2= 0, findCounter3 = 0, findCounter4 = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i][1] == 1)
                {
                    findCounter1++;
                }
                else if (input[i][1] == 2)
                {
                    findCounter2++;
                }
                else if (input[i][1] == 3)
                {
                    findCounter3++;
                }
                else
                {
                    findCounter4++;
                }
            }
            if (findCounter1 > 3 || findCounter2 > 3 || findCounter3 > 3 || findCounter4 > 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStraightFlush(List<int[]> input)
        {
            if (IsOneKind(input) && (input[0][0] > 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsRoyalFlush(List<int[]> input)
        {
            if (IsOneKind(input) && (input[0][0] == 14))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsOneKind(List<int[]>input)
        {
            bool isOneKind = false;
            for (int i = 0; i < input.Count -1; i++)
            {
                if (input[i][1] != input[i + 1][1])
                {
                    isOneKind = false;
                }
                else
                {
                    isOneKind = true;
                }
            }
            return isOneKind;
        }
    }
}
