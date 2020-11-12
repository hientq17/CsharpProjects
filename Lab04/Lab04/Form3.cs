using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04 {
    public partial class Form3 : Form {
        SqlConnection conn = null;
        ConnectDB db = new ConnectDB();
        public Form3() {
            InitializeComponent();
            loadCompanyList("");
        }

        private void loadCompanyList(String companyName) {
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            lsStudent.Items.Clear();
            string sql = "Select SupplierID, CompanyName, ContactName," +
                " Address, Phone from Suppliers";
            if (companyName.Length > 0) {
                sql = sql + " where CompanyName like '%" + companyName + "%'";
            }
                SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Suppliers sup = new Suppliers(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)
                    );
                ListViewItem itemList = new ListViewItem(sup.SupplierId.ToString());
                itemList.SubItems.Add(sup.CompanyName);
                itemList.SubItems.Add(sup.ContactName);
                itemList.SubItems.Add(sup.Address);
                itemList.SubItems.Add(sup.Phone);
                lsStudent.Items.Add(itemList);
            }
            reader.Close();
            db.CloseConnection();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (txtCompanyName.TextLength == 0) { 
                MessageBox.Show("Please input Company Name");
                this.ActiveControl = txtCompanyName;
                return;
            }
            loadCompanyList(txtCompanyName.Text);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e) {
            loadCompanyList("");
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
