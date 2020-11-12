using System;
using System.Collections.Generic;

namespace MyBookLibrary
{
    public class Book
    {
        private int id;
        private string publisher;
        private double price;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public double Price { get => price; set => price = value; }

        public Book(int id, string name, string publisher, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Publisher = publisher;
            this.Price = price;
        }

        public void Show() {
            Console.WriteLine($"Book[ID: {Id}; Name: {Name}; Publisher: {Publisher}; Price: {Price}]");
        }
    }
}
