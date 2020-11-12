using System;
using MyBookLibrary;
namespace MyBookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Book Library Management---");
            GUI();
        }

        public static void GUI()
        {
            BookManagement manager = new BookManagement();
            InitData(manager);
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"===== Book Libary Management =====");
                Console.WriteLine("1. Add new book");
                Console.WriteLine("2. Update a book");
                Console.WriteLine("3. Delete a book");
                Console.WriteLine("4. List all book");
                Console.WriteLine("5 Quit");
                int choice = Validator.InputIntNumberRange("Enter your choice", 1, 11);
                switch (choice)
                {
                    case 1: manager.AddBook(); Console.ReadLine(); break;
                    case 2: manager.UpdateBook(); Console.ReadLine(); break;
                    case 3: manager.DeleteBook(); Console.ReadLine(); break;
                    case 4: Console.Clear(); manager.ListBook(); Console.ReadLine(); break;
                    case 5: return;
                }
            }
        }

        public static void InitData(BookManagement manager) {
            manager.AddBook(new Book(1, "Java for beginning", "FPT", 1000));
            manager.AddBook(new Book(2, "Web Design for everybody", "Coursera", 600));
            manager.AddBook(new Book(3, "Software Testing", "FPT", 900));
            manager.AddBook(new Book(4, "Japanese Learning", "FPT", 800));
            manager.AddBook(new Book(5, "Software Requirement", "FPT", 950));
        }
    }
}
