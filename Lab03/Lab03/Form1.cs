using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03 {
    public partial class Form1 : Form {

        string fileName = "employee.txt";
        public Form1() {
            InitializeComponent();
            readFile();
        }

        private void readFile() {
            try {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(fileName);
                //Read the first line of text
                string line = sr.ReadLine();
                string[] employeeArr;
                Employee employee;
                //Continue to read until you reach end of file
                while (line != null) {
                    employeeArr = line.Split(';');
                    employee = new Employee(employeeArr[0], Int32.Parse(employeeArr[1]), employeeArr[2],
                        Int32.Parse(employeeArr[3]), employeeArr[4], employeeArr[5], employeeArr[6]);
                    //add to list view
                    addList(employee);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            } catch (Exception e) {
                Console.WriteLine("Exception: " + e.Message);
            } 
        }

        private void addList(Employee employee) {
            //add to list view
            ListViewItem lvi = listEmployee.Items.Add(employee.Name);
            lvi.SubItems.Add(employee.Age.ToString());
            lvi.SubItems.Add(employee.Address);
            lvi.SubItems.Add(employee.Experience.ToString());
            lvi.SubItems.Add(employee.Phone);
            lvi.SubItems.Add(employee.Email);
            lvi.SubItems.Add(employee.JoiningDate);
        }

        private void WriteFile() {
            StreamWriter sw = File.CreateText(fileName);
            Employee employee = null;
            for (int i = 0; i < listEmployee.Items.Count; i++) {
                employee = new Employee(
                    listEmployee.Items[i].SubItems[0].Text,
                    Int32.Parse(listEmployee.Items[0].SubItems[1].Text),
                    listEmployee.Items[i].SubItems[2].Text,
                    Int32.Parse(listEmployee.Items[0].SubItems[3].Text),
                    listEmployee.Items[i].SubItems[4].Text,
                    listEmployee.Items[i].SubItems[5].Text,
                    listEmployee.Items[i].SubItems[6].Text
               );
                sw.WriteLine(employee.Show());
            }
            sw.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (txtName.TextLength == 0) {
                MessageBox.Show("Please input Name");
                this.ActiveControl = txtName;
                return;
            }
            if (txtAddress.TextLength == 0) {
                MessageBox.Show("Please input Address");
                this.ActiveControl = txtAddress;
                return;
            }
            if (!Regex.IsMatch(txtAge.Text,"\\d")) {
                MessageBox.Show("Please input Age as a number");
                this.ActiveControl = txtAge;
                return;
            }
            if (Regex.IsMatch(txtExperience.Text, "\\d")) {
                int year = Int32.Parse(txtExperience.Text);
                if (year < 1 || year > 2) {
                    MessageBox.Show("Please input Year of Experiences from 1 - 2 years");
                    this.ActiveControl = txtExperience;
                    return;
                }
            } else {
                MessageBox.Show("Please input Year of Experiences as a number");
                this.ActiveControl = txtExperience;
                return;
            }
            if (txtPhone.TextLength == 0) {
                MessageBox.Show("Please input Phone number");
                this.ActiveControl = txtPhone;
                return;
            }
            if (txtEmail.TextLength == 0) {
                MessageBox.Show("Please input Email");
                this.ActiveControl = txtEmail;
                return;
            }
            Employee employee = new Employee(
                txtName.Text,
                Int32.Parse(txtAge.Text),
                txtAddress.Text,
                Int32.Parse(txtExperience.Text),
                txtPhone.Text,
                txtEmail.Text,
                joinDate.Value.ToShortDateString()
            );

            //add to list view
            addList(employee);

            //save to file
            WriteFile();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listEmployee.SelectedItems.Count > 0) {
                txtName.Text = listEmployee.SelectedItems[0].SubItems[0].Text;
                txtAge.Text = listEmployee.SelectedItems[0].SubItems[1].Text;
                txtAddress.Text = listEmployee.SelectedItems[0].SubItems[2].Text;
                txtExperience.Text = listEmployee.SelectedItems[0].SubItems[3].Text;
                txtPhone.Text = listEmployee.SelectedItems[0].SubItems[4].Text;
                txtEmail.Text = listEmployee.SelectedItems[0].SubItems[5].Text;
                joinDate.Text = listEmployee.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (listEmployee.SelectedItems.Count == 0) {
                MessageBox.Show("Please select one");
                return;
            }
            if (txtName.TextLength == 0) {
                MessageBox.Show("Please input Name");
                this.ActiveControl = txtName;
                return;
            }
            if (txtAddress.TextLength == 0) {
                MessageBox.Show("Please input Address");
                this.ActiveControl = txtAddress;
                return;
            }
            if (!Regex.IsMatch(txtAge.Text, "\\d")) {
                MessageBox.Show("Please input Age as a number");
                this.ActiveControl = txtAge;
                return;
            }
            if (Regex.IsMatch(txtExperience.Text, "\\d")) {
                int year = Int32.Parse(txtExperience.Text);
                if (year < 0 || year > 2) {
                    MessageBox.Show("Please input Year of Experiences from 0 - 2 years");
                    this.ActiveControl = txtExperience;
                    return;
                }
            } else {
                MessageBox.Show("Please input Year of Experiences as a number");
                this.ActiveControl = txtExperience;
                return;
            }
            if (txtPhone.TextLength == 0) {
                MessageBox.Show("Please input Phone number");
                this.ActiveControl = txtPhone;
                return;
            }
            if (txtEmail.TextLength == 0) {
                MessageBox.Show("Please input Email");
                this.ActiveControl = txtEmail;
                return;
            }
            Employee employee = new Employee(
                txtName.Text,
                Int32.Parse(txtAge.Text),
                txtAddress.Text,
                Int32.Parse(txtExperience.Text),
                txtPhone.Text,
                txtEmail.Text,
                joinDate.Value.ToShortDateString()
            ) ;

            //update listView
            listEmployee.SelectedItems[0].SubItems[0].Text = txtName.Text;
            listEmployee.SelectedItems[0].SubItems[1].Text = txtAge.Text ;
            listEmployee.SelectedItems[0].SubItems[2].Text = txtAddress.Text;
            listEmployee.SelectedItems[0].SubItems[3].Text = txtExperience.Text;
            listEmployee.SelectedItems[0].SubItems[4].Text = txtPhone.Text;
            listEmployee.SelectedItems[0].SubItems[5].Text = txtEmail.Text;
            listEmployee.SelectedItems[0].SubItems[6].Text = joinDate.Value.ToShortDateString();

            //save to file
            WriteFile();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (listEmployee.SelectedItems.Count > 0) {
                listEmployee.Items.Remove(listEmployee.SelectedItems[0]);
                WriteFile();
            }

        }
    }
}
