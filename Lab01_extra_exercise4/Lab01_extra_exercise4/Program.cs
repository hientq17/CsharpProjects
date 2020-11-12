using System;
using System.Collections;

namespace Lab01_extra_exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listData = InputData();
            OutputData(listData);
        }

        public static ArrayList InputData()
        {
            ArrayList listData = new ArrayList();
            int check;
            do
            {
                int choose;
                do
                {
                    Console.WriteLine("What type of position: ");
                    Console.WriteLine("1. Scientist ");
                    Console.WriteLine("2. Manager ");
                    Console.WriteLine("3. Employee");
                    Console.Write("Enter your choice: ");
                    choose = int.Parse(Console.ReadLine());
                } while (choose < 1 || choose > 3);
                switch (choose) {
                    case 1:
                        listData.Add(InputScientist());
                        break;
                    case 2:
                        listData.Add(InputManager());
                        break;
                    case 3:
                        listData.Add(InputEmployee());
                        break;
                }
                Console.Write("Enter 1 to contitue: ");
                check= int.Parse(Console.ReadLine());
            } while (check == 1);

            return listData;
        }

        public static Scientist InputScientist()
        {
            Console.WriteLine("-> Input scientist");
            Console.Write(" Name: ");
            String name = Console.ReadLine();
            Console.Write(" Date of birth: ");
            string dob = Console.ReadLine();
            Console.Write(" Diploma: ");
            string diploma = Console.ReadLine();
            Console.Write(" Word days: ");
            int wordDays = int.Parse(Console.ReadLine());
            Console.Write(" Number of paper: ");
            int paper = int.Parse(Console.ReadLine());
            Console.Write(" Salary level: ");
            float salaryLevel = float.Parse(Console.ReadLine());
            return new Scientist(name,dob,diploma,"Scientist",wordDays,salaryLevel, paper);
        }

        public static Manager InputManager()
        {
            Console.WriteLine("-> Input manager");
            Console.Write(" Name: ");
            String name = Console.ReadLine();
            Console.Write(" Date of birth: ");
            string dob = Console.ReadLine();
            Console.Write(" Diploma: ");
            string diploma = Console.ReadLine();
            Console.Write(" Word days: ");
            int wordDays = int.Parse(Console.ReadLine());
            Console.Write(" Salary level: ");
            float salaryLevel = float.Parse(Console.ReadLine());
            return new Manager(name, dob, diploma, "Scientist", wordDays, salaryLevel);
        }

        public static Employee InputEmployee()
        {
            Console.WriteLine("-> Input employee");
            Console.Write(" Name: ");
            String name = Console.ReadLine();
            Console.Write(" Date of birth: ");
            string dob = Console.ReadLine();
            Console.Write(" Diploma: ");
            string diploma = Console.ReadLine();
            Console.Write(" Monthly salary: ");
            float monthlySalary = float.Parse(Console.ReadLine());
            return new Employee(name, dob, diploma, "Scientist",monthlySalary);
        }

        public static void OutputData(ArrayList listStd)
        {
            Console.WriteLine("\n --- Output list of data ---");
            double scientistSalary = 0;
            double managerSalary = 0;
            double employeeSalary = 0;
            foreach (Object obj in listStd)
            {
                if (obj is Scientist) {
                    Scientist s = (Scientist)obj;
                    Console.WriteLine(s.Information());
                    scientistSalary += s.MonthlySalary();
                }
                if (obj is Manager) {
                    Manager m = (Manager)obj;
                    Console.WriteLine(m.Information());
                    managerSalary += m.MonthlySalary();
                }
                if (obj is Employee) {
                    Employee e = (Employee)obj;
                    Console.WriteLine(e.Information());
                    employeeSalary += e.MonthlySalary;
                }
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("Total salary of scientist: {0}",scientistSalary);
            Console.WriteLine("Total salary of manager: {0}", managerSalary);
            Console.WriteLine("Total salary of employee: {0}", employeeSalary);
            Console.WriteLine("----------------------------------------");
        }
    }
}
