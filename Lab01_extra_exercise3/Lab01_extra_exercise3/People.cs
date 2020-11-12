using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace Lab01_extra_exercise3
{
    abstract class People
    {
        private String name;
        private int age;

        protected string Name { get => name; set => name = value; }
        protected int Age { get => age; set => age = value; }

        protected People(String name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public abstract string Information();
    }
}
