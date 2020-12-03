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
using System.Text.RegularExpressions;

namespace PracticalExam {


    public partial class Form2 : Form {
        ConnectDB db = new ConnectDB();
        public Form2() {
            InitializeComponent();
        }

        private Boolean InsertValidation() {
            if (!Regex.IsMatch(txtMADIA.Text, "^D\\d{4}$")) {
                MessageBox.Show("Vui lòng nhập mã đĩa theo đúng định dạng (D + 4 chữ số)!");
                return false;
            }
            string query = "Select * from DIA where MADIA = '" + txtMADIA.Text + "'";
            SqlCommand command = new SqlCommand(query, db.OpenConnection());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) {
                MessageBox.Show("Mã đĩa đã tồn tại!");
                return false;
            }
            if (txtTENDIA.Text.Length==0) {
                MessageBox.Show("Vui lòng nhập tên đĩa!");
                return false;
            }
            if (txtTHELOAI.Text.Length == 0) {
                MessageBox.Show("Vui lòng nhập thể loại đĩa!");
                return false;
            }
            return true;
        }

        private Boolean UpdateValidation() {
            string query = "Select * from DIA where MADIA = '" + txtMADIA.Text + "'";
            SqlCommand command = new SqlCommand(query, db.OpenConnection());
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read()) {
                MessageBox.Show("Mã đĩa không tồn tại!");
                return false;
            }
            if (txtTENDIA.Text.Length == 0) {
                MessageBox.Show("Vui lòng nhập tên đĩa!");
                return false;
            }
            if (txtTHELOAI.Text.Length == 0) {
                MessageBox.Show("Vui lòng nhập thể loại đĩa!");
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e) {
            if (!InsertValidation()) return;
            string query = "Insert into DIA values(@MADIA, @TENDIA, @THELOAI)";
            SqlCommand command = new SqlCommand(query, db.OpenConnection());
            SqlParameter parameter = new SqlParameter("@MADIA", SqlDbType.VarChar);
            parameter.Value = txtMADIA.Text;
            command.Parameters.Add(parameter);
            parameter = new SqlParameter("@TENDIA", SqlDbType.NVarChar);
            parameter.Value = txtTENDIA.Text;
            command.Parameters.Add(parameter);
            parameter = new SqlParameter("@THELOAI", SqlDbType.NVarChar);
            parameter.Value = txtTHELOAI.Text;
            command.Parameters.Add(parameter);
            try {
                if (command.ExecuteNonQuery() > 0) {
                    MessageBox.Show("Thêm băng đĩa mới thành công!");
                    txtMADIA.Text = "";
                    txtTENDIA.Text = "";
                    txtTHELOAI.Text = "";
                } else {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            } catch (Exception ex) {
                MessageBox.Show("Có lỗi xảy ra! \n"+ex.Message);
            }          
            db.CloseConnection();
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            string query = "Select * from DIA where MADIA = '" + txtMADIA.Text + "'";
            SqlCommand command = new SqlCommand(query, db.OpenConnection());
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read()) {
                MessageBox.Show("Mã đĩa không tồn tại!");
                return;
            }
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa băng đĩa này?",
                "Xóa băng đĩa", buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                query = "Delete from DIA where MADIA = '"+txtMADIA.Text+"'";
                command = new SqlCommand(query, db.OpenConnection());
                try {
                    if (command.ExecuteNonQuery() > 0) {
                        MessageBox.Show("Xóa băng đĩa thành công!");
                        txtMADIA.Text = "";
                        txtTENDIA.Text = "";
                        txtTHELOAI.Text = "";
                    } else {
                        MessageBox.Show("Có lỗi xảy ra!");
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Có lỗi xảy ra! \n"+ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e) {
            if (!UpdateValidation()) return;
            string query = "Update DIA set TENDIA = @TENDIA, THELOAI = @THELOAI where MADIA = @MADIA";
            SqlCommand command = new SqlCommand(query, db.OpenConnection());
            SqlParameter parameter = new SqlParameter("@MADIA", SqlDbType.VarChar);
            parameter.Value = txtMADIA.Text;
            command.Parameters.Add(parameter);
            parameter = new SqlParameter("@TENDIA", SqlDbType.NVarChar);
            parameter.Value = txtTENDIA.Text;
            command.Parameters.Add(parameter);
            parameter = new SqlParameter("@THELOAI", SqlDbType.NVarChar);
            parameter.Value = txtTHELOAI.Text;
            command.Parameters.Add(parameter);
            try {
                if (command.ExecuteNonQuery() > 0) {
                    MessageBox.Show("Cập nhật băng đĩa thành công!");
                    txtMADIA.Text = "";
                    txtTENDIA.Text = "";
                    txtTHELOAI.Text = "";
                } else {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            } catch (Exception ex) {
                MessageBox.Show("Có lỗi xảy ra! \n"+ex);
            } 
            db.CloseConnection();
        }

        private void btnThoat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e) {

        }
    }
}
