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

namespace PracticalExam {
    public partial class Form3 : Form {
        ConnectDB db = new ConnectDB();
        public Form3() {
            InitializeComponent();
            loadDIA();
        }

        private void loadDIA() {
            DataTable data = new DataTable();
            string query = "Select * from DIA";
            SqlCommand command = new SqlCommand(query, db.OpenConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewDIA.DataSource = data;
            db.CloseConnection();
        }

        private void btnTim_Click(object sender, EventArgs e) {
            string TENDIA = txtTENDIA.Text;
            string query;
            if (TENDIA.Length == 0) {
                query = "Select * from DIA";
            } else {
                query = "Select * from DIA where TENDIA like @TENDIA";
            }
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand(query, db.OpenConnection());
            SqlParameter parameter = new SqlParameter("@TENDIA", SqlDbType.NVarChar);
            parameter.Value = "%"+TENDIA+"%";
            command.Parameters.Add(parameter);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewDIA.DataSource = data;
            db.CloseConnection();
        }
    }
}
