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
    public partial class frmOrder : Form {
        DataTable[] tbOrder;
        int tableIndex = 0;
        public frmOrder() {
            InitializeComponent();
            createDataTable();
        }

        void createDataTable() {
            cbbTable.SelectedIndex = 0;
            int size = cbbTable.Items.Count;
            tbOrder = new DataTable[size];
            for (int i = 0; i < size; i++) {
                tbOrder[i] = new DataTable();
                tbOrder[i].Columns.Add("Món ăn", typeof(string));
                tbOrder[i].Columns.Add("Số lượng", typeof(int));
                //Tao khóa
                DataColumn[] keys = new DataColumn[1];
                keys[0] = tbOrder[i].Columns[0];
                tbOrder[i].PrimaryKey = keys;
            }
            dataGridView.DataSource = tbOrder[tableIndex];
        }

        private void btn_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            DataRow findRow = tbOrder[tableIndex].Rows.Find(button.Text);
            if (findRow == null) tbOrder[tableIndex].Rows.Add(button.Text, 1);
            else {
                //lấy index của row 
                int i = tbOrder[tableIndex].Rows.IndexOf(findRow);
                tbOrder[tableIndex].Rows[i].SetField("Số lượng",
                    int.Parse(findRow["Số lượng"].ToString()) + 1);
            }
        }

        private void btnDel_Click(object sender, EventArgs e) {
            int i = dataGridView.CurrentRow.Index;
            tbOrder[tableIndex].Rows.Remove(tbOrder[tableIndex].Rows[i]);           
        }

        private void cbbTable_SelectedIndexChanged(object sender, EventArgs e) {
            tableIndex = cbbTable.SelectedIndex;
            if (tbOrder != null) {
                dataGridView.DataSource = tbOrder[tableIndex];
            }

        }

        private void btnOrder_Click(object sender, EventArgs e) {
            MessageBox.Show("Order thành công", "Thành công!");
            tbOrder[tableIndex].Clear();
        }
    }


}
