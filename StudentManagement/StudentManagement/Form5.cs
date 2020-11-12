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
    public partial class Form5 : Form {

        ConnectDB db = new ConnectDB();
        MySqlConnection conn = null;
        DataSet stdList = null;
        MySqlDataAdapter adapter = null;
        int currentIndex = -1;

        public Form5() {
            InitializeComponent();
            loadStdList();
        }

        private void loadStdList() {
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            adapter = new MySqlDataAdapter("Select * from Students",conn);
            stdList = new DataSet();
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            adapter.Fill(stdList,"Students");
            db.CloseConnection();
            dataGridView.DataSource = stdList.Tables["students"];
        }

        private void btnDisplay_Click(object sender, EventArgs e) {
            loadStdList();
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
            foreach (DataRow r in stdList.Tables["students"].Rows) {
                if (r["StdId"].ToString() == txtStdId.Text) {
                    MessageBox.Show("ID existed");
                    this.ActiveControl = txtStdId;
                    return;
                }
            }
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            if (!checkClassIdExisted(conn)) return;
            DataRow row = stdList.Tables["students"].NewRow();
            row["stdId"] = txtStdId.Text;
            row["stdName"] = txtStdName.Text;
            row["classId"] = txtClassId.Text;
            stdList.Tables["students"].Rows.Add(row);
            int result = 0;
            try {
                result = adapter.Update(stdList, "Students");
                loadStdList();
            } catch(Exception ex) {
                MessageBox.Show("Add student failure \n"+ex);
            }
            if (result > 0) {
                MessageBox.Show("Add student successfully");
            }
            db.CloseConnection();
        }

        private bool checkClassIdExisted(MySqlConnection conn) {
            String sql = "Select Count(*) from Classes where ClassId = @ClassId";
            MySqlParameter parameter = new MySqlParameter("@ClassId", MySqlDbType.String);
            parameter.Value = txtClassId.Text;
            MySqlCommand command = new MySqlCommand(sql,conn);
            command.Parameters.Add(parameter);
            int result = Convert.ToInt32(command.ExecuteScalar());
            if (result == 0) {
                MessageBox.Show("This Class ID does not exist");
                this.ActiveControl = txtClassId;
                db.CloseConnection();
                return false;
            }
            return true;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            currentIndex = e.RowIndex;
            if (currentIndex == -1 || currentIndex >= stdList.Tables["Students"].Rows.Count) return;
            DataRow row = stdList.Tables["students"].Rows[currentIndex];
            txtStdId.Text = row["stdId"].ToString();
            txtStdName.Text = row["stdName"].ToString() ;
            txtClassId.Text = row["classId"].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (currentIndex==-1 || currentIndex >= stdList.Tables["Students"].Rows.Count) {
                MessageBox.Show("Please select one row");
                return;
            }
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
            bool idExisted = false;
            foreach (DataRow r in stdList.Tables["students"].Rows) {
                if (r["StdId"].ToString() == txtStdId.Text) {
                    this.ActiveControl = txtStdId;
                    idExisted = true;
                    break;
                }
            }
            if (!idExisted) {
                MessageBox.Show("This Student ID does not exist");
                this.ActiveControl = txtStdId;
                return;
            }
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            if (!checkClassIdExisted(conn)) return;
            DataRow row = stdList.Tables["students"].Rows[currentIndex];
            row.BeginEdit();
            row["stdId"] = txtStdId.Text;
            row["stdName"] = txtStdName.Text;
            row["classId"] = txtClassId.Text;
            row.EndEdit();
            int result = 0;
            try {
                result = adapter.Update(stdList, "Students");
                loadStdList();
            } catch (Exception ex) {
                MessageBox.Show("Edit student failure \n" + ex);
            }
            if (result > 0) {
                MessageBox.Show("Edit student successfully");
            }
            db.CloseConnection();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (currentIndex == -1 || currentIndex >= stdList.Tables["Students"].Rows.Count) {
                MessageBox.Show("Please select one row");
                return;
            }
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            DataRow row = stdList.Tables["students"].Rows[currentIndex];
            row.Delete();
            int result = 0;
            try {
                result = adapter.Update(stdList, "Students");
                loadStdList();
            } catch (Exception ex) {
                MessageBox.Show("Delete student failure \n" + ex);
            }
            if (result > 0) {
                MessageBox.Show("Delete student successfully");
            }
            db.CloseConnection();
        }
    }
}
