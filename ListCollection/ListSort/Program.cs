using System;
using System.Collections.Generic;

namespace ListSort
{
    class Program
    {
        static List<Student> inputData()
        {
            int check;
            List<Student> listStd = new List<Student>();
            listStd.Add(new Student(1, "Hien", "IT", 8.5));
            listStd.Add(new Student(2, "Long", "IT", 7.9));
            listStd.Add(new Student(3, "Son", "IT", 8.1));
            listStd.Add(new Student(4, "Giang", "GD", 8.4));
            listStd.Add(new Student(5, "Go", "GD", 7.5));
            listStd.Add(new Student(6, "Van", "GD", 7.2));
            listStd.Add(new Student(7, "Tin", "IT", 8.5));
            listStd.Add(new Student(8, "Huy", "IT", 7.9));
            listStd.Add(new Student(9, "Hung", "IT", 8.1));
            return listStd;
        }
        static void outputData(List<Student> listStd)
        {
            foreach (Student std in listStd)
            {
                Console.WriteLine("Student " + std.Id);
                Console.WriteLine(" - Name: " + std.Name);
                Console.WriteLine(" - Course: " + std.Course);
                Console.WriteLine(" - Mark: " + std.Mark);
            }
        }

        static void Main(string[] args)
        {
            List<Student> listStd = inputData();
            Console.WriteLine("Before sorting");
            outputData(listStd);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("After sorting by IComparable");
            listStd.Sort();
            outputData(listStd);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("After sorting by NameComparer");
            listStd.Sort(new NameComparer());
            outputData(listStd);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("After sorting by MarkComparer");
            listStd.Sort(new MarkComparer());
            outputData(listStd);
        }
    }
}
