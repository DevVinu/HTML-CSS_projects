using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double bs = 0, all = 0, epf = 0, etf = 0, ns = 0;

            //Validation
            if(this.txtBS.Text == "")
            {
                this.errorProvider1.SetError(this.txtBS, "Basic Salary cannot be blank");
            }
            else
            {
                bs = Convert.ToDouble(this.txtBS.Text);

                //Calculate Allowance
                if (this.cmbType.SelectedIndex == 0)
                {
                    all = 5000;
                }
                else if (this.cmbType.SelectedItem.ToString() == "Staff")
                {
                    all = 7000;
                }
                else if (this.cmbType.Text == "Manager")
                {
                    all = 9000;
                }

                //Add extra allowance
                if (this.rbFemale.Checked == true)
                {
                    all = all + 5000;
                }

                //EPF and ETF
                if (this.chkStatus.Checked == true)
                {
                    epf = (bs * 12 / 100) + (bs * 8 / 100);
                    etf = bs * 3 / 100;
                }

                //Net Salary
                ns = bs + all - (bs * 8 / 100);

                //Display
                this.txtAll.Text = all.ToString();
                this.txtEPF.Text = epf.ToString();
                this.txtETF.Text = etf.ToString();
                this.txtNS.Text = ns.ToString();
            }

        }

        private void txtBS_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
        }
    }
}
