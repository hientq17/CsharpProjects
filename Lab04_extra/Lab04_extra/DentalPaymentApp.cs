using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_extra
{
    public partial class DentalPaymentApp : Form
    {
        public DentalPaymentApp() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e){
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e){
            if (txtName.TextLength == 0) {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Warning");
            } else {
                double total = 0;
                if (chkClean.Checked) total += double.Parse(
                    lblCleanCost.Text.Replace(".", "").Replace("$", ""));
                if (chkWhitening.Checked) total += double.Parse(
                    lblWhiteningCost.Text.Replace(".", "").Replace("$", ""));
                if (chkXRay.Checked) total += double.Parse(
                    lblXRayCost.Text.Replace(".", "").Replace("$", ""));
                total += Convert.ToInt32(numFilling.Value) * double.Parse(
                    lblFillingCost.Text.Replace(".", "").Replace("$", "").Replace("/cái", "")); ;
                txtTotal.Text = total.ToString("C0",
                    System.Globalization.CultureInfo.GetCultureInfo("en-us")).Replace(",",".");
                lsBox.Items.Add(txtName.Text + " - " + txtTotal.Text);
            }
        } 
    }
}
