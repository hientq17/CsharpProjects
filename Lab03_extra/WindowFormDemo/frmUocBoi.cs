using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormDemo
{
    public partial class frmUocBoi : Form
    {
        public frmUocBoi()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
                if (rdUSCLN.Checked) txtKetqua.Text = UCLN(a, b).ToString();
                else txtKetqua.Text = BCNN(a, b).ToString();
            }
            catch (FormatException) {
                MessageBox.Show("Vui lòng nhập vào số nguyên", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labeBoqua_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetqua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn thoát khỏi chương trình?";
            string title = "Thoát";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private int UCLN(int a, int b) {
            while (a != b){
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a; 
        }
        private int BCNN(int a, int b){
            int result = UCLN(a, b);
            return a * b / result;
        }

        private void txtKetqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUocBoi_Load(object sender, EventArgs e)
        {

        }
    }
}
