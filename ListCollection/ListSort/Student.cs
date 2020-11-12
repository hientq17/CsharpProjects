using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ListSort {

    class Student : IComparable<Student>
    {
        private int id;
        private string name;
        private string course;
        private double mark;

        public Student(int id, string name, string course, double mark)
        {
            this.Id = id;
            this.Name = name;
            this.Course = course;
            this.Mark = mark;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Course { get => course; set => course = value; }
        public double Mark { get => mark; set => mark = value; }

        public int CompareTo([AllowNull] Student std)
        {
            return this.Mark.CompareTo(std.Mark);
        }
    }
}