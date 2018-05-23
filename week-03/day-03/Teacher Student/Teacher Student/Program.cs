using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentFirst = new Student("Stan");
            Student studentSecond = new Student("Kyle");
            Teacher teacherFirst = new Teacher("Victoria Principal");
            Teacher teacherSecond = new Teacher("Mr. Garrison");
            Console.WriteLine("Meanhwile somewhere in Colorado");
            Console.WriteLine(teacherFirst.GetName + ": Do You know Classes and Objects? \n" + studentFirst.GetName + " :" 
                + studentFirst.GetKnowledge + "\n" + studentSecond.GetName + ": " + studentSecond.GetKnowledge );
            teacherFirst.Teach(studentFirst, teacherFirst);
            Console.WriteLine("And now have You studied? \n" + studentFirst.GetName + ": " + studentFirst.GetKnowledge);
        }
    }
}
