using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace Exercise3_4
{
    class AccountManager
    {
        private ArrayList accountList = new ArrayList();
        public void GUI()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"===== Account Manager =====");
                Console.WriteLine("1. Add account");
                Console.WriteLine("2. Delete account");
                Console.WriteLine("3. Show all accounts");
                Console.WriteLine("4. Sort account by Id (using Comparable)");
                Console.WriteLine("5. Sort account by First Name (using Comparer)");
                Console.WriteLine("6. Sort account by Balance (using Comparer)");
                Console.WriteLine("7. Save to file");
                Console.WriteLine("8. Load from file");
                Console.WriteLine("9. Save to file (using Serialization)");
                Console.WriteLine("10. Load from file (using Deserialization");
                Console.WriteLine("11. Quit");
                int choice = Validator.InputIntNumberRange("Enter your choice", 1, 11);
                switch (choice)
                {
                    case 1: Add(); break;
                    case 2: Delete(); break;
                    case 3: Console.Clear(); ListAll(); Console.ReadLine(); break;
                    case 4: SortById(); Console.ReadLine(); break;
                    case 5: SortByName(); Console.ReadLine(); break;
                    case 6: SortByBalance(); Console.ReadLine(); break;
                    case 7: Save(); Console.ReadLine(); break;
                    case 8: Load(); Console.ReadLine(); break;
                    case 9: SaveUsingSerializable(); Console.ReadLine(); break;
                    case 10: LoadUsingSerializable(); Console.ReadLine(); break;
                    case 11: return;
                }
            }
        }
        public void Add()
        {
            accountList.Add(new Account().FillInfo());
        }
        public void Delete()
        {
            Console.Clear();
            ListAll();
            int index = Validator.InputIntNumberRange("-> Index to delete", 0, accountList.Count);
            accountList.RemoveAt(index-1);
        }
        public void ListAll()
        {
            int count = 0;
            foreach (Account i in accountList)
            {
                count++;
                Console.Write($"{count} : ");
                i.Query();
            }
        }
        public void SortById()
        {
            Console.Clear();
            Console.WriteLine("===== Before Sort =====");
            ListAll();
            accountList.Sort(new SortById());
            Console.WriteLine("===== After Sort =====");
            ListAll();
        }
        public void SortByName()
        {
            Console.Clear();
            Console.WriteLine("===== Before Sort =====");
            ListAll();
            accountList.Sort(new SortByName());
            Console.WriteLine("===== After Sort =====");
            ListAll();
        }
        public void SortByBalance()
        {
            Console.Clear();
            Console.WriteLine("===== Before Sort =====");
            ListAll();
            accountList.Sort(new SortByBalance());
            Console.WriteLine("===== After Sort =====");
            ListAll();
        }
        public void Save()
        {
            try
            {
                string filename = "account.txt";
                
                if (File.Exists(filename)) {
                    Console.WriteLine("This file has already existed! Do you want to overwrite it?");
                    int check = Validator.InputIntNumberRange("Type 1 to continue, type 0 to quit",0,1);
                    if (check == 0) return;
                }
                FileStream ft = new FileStream(filename, FileMode.Create, FileAccess.Write);
                StreamWriter st = new StreamWriter(ft);
                foreach (Account i in accountList)
                {
                    st.WriteLine($"{i.Id}|{i.Fname}|{i.Lname}|{i.Balance}");
                }
                st.Close();
                ft.Close();
            }catch (Exception e)
            {
                Console.WriteLine("Save Failure");
                Console.WriteLine("Error: "+e);
                return;
            }
            Console.WriteLine("Save Success");
        }
        public void Load()
        {
            try
            {
                string filename = "Account.txt";
                FileStream ft = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(ft);
                string temp;
                accountList.Clear();
                while ((temp=sr.ReadLine())!=null)
                {
                    string[] data = temp.Split("|");
                    accountList.Add(new Account(int.Parse(data[0]), data[1], data[2], double.Parse(data[3])));
                }
                sr.Close();
                ft.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Load Failure"+e);
                return;
            }
            Console.WriteLine("Load Success");
        }

        public void SaveUsingSerializable()
        {
            try
            {
                string filename = "account1.txt";

                if (File.Exists(filename))
                {
                    Console.WriteLine("This file has already existed! Do you want to overwrite it?");
                    int check = Validator.InputIntNumberRange("Type 1 to continue, type 0 to quit", 0, 1);
                    if (check == 0) return;
                }
                Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, accountList);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Save Failure");
                Console.WriteLine("Error: " + e);
                return;
            }
            Console.WriteLine("Save Success");
        }
        public void LoadUsingSerializable()
        {
            try
            {
                string filename = "Account1.txt";
                Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                IFormatter formatter = new BinaryFormatter();
                accountList.Clear();
                accountList = (ArrayList)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Load Failure" + e);
                return;
            }
            Console.WriteLine("Load Success");
        }

        //insert init data for list of accounts
        public void InitData() {
            accountList.Add(new Account(1, "Hien", "Quang", 1200));
            accountList.Add(new Account(2, "Giang", "Nguyen", 1995.1));
            accountList.Add(new Account(3, "Long", "Huynh", 1115.9));
            accountList.Add(new Account(4, "Go", "Nguyen", 1190.5));
            accountList.Add(new Account(5, "Son", "Le", 1110));
        }
    }
}
