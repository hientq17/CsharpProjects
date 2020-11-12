using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_extra {
    public partial class frmNhanVien : Form {
        public frmNhanVien() {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e) {
            if (txtHoTen.Text.Length == 0) {
                MessageBox.Show("Vui lòng nhập họ và tên");
                return;
            }
            if (txtDienThoai.Text.Length == 0) {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return;
            }
            if (txtDiaChi.Text.Length == 0) {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return;
            }
            ListViewItem lvi = lsvNhanVien.Items.Add(txtHoTen.Text);
            lvi.SubItems.Add(dtpNgaySinh.Value.ToShortDateString());
            lvi.SubItems.Add(txtDienThoai.Text);
            lvi.SubItems.Add(txtDiaChi.Text);
            //Clear data
            txtHoTen.Clear(); txtDiaChi.Clear(); txtDienThoai.Clear();
            dtpNgaySinh.Value = new DateTime(2000, 01, 01);
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e) {
            if (lsvNhanVien.SelectedItems.Count > 0) {
                txtHoTen.Text = lsvNhanVien.SelectedItems[0].SubItems[0].Text;
                dtpNgaySinh.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                txtDienThoai.Text = lsvNhanVien.SelectedItems[0].SubItems[2].Text;
                txtDiaChi.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
            }

        }

        private void btnSua_Click(object sender, EventArgs e) {
            if (lsvNhanVien.SelectedItems.Count > 0) {
                lsvNhanVien.SelectedItems[0].SubItems[0].Text = txtHoTen.Text;
                lsvNhanVien.SelectedItems[0].SubItems[1].Text =
                dtpNgaySinh.Value.ToShortDateString();
                lsvNhanVien.SelectedItems[0].SubItems[2].Text =
                txtDienThoai.Text;
                lsvNhanVien.SelectedItems[0].SubItems[3].Text =
                txtDiaChi.Text;
                //Clear data
                txtHoTen.Clear(); txtDiaChi.Clear(); txtDienThoai.Clear();
                dtpNgaySinh.Value = new DateTime(2000, 01, 01);
            } else {
                MessageBox.Show("Vui lòng chọn một nhân viên");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e) {
            if (lsvNhanVien.SelectedItems.Count > 0) {
                lsvNhanVien.Items.Remove(lsvNhanVien.SelectedItems[0]);
            } else {
                MessageBox.Show("Vui lòng chọn một nhân viên");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void txtDienThoai_KeyDown(object sender, KeyEventArgs e) {
            char code = (char)e.KeyCode;
            if (code < '0' || code > '9') e.SuppressKeyPress = true;
        }
    }
}
