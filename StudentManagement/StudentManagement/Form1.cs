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
using MySql.Data.MySqlClient;

namespace StudentManagement {
    public partial class Form1 : Form {
        MySqlConnection conn = null;
        ConnectDB db = new ConnectDB();
        public Form1() {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            try {
                conn = db.OpenConnection();
                MessageBox.Show("Connect successfully");
                btnCount.Enabled = true;
                btnClose.Enabled = true;
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

        private void btnCount_Click(object sender, EventArgs e) {
            string sql = "Select count(*) from Students";
            MySqlCommand command = new MySqlCommand(sql,conn);
            int result = Convert.ToInt32(command.ExecuteScalar());
            txtCount.Text = result.ToString();
        }

        private void btnManage_Click(object sender, EventArgs e) {

        }


    }
}
