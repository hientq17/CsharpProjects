using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_extra_exercise4
{
    class Scientist : Person
    {
        private int paper;

        public Scientist(string name, string dob, string diploma, string position, int workDays, float salaryLevel, int paper) 
            : base(name, dob, diploma, "Scientist", workDays, salaryLevel)
        {
            this.Paper = paper;
        }

        
        public float MonthlySalary()
        {
            return SalaryLevel * WorkDays;
        }
        public int Paper { get => paper; set => paper = value; }

        public override string Information()
        {
            return "--" + Position + "--"
                + "\n - Name: " + Name
                + "\n - Date of birth: " + Dob
                + "\n - Diploma: " + Diploma
                + "\n - Work days: " + WorkDays
                + "\n - Number of papers: " + Paper
                + "\n - Salary level: " + SalaryLevel
                + "\n - Monthly salary: " + MonthlySalary();
        }
    }
}
