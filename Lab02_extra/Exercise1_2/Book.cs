using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Exercise1_2
{
    class Book : IBook,IComparable
    {
        protected string title;
        protected string author;
        protected string publisher;
        protected string IBSN;
        protected int year;
        protected ArrayList chapter = new ArrayList();

        public Book(string title, string author, string publisher, string iBSN, int year, ArrayList chapter)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            IBSN = iBSN;
            this.year = year;
            this.chapter = chapter;
        }

        public string this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int Year { get => year; set => year = value; }
        string IBook.IBSN { get => IBSN; set => IBSN = value; }

        public int CompareTo([AllowNull] Object other)
        {
            return this.Year.CompareTo(((Book)other).Year);
        }

        public void Show()
        { 
            Console.WriteLine($"Book {IBSN} (Name: {title}, Author: {author}, Publisher: {publisher}, Year: {year})");
            int count = 0;
            foreach (string i in chapter)
            {
                count++;
                Console.WriteLine($" - Chapter {count}: {i}");
            }
            Console.WriteLine("---------------------------------------------------");
        }

    }
}
