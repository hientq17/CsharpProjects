using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab01_extra
{
    class Program
    {
        public static void Main()
        {
            ArrayList listStd;

            listStd = InputStudent();

            OutputStudent(listStd);
                
            Console.ReadLine();
        }

        public static ArrayList InputStudent() {
            //List<Student> listStd = new List<Student>();
            ArrayList listStd = new ArrayList();
            int n;
            Console.Write("Enter number of students: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n --- Input list of students --- ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n- Student {0}", i + 1);
                Console.Write(" Student ID: ");
                int stdId = int.Parse(Console.ReadLine());
                Console.Write(" Student name: ");
                string stdName = Console.ReadLine();
                Console.Write(" Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write(" Mark: ");
                float mark = float.Parse(Console.ReadLine());
                listStd.Add(new Student(stdId, stdName, age, mark));
                Console.WriteLine("\n ---------------------------------------- ");
            }
            return listStd;
        }

        public static void OutputStudent(ArrayList listStd) {
            Console.WriteLine("\n --- Output list of students ---");
            foreach (Student sv in listStd)
            {
                Console.WriteLine(sv.Information());
                Console.WriteLine("\n ---------------------------------------- ");
            }
        }

    }
}
