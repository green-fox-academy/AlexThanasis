using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Student
{
    class Student
    {
        public bool study;
        public string name;

        public Student()
        {
            study = false;
        }
        public Student(string name)
        {
            this.name = name;
            study = false;
        }

        public void Learn()
        {
            study = true;
        }
        public void Question(Student student, Teacher teacher)
        {
            teacher.Answer(student);
        }
        public string GetName
        {
            get
            {
                return name;
            }
        }
        public bool GetKnowledge
        {
            get
            {
                return study;
            }
        }
    }
}

