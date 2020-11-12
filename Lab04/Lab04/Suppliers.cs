using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04 {
    class Suppliers {
        private int supplierId;
        private string companyName;
        private string contactName;
        private string address;
        private string phone;

        public Suppliers(int supplierId, string companyName, string contactName, string address, string phone) {
            this.supplierId = supplierId;
            this.companyName = companyName;
            this.contactName = contactName;
            this.address = address;
            this.phone = phone;
        }

        public int SupplierId { get => supplierId; set => supplierId = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
