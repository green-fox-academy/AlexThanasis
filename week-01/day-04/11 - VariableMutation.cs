using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Variable mutations. Let's see them below! \n");
            Console.WriteLine("make it bigger by 10");
            int a = 3;
            a += 10;
            Console.WriteLine(a);
           

            Console.WriteLine("make it smaller by 7");
            int b = 100;
            b -= 7;
            

            Console.WriteLine(b);

            Console.WriteLine("please double c's value");
            int c = 44;
            c *= 2;
            Console.WriteLine(c);


            Console.WriteLine("please divide by 5 d's value");
            int d = 125;
            d /= 5;
            Console.WriteLine(d);


            Console.WriteLine("please cube of e's value");
            int e = 8;
            e *= (e * e);
            Console.WriteLine(e);


            Console.WriteLine("tell if f1 is bigger than f2(print as a boolean)");
            int f1 = 123;
            int f2 = 345;
            bool higher = f1 > f2;
            Console.WriteLine(higher);

            
            Console.WriteLine("tell if the double of g2 is bigger than g1 (print as a boolean)");
            int g1 = 350;
            int g2 = 200;
            bool bigger = g2 * 2 > g1;
            Console.WriteLine(bigger);
 

            Console.WriteLine("tell if it has 11 as a divisor (print as a boolean)");
            long h = 1357988018575474;
            long mod = h % 11;
            bool isDivisor = mod == 0;
            Console.WriteLine("Is eleven a divisor of the number (1357988018575474)? : " + isDivisor );

         
            Console.WriteLine("tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)");
            int i1 = 10;
            int i2 = 3;
            bool isHigher = i1 > Math.Pow(i2, 2) && i1 < Math.Pow(i2, 3);
            Console.WriteLine(isHigher);


            Console.WriteLine("tell if j is dividable by 3 or 5(print as a boolean)");
            int j = 1521;
            bool isDividor = (j % 3 == 0 || j % 5 == 0);

            Console.WriteLine("fill the k variable with its cotnent 4 times");
            string k = "Apple";
            k = k + k + k + k;
            Console.WriteLine(k);

            Console.ReadLine();
        }
    }
}