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
using System.Windows.Forms.VisualStyles;

namespace Lab04 {
    public partial class Form1 : Form {
        SqlConnection conn = null;
        ConnectDB db = new ConnectDB();
        public Form1() {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            try {
                conn = db.OpenConnection();
                MessageBox.Show("Connect successfully");
                btnClose.Enabled = true;
                btnListProducts.Enabled = true;
                btnListSuppliers.Enabled = true;
                btnListCategories.Enabled = true;
                btnOpen.Enabled = false;
            } catch (Exception ex) {
                MessageBox.Show("Connect failure \n" + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            db.CloseConnection();
            MessageBox.Show("Close successfully");
            Application.Exit();
        }

        private void btnListProducts_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnListSuppliers_Click(object sender, EventArgs e) {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnListCategories_Click(object sender, EventArgs e) {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
