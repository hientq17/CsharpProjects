using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StudenManagement;

namespace StudentManagement {
    public partial class Form2 : Form {
        MySqlConnection conn = null;
        ConnectDB db = new ConnectDB();
        public Form2() {
            InitializeComponent();
        }

        private void btnClassDetail_Click(object sender, EventArgs e) {
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            string sql = "Select * from Classes where ClassId = '"+txtId.Text+"'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) {
                Classes classes = new Classes(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetInt32(2)
                );
                txtClassId.Text = classes.ClassId;
                txtClassName.Text = classes.ClassName;
                txtClassYear.Text = classes.ClassYear.ToString();
            } else {
                MessageBox.Show("This Class ID does not exist", "ERROR");
            }
            reader.Close();
            db.CloseConnection();
        }

        private void btnStudentList_Click(object sender, EventArgs e) {
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            lsStudent.Items.Clear();
            string sql = "Select * from Students where ClassId = @ClassId";
            MySqlParameter parameter = new MySqlParameter("@ClassId", MySqlDbType.String);
            parameter.Value = txtId.Text;
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add(parameter);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Students std = new Students(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2)
                    );
                ListViewItem itemList = new ListViewItem(std.StdId);
                itemList.SubItems.Add(std.StdName);
                itemList.SubItems.Add(std.ClassId);
                lsStudent.Items.Add(itemList);
            }
            reader.Close();
            if (lsStudent.Items.Count==0) {
                MessageBox.Show("This Class ID does not exist", "ERROR");
            }
            db.CloseConnection();
        }
    }
}
