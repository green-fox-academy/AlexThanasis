using System;
using System.Collections.Generic;
using System.Text;

namespace green_fox
{
    class Student : Person, ICloneable
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }
        public Student()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            previousOrganization = "The School of Life";
            skippedDays = 0;
            Clone();
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.", name, age, gender, previousOrganization, skippedDays);
        }

        public int SkipDays(int numberOfDays)
        {
            return skippedDays += numberOfDays;
        }

        public void Clone()
        {
                name = "John";
                age = 20;
                gender = "male";
                previousOrganization = "BME";
                skippedDays = 0;
        }
    }
}
