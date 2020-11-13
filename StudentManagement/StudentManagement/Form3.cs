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
    public partial class Form3 : Form {

        MySqlConnection conn = null;
        ConnectDB db = new ConnectDB();

        public Form3() {
            InitializeComponent();
            loadClassList();
            lsBoxClasses.SelectedIndex = 0;
        }

        public void loadClassList() {
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            lsBoxClasses.Items.Clear();
            string sql = "Select * from Classes";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                string classId = reader.GetString(0);
                string className = reader.GetString(1);
                int classYear = reader.GetInt32(2);
                lsBoxClasses.Items.Add(new Classes(classId,className,classYear));
            }
            reader.Close();
            db.CloseConnection();
        }

        private void lsBoxClass_SelectedIndexChanged(object sender, EventArgs e) {
            if (conn == null || conn.State == ConnectionState.Closed) {
                conn = db.OpenConnection();
            }
            lsViewStudents.Items.Clear();
            string sql = "Select * from Students where ClassId = @ClassId";
            MySqlParameter parameter = new MySqlParameter("@ClassId", MySqlDbType.String);
            parameter.Value = ((Classes)lsBoxClasses.SelectedItem).ClassId;
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
                lsViewStudents.Items.Add(itemList);
            }
            reader.Close();
            db.CloseConnection();
        }
    }
}
