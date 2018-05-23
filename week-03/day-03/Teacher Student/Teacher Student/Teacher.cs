using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Student
{
    class Teacher
    {
        public string studyField = "Math";
        public string name;

        public Teacher()
        {
            name = "";
        }
        public Teacher(string name)
        {
            this.name = name;
        }

        public void Teach(Student student, Teacher teacher)
        {
            Console.WriteLine("Teaching is in progress");
            student.Question(student, teacher);
        }
        public void Answer(Student student)
        {
            student.Learn();
        }
        public string GetName
        {
            get
            {
                return name;
            }
        }
    }
}
