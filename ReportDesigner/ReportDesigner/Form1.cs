using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ReportDesigner {
    public partial class Form1 : Form {
        DataTable data;
        public Form1() {
            InitializeComponent();
            data = InvoiceDetailDAO.Instance.GetListInvoiceDetailReport(31);
            Console.WriteLine("Size: " + data.Rows.Count);
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'mrendzpc_CoffeeManagementDataSet.Report' table. You can move, or remove it, as needed.
            this.ReportTableAdapter.Fill(this.mrendzpc_CoffeeManagementDataSet.Report);
            Invoice invoice = InvoiceDAO.Instance.GetInvoiceByID(31);
            Console.WriteLine("total: " + invoice.TotalPayment);
            ReportParameter[] parameters = new ReportParameter[5];
            parameters[0] = new ReportParameter("tableId", invoice.TableID.ToString());
            parameters[1] = new ReportParameter("invoiceTime", DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
            parameters[2] = new ReportParameter("totalPayment", invoice.TotalPayment.ToString());
            parameters[3] = new ReportParameter("invoiceId", invoice.InvoiceID.ToString());
            parameters[4] = new ReportParameter("employeeName", invoice.EmployeeUser);
            reportViewer.LocalReport.SetParameters(parameters);
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet";
            rds.Value = data;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }
    }
}
