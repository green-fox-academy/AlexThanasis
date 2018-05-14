using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "kuty", "macsk", "cic" };
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Insert(array[i].Length, "a");
                Console.WriteLine(array[i]);
            }

            // - Create an array variable named `animals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end
            Console.ReadLine();
        }
    }
}