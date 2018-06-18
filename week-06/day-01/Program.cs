using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 Write a LINQ Expression to get the even numbers from the following array:
            Console.WriteLine("Exercise 1");
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            List<int> evenNumbersOfTheArray = (from number in n
                                                     where number % 2 == 0
                                                     orderby number ascending
                                                     select number).ToList();
            foreach (var item in evenNumbersOfTheArray)
            {
                Console.WriteLine(item);
            }

            IEnumerable<int> evenNumbersOfTheArray2 = n.Where(x => x % 2 == 0).OrderBy(x => x);
            foreach (var item in evenNumbersOfTheArray2)
            {
                Console.WriteLine(item);
            }

            //Exercise 2 Write a LINQ Expression to get the average value of the odd numbers from the following array:
            Console.WriteLine("Exercise 2");
            int[] n2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var averageOfIntArray = (from num in n2
                                    where num % 2 == 0
                                    select num).Average();
            Console.WriteLine(averageOfIntArray);

            var averageOfIntArray2 = n2.AsQueryable().Average();
            Console.WriteLine(averageOfIntArray2);

            //Exercise 3 Write a LINQ Expression to get the squared value of the positive numbers from the following array:
            Console.WriteLine("Exercise 3");
            int[] n3 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squaresOfTheList = from num in n3
                                   where num > 0
                                   select num * num;
            foreach (var item in squaresOfTheList)
            {
                Console.WriteLine(item);
            }

            var squaresOfTheList2 = n3.Where(x => (x > 0)).Select( x => x * x );
            foreach (var item in squaresOfTheList2)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(squaresOfTheList.GetType());

            //Exercise 4 Write a LINQ Expression to find which number squared value is more then 20 from the following array:
            Console.WriteLine("Exercise 4");
            int[] n4 = new[] { 3, 9, 2, 8, 6, 5 };
            var squaresOfTheListWhichSquaredValueIsBiggerThen20 = from num in n4
                                                                  where num * num > 20
                                                                  select num * num;
            foreach (var item in squaresOfTheListWhichSquaredValueIsBiggerThen20)
            {
                Console.WriteLine(item);
            }

            var squaresOfTheListWhichSquaredValueIsBiggerThen20_2 = n4.Where(x => x * x > 20).Select(x => x * x);
            foreach (var item in squaresOfTheListWhichSquaredValueIsBiggerThen20_2)
            {
                Console.WriteLine(item);
            }

            //Exercise 5 Write a LINQ Expression to find the frequency of numbers in the following array:
            Console.WriteLine("Exercise 5");
            int[] n5 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            Dictionary<int, int> numFreq = (from num in n5
                                            orderby num
                                            group num by num into freq
                                            select freq).ToDictionary(x => x.Key, x => x.ToList().Count);
            foreach (var item in numFreq)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            numFreq.ToList().ForEach(x => Console.WriteLine($"number: {x.Key}, frequency: {x.Value}"));

            //var freqInTheIntArray = n5.AsQueryable()

            //Exercise 6 Write a LINQ Expression to find the frequency of characters in a given string!
            Console.WriteLine("Exercise 6");
            string testStringForLetterCounting = "absgdlkedlgmdgreiogrgregksmdsdwghiuwfnsnak";
            Dictionary<char, int> charFreq = (from character in testStringForLetterCounting
                                             group character by character into freq
                                             select freq).ToDictionary(x =>
                                             x.Key, x =>x.ToList().Count);
            foreach (var item in charFreq)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            //another way to write out
            charFreq.ToList().ForEach(p => Console.WriteLine($"char: {p.Key}, value {p.Value}"));

            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            testStringForLetterCounting.ToList().ForEach(item =>
            {
                if (keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs[item] += 1;
                }
                else
                {
                    keyValuePairs[item] = 1;
                }
            }
            );

            //Exercise 7 Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
            Console.WriteLine("Exercise 7");
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var citiesThatStartsWithAEndsWithI = from city in cities
                                                 where city.ToString().StartsWith("A") && city.ToString().EndsWith("I")
                                                 select city;
            foreach (var item in citiesThatStartsWithAEndsWithI)
            {
                Console.WriteLine(item);
            }

            var citiesThatStartsWithAEndsWithI2 = cities.Where(city => city.ToString().StartsWith("A") && city.ToString().EndsWith("I"));
            foreach (var item in citiesThatStartsWithAEndsWithI2)
            {
                Console.WriteLine(item);
            }

            //Exercise 8 Write a LINQ Expression to find the uppercase characters in a string!
            Console.WriteLine("Exercise 8");
            string testString = "lalalaLa";
            var indexOfUpperCaseInAString = from s in testString
                                            where s.ToString().Equals(s.ToString().ToUpper())
                                            select s;
            foreach (var item in indexOfUpperCaseInAString)
            {
                Console.WriteLine(item);
            }

            var indexOfUpperCaseInAString2 = testString.Where(s => s.ToString().Equals(s.ToString().ToUpper()));
            indexOfUpperCaseInAString2.ToList().ForEach(x => Console.WriteLine(x));

            //Exercise 9 Write a LINQ Expression to convert a char array to a string!
            Console.WriteLine("Exercise 9");
            char[] charArray = { 'a', 'z', ' ', 'a', 'l', 'm', 'a' };
            var charArrayToString = (from c in charArray
                                    group c by c into charAr
                                    select charAr).ToArray();
            foreach (var item in charArrayToString)
            {
                Console.WriteLine(item);
            }

            var charArrayToString2 = string.Join("", Array.ConvertAll(charArray, x => x.ToString())) ;
            var charArrayToString3 = string.Concat(charArray.Select(x => x.ToString()));
            Console.WriteLine(charArrayToString2 + "\n" + charArrayToString3);

            //Exercise 10 Create a Fox class with 3 properties(name, type, color) 
            //Fill a list with at least 5 foxes, it's up to you how you name/create them! 
            Console.WriteLine("Exercise 10");

            List<Fox> FleetOfFoxes = new List<Fox>();
            FleetOfFoxes.Add(new Fox("Vuk", "Common", "Red" ));
            FleetOfFoxes.Add(new Fox("Maestro", "Pallida", "Green"));
            FleetOfFoxes.Add(new Fox("Tony", "Pallida", "Red"));
            FleetOfFoxes.Add(new Fox("Anna", "Common", "Green"));
            FleetOfFoxes.Add(new Fox("Rocky", "Fulvipes", "Green"));

            //Write a LINQ Expression to find the foxes with green color! 

            var listOfGreenColoredFoxes = from fox in FleetOfFoxes
                                          where fox.Color == "Green"
                                          select fox.Name;
            listOfGreenColoredFoxes.ToList().ForEach(fox => Console.WriteLine(fox));

            var listOfGreenColoredFoxes2 = FleetOfFoxes.Where(fox => fox.Color == "Green").Select(fox => fox.Name);
            listOfGreenColoredFoxes2.ToList().ForEach(fox => Console.WriteLine(fox));

            //Write a LINQ Expression to find the foxes with green color and pallida type!

            var listOfGreenColoredPallidaFoxes = from fox in FleetOfFoxes
                                          where fox.Color == "Green" && fox.Type =="Pallida"
                                          select fox.Name;
            listOfGreenColoredPallidaFoxes.ToList().ForEach(fox => Console.WriteLine(fox));

            var listOfGreenColorePallidaFoxes2 = FleetOfFoxes.Where(fox => fox.Color.Equals("Green") && fox.Type.Equals("Pallida")).Select(fox => fox.Name);
            listOfGreenColorePallidaFoxes2.ToList().ForEach(fox => Console.WriteLine(fox));


            Console.ReadLine();
        }
    }
}
