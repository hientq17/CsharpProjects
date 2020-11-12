using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace Lab01_extra_exercise4
{
    abstract class Person
    {
        private string position;
        private int workDays;
        private float salaryLevel;
        private string name;
        private string dob;
        private string diploma;

        protected Person(string name, string dob, string diploma, string position)
        {
            this.Name = name;
            this.Dob = dob;
            this.Diploma = diploma;
            this.Position = position;
        }

        protected Person(string name, string dob, string diploma, string position, int workDays, float salaryLevel) : this(name, dob, diploma, position)
        {
            this.WorkDays = workDays;
            this.SalaryLevel = salaryLevel;
        }

        protected string Name { get => name; set => name = value; }
        protected string Dob { get => dob; set => dob = value; }
        protected string Diploma { get => diploma; set => diploma = value; }
        protected string Position { get => position; set => position = value; }
        protected int WorkDays { get => workDays; set => workDays = value; }
        protected float SalaryLevel { get => salaryLevel; set => salaryLevel = value; }

        public abstract string Information();
    }
}
