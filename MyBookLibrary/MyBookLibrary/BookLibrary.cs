using System;
using System.Collections.Generic;
using System.Text;

namespace MyBookLibrary
{
    public class BookManagement
    {


        private List<Book> bookList = new List<Book>();

        public List<Book> BookList { get => bookList; set => bookList = value; }

        public void AddBook() {
            int id = Validator.InputIntNumber("Enter book ID");
            string name = Validator.InputString("Enter name", "");
            string publisher = Validator.InputString("Enter name", "");
            double price = Validator.InputDoubleNumber("Enter price");
            Book book = new Book(id, name, publisher, price);
            bookList.Add(book);
            Console.WriteLine("Add book successfully!");
        }

        public void AddBook(Book book) {
            bookList.Add(book);
            Console.WriteLine("Add book successfully!");
        }

        public void UpdateBook()
        {
            if (isEmpty()) return;
            int id = Validator.InputIntNumber("Enter book ID");
            bool flag = false;
            for(int i=0; i<bookList.Count; i++){
                if (bookList[i].Id == id) {
                    string name = Validator.InputString("Enter new name","");
                    bookList[i].Name = name;
                    string publisher =  Validator.InputString("Enter new publisher", "");
                    bookList[i].Publisher = publisher;
                    double price = Validator.InputDoubleNumber("Enter new price");
                    bookList[i].Price = price;
                    flag = true;
                    Console.WriteLine("Update book successfully!");
                }
            }
            if (!flag) Console.WriteLine("This ID does not exist!");
        }

        public void DeleteBook()
        {
            if(isEmpty()) return;
            int id = Validator.InputIntNumber("Enter book ID");
            bool flag = false;
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].Id == id)
                {
                    String confirm = Validator.InputString("Do you want to delete this book? Type \"yes\" to delete","");
                    if (confirm.ToLower().Equals("yes"))
                    {
                        bookList.RemoveAt(i);
                        Console.WriteLine("Delete book successfully!");
                    }
                    else {
                        Console.WriteLine("Action cancelled!");
                    }
                    flag = true;
                }
            }
            if (!flag) Console.WriteLine("This ID does not exist!");
        }

        public void ListBook()
        {
            if (isEmpty()) return;
            foreach (Book book in bookList){
                book.Show();
            }        
        }

        public Boolean isEmpty() {
            if (bookList.Count == 0)
            {
                Console.WriteLine("Book List is empty");
                return true;
            }
            return false;
        }
    }
}
