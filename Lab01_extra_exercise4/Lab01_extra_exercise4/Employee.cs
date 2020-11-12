using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_extra_exercise4
{
    class Employee : Person
    {
        private float monthlySalary;

        public Employee(string name, string dob, string diploma, string position, float monthlySalary) 
            : base(name, dob, diploma, "Employee")
        {
            this.MonthlySalary = monthlySalary;
        }

        public float MonthlySalary { get => monthlySalary; set => monthlySalary = value; }

        public override string Information()
        {
            return "--" + Position + "--"
                + "\n - Name: " + Name
                + "\n - Date of birth: " + Dob
                + "\n - Diploma: " + Diploma
                + "\n - Total salary: " + WorkDays * SalaryLevel;
        }
    }
}
