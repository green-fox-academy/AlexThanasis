using System;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            StringBuilder quoteSB = new StringBuilder(quote);
            quoteSB.Insert(quote.IndexOf('I') + 3 , "always takes longer than");
            quote = quoteSB.ToString(); 
            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            Console.WriteLine(quote);
            Console.ReadLine();
        }
    }
}