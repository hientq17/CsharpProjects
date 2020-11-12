using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3_4
{
    [Serializable]
    class Account
    {
        private int id;
        private string fname;
        private string lname;
        private double balance;

        public int Id { get => id; set => id = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public double Balance { get => balance; set => balance = value; }

        public Account()
        {
        }

        public Account(int id,string fname, string lname, double balance)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Id = id;
            this.Balance = balance;
        }

        public Account FillInfo()
        {
            Console.Clear();
            Console.WriteLine($"===== Input Book =====");
            Account acc = new Account();
            acc.Id = Validator.InputIntNumber("ID");
            acc.Fname = Validator.InputString("First Name", "");
            acc.Lname = Validator.InputString("Last Name", "");
            acc.Balance = Validator.InputDoubleNumber("Balance");
            return acc;
        }

        public void Query()
        {
            Console.WriteLine($"Account {Id} (First Name = {Fname}, Last Name = {Lname}, Balance = {Balance})");
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}
