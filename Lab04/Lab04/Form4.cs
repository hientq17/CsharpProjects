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
    public partial class Form4 : Form {
        SqlConnection conn = null;
        ConnectDB db = new ConnectDB();
        public Form4() {
            InitializeComponent();
            loadCategoryList("");
        }

        private void loadCategoryList(String categoryName) {
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            lsStudent.Items.Clear();
            string sql = "Select CategoryID, CategoryName, Description from Categories";
            if (categoryName.Length > 0) {
                sql = sql + " where CategoryName Like '%" + categoryName + "%'";
            }
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Categories cat = new Categories(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2)
                    );
                ListViewItem itemList = new ListViewItem(cat.CategoryId.ToString());
                itemList.SubItems.Add(cat.CategoryName);
                itemList.SubItems.Add(cat.Description);
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
            loadCategoryList(txtCompanyName.Text);
        }

        private void btnDisplayAll_Click(object sender, EventArgs e) {
            loadCategoryList("");
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
