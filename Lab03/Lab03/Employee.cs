using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab03 {

    class Employee {

        private string name;
        private int age;
        private string address;
        private int experience;
        private string phone;
        private string email;
        private string joiningDate;

        public Employee(string name, int age, string address, 
            int experience, string phone, string email, string joiningDate) {
            this.name = name;
            this.age = age;
            this.address = address;
            this.experience = experience;
            this.phone = phone;
            this.email = email;
            this.joiningDate = joiningDate;
        }

        public string Show() {
            string s = name + "; " + age + "; " + address + "; " + experience +
                "; " + phone + "; " + email + "; " + joiningDate;
            return s;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public int Experience { get => experience; set => experience = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string JoiningDate { get => joiningDate; set => joiningDate = value; }
    }
}
