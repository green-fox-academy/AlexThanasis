using System;
using System.Collections.Generic;

namespace green_fox
{
    class Program
    {
        static void Main(string[] args)
        {
            Student jane = new Student("Jane", 67, "Female", "Something");

            jane.Introduce();

            Student john = (Student)jane.Clone();

            john.Introduce();


            Console.ReadLine();
        }
    }
}
