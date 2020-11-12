using System;
using System.Collections.Generic;
using System.Text;
using Lab01_extra_exercise3;

namespace Lab01_extra
{
    class Student:People
    {
        private int stdID;
        private float mark;
        public Student(int stdID, string name, int age, float mark):base(name,age)
        {
            this.StdID = stdID;
            this.Mark = mark;
        }

        public int StdID { get => stdID; set => stdID = value; }
        public float Mark { get => mark; set => mark = value; }

        public override string Information()
        {
            return " - Student ID: " + StdID
                + "\n - Student name: " + Name
                + "\n - Age: " + Age
                + "\n - Mark: " + Mark;
        }
    }
}
