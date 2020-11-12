using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation
{
    public partial class frmPhepTinh : Form
    {
        public frmPhepTinh()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtSon.Text);
                float num2 = float.Parse(txtSom.Text);
                txtKetqua.Text = (num1 + num2).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập vào một số", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtSon.Text);
                float num2 = float.Parse(txtSom.Text);
                txtKetqua.Text = (num1 - num2).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập vào một số", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtSon.Text);
                float num2 = float.Parse(txtSom.Text);
                txtKetqua.Text = (num1 * num2).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập vào một số", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtSon.Text);
                float num2 = float.Parse(txtSom.Text);
                if (num2 == 0) {
                    MessageBox.Show("Không thể chia cho 0", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    txtKetqua.Text = (num1 / num2).ToString();
                }   
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập vào một số", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSon.Text = "";
            txtSom.Text = "";
            txtKetqua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
