using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_extra_exercise4
{
    class Manager : Person { 

        public Manager(string name, string dob, string diploma, string position, int workDays, float salaryLevel) 
            : base(name, dob, diploma, "Manager", workDays, salaryLevel)
        { }

        public float MonthlySalary()
        {
            return SalaryLevel * WorkDays;
        }

        public override string Information()
        {
            return "--" + Position + "--"
                + "\n - Name: " + Name
                + "\n - Date of birth: " + Dob
                + "\n - Diploma: " + Diploma
                + "\n - Work days: " + WorkDays
                + "\n - Salary level: " + SalaryLevel
                + "\n - Monthly salary: " + MonthlySalary();
        }
    }
}
