using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowFormDemo
{
    public partial class frmSecurity : Form
    {
        public frmSecurity()
        {
            InitializeComponent();
            //focus on txtCode
            this.ActiveControl = txtCode;
        }

        public String check() {
            switch (txtCode.Text) {
                case "1645":
                    return "Technicians";
                case "1689":
                    return "Technicians";
                case "8345":
                    return "Custodians";
                case "9998":
                    return "Scientist";
                default:
                    int code = int.Parse(txtCode.Text);
                    if (code>=1006 && code <= 1008){
                        return "Scientist";
                    }
                    return "Restricted Access!";
            }
        }

        private void btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCode.TextLength < 4) txtCode.Text = txtCode.Text + (sender as Button).Text;
            //focus on txtCode
            this.ActiveControl = txtCode;
        }

        private void btnEnter_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCode.TextLength < 4) return;
            DateTime now = DateTime.Now;
            if (txtLog.Text == "" || txtLog.Text == null)
            {
                txtLog.Items.Add(now.ToString("dd/MM/yyyy hh:mm:ss tt") + "\t" + check());
            }
            else
            {
                txtLog.Items.Add("\r\n" + now.ToString("dd/MM/yyyy hh:mm:ss tt") + "\t" + check());
            }
            txtLog.SelectedIndex = txtLog.Items.Count - 1;
            Save();
            txtCode.Clear();
            //focus on txtCode
            this.ActiveControl = txtCode;
        }

        private void btnC_MouseClick(object sender, MouseEventArgs e)
        {
            txtCode.Clear();
            //focus on txtCode
            this.ActiveControl = txtCode;
        }

        private void frmSecurity_Down(object sender, KeyEventArgs e)
        {
            if (txtCode.TextLength < 4) {
                char code = (char)e.KeyCode;
                if (code >= '0' && code <= '9') txtCode.AppendText(code.ToString());
            }
            if (e.KeyCode == Keys.Enter){
                if (txtCode.TextLength < 4) return;
                DateTime now = DateTime.Now;
                if (txtLog.Text == "" || txtLog.Text == null) {
                    txtLog.Items.Add(now.ToString("dd/MM/yyyy hh:mm:ss tt") + "\t" + check());
                }
                else{
                    txtLog.Items.Add("\r\n" + now.ToString("dd/MM/yyyy hh:mm:ss tt") + "\t" + check());
                }
                txtLog.SelectedIndex = txtLog.Items.Count - 1;
                Save();
                txtCode.Clear();
            }
            if (e.KeyCode == Keys.Back) txtCode.Clear();
        }

        public void Save()
        {
            String root = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            try
            {
                string filename = root+"\\log.txt";
                FileStream ft = new FileStream(filename, FileMode.Create, FileAccess.Write);
                StreamWriter st = new StreamWriter(ft);
                foreach (string item in txtLog.Items){
                    st.Write(item);
                }
                
                st.Close();
                ft.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Save Failure");
                Console.WriteLine("Error: " + e);
                return;
            }
            Console.WriteLine("Save Success");
        }

    }
}
