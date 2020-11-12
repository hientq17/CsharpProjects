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

namespace StudentManagement {
    public partial class Form4 : Form {
        MySqlConnection conn = null;
        ConnectDB db = new ConnectDB();
        public Form4() {
            InitializeComponent();
            LoadStudentList();
        }

        public void LoadStudentList() {
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            lsViewStudents.Items.Clear();
            string sql = "Select * from Students";
            MySqlCommand command = new MySqlCommand(sql, conn);
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
                lsViewStudents.Items.Add(itemList);
            }
            reader.Close();
            db.CloseConnection();
        }

        private void lsViewStudents_SelectedIndexChanged(object sender, EventArgs e) {
            if (lsViewStudents.SelectedItems.Count > 0) {
                ListViewItem item = lsViewStudents.SelectedItems[0];
                Students std = new Students(
                    item.SubItems[0].Text,
                    item.SubItems[1].Text,
                    item.SubItems[2].Text
                );
                txtStdId.Text = std.StdId;
                txtStdName.Text = std.StdName;
                txtClassId.Text = std.ClassId;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (txtStdId.TextLength == 0) {
                MessageBox.Show("Please input Student ID");
                this.ActiveControl = txtStdId;
                return;
            }
            if (txtStdName.TextLength == 0) {
                MessageBox.Show("Please input Student Name");
                this.ActiveControl = txtStdName;
                return;
            }
            if (txtClassId.TextLength == 0) {
                MessageBox.Show("Please input Class ID");
                this.ActiveControl = txtClassId;
                return;
            }
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            string sql = "Select Count(*) from Students where StdId = @StdId";
            MySqlParameter parameter = new MySqlParameter("@StdId", MySqlDbType.String);
            parameter.Value = txtStdId.Text;
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add(parameter);
            int result = Convert.ToInt32(command.ExecuteScalar());
            if (result > 0) {
                MessageBox.Show("This Student ID existed!");
                this.ActiveControl = txtStdId;
                db.CloseConnection();
                return;
            }
            sql = "Select Count(*) from Classes where ClassId = @ClassId";
            parameter = new MySqlParameter("@ClassId", MySqlDbType.String);
            parameter.Value = txtClassId.Text;
            command = new MySqlCommand(sql, conn);
            command.Parameters.Add(parameter);
            result = Convert.ToInt32(command.ExecuteScalar());
            if (result == 0) {
                MessageBox.Show("Class ID does not exist");
                this.ActiveControl = txtClassId;
                db.CloseConnection();
                return;
            }
            sql = "Insert into Students values(@StdId,@StdName,@ClassId)";
            MySqlParameter parameter1 = new MySqlParameter("@StdId", MySqlDbType.String);
            parameter1.Value = txtStdId.Text;
            MySqlParameter parameter2 = new MySqlParameter("@StdName", MySqlDbType.String);
            parameter2.Value = txtStdName.Text;
            MySqlParameter parameter3 = new MySqlParameter("@ClassId", MySqlDbType.String);
            parameter3.Value = txtClassId.Text;
            command = new MySqlCommand(sql, conn);
            command.Parameters.Add(parameter1);
            command.Parameters.Add(parameter2);
            command.Parameters.Add(parameter3);
            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Add student successfully!");
            } catch (Exception ex) {
                MessageBox.Show("Add student failure! \n"+ex);
            }
            db.CloseConnection();
            LoadStudentList();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (txtStdId.TextLength == 0) {
                MessageBox.Show("Please input Student ID");
                this.ActiveControl = txtStdId;
                return;
            }
            if (txtStdName.TextLength == 0) {
                MessageBox.Show("Please input Student Name");
                this.ActiveControl = txtStdName;
                return;
            }
            if (txtClassId.TextLength == 0) {
                MessageBox.Show("Please input Class ID");
                this.ActiveControl = txtClassId;
                return;
            }
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            string sql = "Select Count(*) from Students where StdId = @StdId";
            MySqlParameter parameter = new MySqlParameter("@StdId", MySqlDbType.String);
            parameter.Value = txtStdId.Text;
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add(parameter);
            int result = Convert.ToInt32(command.ExecuteScalar());
            if (result == 0) {
                MessageBox.Show("This Student ID does not exist!");
                this.ActiveControl = txtStdId;
                db.CloseConnection();
                return;
            }
            sql = "Select Count(*) from Classes where ClassId = @ClassId";
            parameter = new MySqlParameter("@ClassId", MySqlDbType.String);
            parameter.Value = txtClassId.Text;
            command = new MySqlCommand(sql, conn);
            command.Parameters.Add(parameter);
            result = Convert.ToInt32(command.ExecuteScalar());
            if (result == 0) {
                MessageBox.Show("Class ID does not exist");
                this.ActiveControl = txtClassId;
                db.CloseConnection();
                return;
            }
            sql = "Update Students set StdName = @StdName, ClassId = @ClassId where StdId = @StdId";
            MySqlParameter parameter1 = new MySqlParameter("@StdId", MySqlDbType.String);
            parameter1.Value = txtStdId.Text;
            MySqlParameter parameter2 = new MySqlParameter("@StdName", MySqlDbType.String);
            parameter2.Value = txtStdName.Text;
            MySqlParameter parameter3 = new MySqlParameter("@ClassId", MySqlDbType.String);
            parameter3.Value = txtClassId.Text;
            command = new MySqlCommand(sql, conn);
            command.Parameters.Add(parameter1);
            command.Parameters.Add(parameter2);
            command.Parameters.Add(parameter3);
            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Edit student successfully!");
            } catch (Exception ex) {
                MessageBox.Show("Edit student failure! \n" + ex);
            }
            db.CloseConnection();
            LoadStudentList();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (lsViewStudents.SelectedItems.Count > 0) {
                if (conn == null || conn.State == ConnectionState.Closed) {
                    conn = db.OpenConnection();
                }
                string stdId = lsViewStudents.SelectedItems[0].SubItems[0].Text;
                string sql = "Delete from Students where StdId = @StdId";
                MySqlParameter parameter = new MySqlParameter("@StdId", MySqlDbType.String);
                parameter.Value = stdId;
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.Add(parameter);
                try {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Delete student successfully!");
                } catch (Exception ex) {
                    MessageBox.Show("Delete student failure! \n" + ex);
                }
                db.CloseConnection();
                LoadStudentList();
            } else {
                MessageBox.Show("Please select student to delete");
            }
        }
    }
}
