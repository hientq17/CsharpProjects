using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise1_2
{
    class BookManager
    {
        private ArrayList bookList = new ArrayList();
        public void GUI()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Book Manager =====");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Show book");
                Console.WriteLine("3. Sort book by Year (using IComparable)");
                Console.WriteLine("4. Sort book by Title (using Comparer)");
                Console.WriteLine("5. Sort book by Author (using Comparer)");
                Console.WriteLine("6. Quit");
                int choice = Validator.InputIntNumberRange("Enter your choice ", 1, 6);
                switch (choice)
                {
                    case 1:Add(); break;
                    case 2:Console.Clear(); ListAll(); Console.ReadLine(); break;
                    case 3:SortByYear(); Console.ReadLine(); break;
                    case 4: SortByTitle(); Console.ReadLine(); break;
                    case 5: SortByAuthor(); Console.ReadLine(); break;
                    case 6:return;
                }
            }
        }
        public void Add()
        {
            Console.Clear();
            Console.WriteLine("===== Input Book =====");
            string Title = Validator.InputString(" - Title", "");
            string Author = Validator.InputString(" - Author", "");
            string Publisher = Validator.InputString(" - Publisher", "");
            string IBSN = Validator.InputString(" - IBSN","");
            int year = Validator.InputIntNumber(" - Year");
            ArrayList chapter = new ArrayList();
            do
            {
                string chap = Validator.InputString($"Input chapter {chapter.Count + 1} (Type 0 to quit)", "");
                if (chap == "0") break;
                chapter.Add(chap);
            } while (true);
            bookList.Add(new Book(Title,Author,Publisher,IBSN,year,chapter));
        }
        public void ListAll()
        {
            foreach (Book i in bookList)
            {
                i.Show();
            }
        }
        public void SortByYear()
        {
            Console.Clear();
            Console.WriteLine("===== Before Sort =====");
            ListAll();
            bookList.Sort();
            Console.WriteLine("===== After Sort =====");
            ListAll();
        }
        public void SortByTitle()
        {
            Console.Clear();
            Console.WriteLine("===== Before Sort =====");
            ListAll();
            bookList.Sort(new SortByTitle());
            Console.WriteLine("===== After Sort =====");
            ListAll();
        }
        public void SortByAuthor()
        {
            Console.Clear();
            Console.WriteLine("===== Before Sort =====");
            ListAll();
            bookList.Sort(new SortByAuthor());
            Console.WriteLine("===== After Sort =====");
            ListAll();
        }
        
        //insert init data for list of books
        public void InitData() {
            bookList.Add(new Book("C Programming","Quang Hien","FPTU","IT12",2019,
                new ArrayList {"Introduction","Body","Summary","Conclusion"}));
            bookList.Add(new Book("Java Developer", "Quang Hien", "DTU", "IT10", 2020,
                new ArrayList { "Introduction", "Body", "Summary", "Conclusion" }));
            bookList.Add(new Book("Python Programming", "Duc Son", "DUT", "IT11", 2017,
                new ArrayList { "Introduction", "Body", "Summary", "Conclusion" }));
            bookList.Add(new Book("Web Designer", "Nguyen Go", "FPT", "IT09", 2018,
                new ArrayList { "Introduction", "Body", "Summary", "Conclusion" }));
            bookList.Add(new Book("Pascal Introduction", "Huynh Long", "NEU", "IT12", 2019,
                new ArrayList { "Introduction", "Body", "Summary", "Conclusion" }));
        }
    }
}
