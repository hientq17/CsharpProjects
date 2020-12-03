
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ReportDesigner {

    

    class InvoiceDAO
    {

        private static InvoiceDAO instance;

        public static InvoiceDAO Instance
        {
            get { if (instance == null) instance = new InvoiceDAO(); return InvoiceDAO.instance; }
            private set { InvoiceDAO.instance = value; }
        }

        private InvoiceDAO() { }
        
        public Invoice GetInvoiceByID(int id)
        {
            DataTable data = ConnectDB.Instance.ExecuteQuery(
                "Select invoiceId,tableId,dateSale,totalPayment,employeeName as employeeUser,invoiceStatus from Invoice" +
                " inner join Employee on Invoice.employeeUser = Employee.employeeUser where invoiceId = " + id);
            Invoice invoice = new Invoice(data.Rows[0]);
            return invoice;
        }
    }
}
