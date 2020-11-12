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
    public partial class Form2 : Form {
        SqlConnection conn = null;
        ConnectDB db = new ConnectDB();
        public Form2() {
            InitializeComponent();
            loadProductList("");
        }

        private void loadProductList(String productName) {
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            lsStudent.Items.Clear();
            string sql = "Select ProductID, ProductName, SupplierID, CategoryID," +
                " QuantityPerUnit, UnitPrice, UnitsInStock, Discontinued from Products";
            if (productName.Length > 0) {
                sql = sql + " where ProductName Like '%" + productName + "%'";
            }
                SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Products p = new Products(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetString(4),
                        Double.Parse(reader.GetSqlMoney(5).ToString()),
                        Int32.Parse(reader.GetInt16(6).ToString()),
                        reader.GetBoolean(7)
                    );
                ListViewItem itemList = new ListViewItem(p.ProductId.ToString());
                itemList.SubItems.Add(p.ProductName);
                itemList.SubItems.Add(p.SupplierId.ToString());
                itemList.SubItems.Add(p.CategoryId.ToString());
                itemList.SubItems.Add(p.QuantityPerUnit);
                itemList.SubItems.Add(p.UnitPrice.ToString());
                itemList.SubItems.Add(p.UnitsInStock.ToString());
                itemList.SubItems.Add(p.Discontinued.ToString());
                lsStudent.Items.Add(itemList);
            }
            reader.Close();
            db.CloseConnection();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (txtProductName.TextLength == 0) { 
                MessageBox.Show("Please input product name");
                this.ActiveControl = txtProductName;
                return;
            }
            loadProductList(txtProductName.Text);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e) {
            loadProductList("");
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
