using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class frmCalculator : Form
    {
        //Variables
        double no1, no2;
        double ans;
        string op;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (this.txtDisplay.Text != "")
            {
                this.txtDisplay.Text = this.txtDisplay.Text + "0";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = this.txtDisplay.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = this.txtDisplay.Text + "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = this.txtDisplay.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = this.txtDisplay.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = this.txtDisplay.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = this.txtDisplay.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = this.txtDisplay.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = this.txtDisplay.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = this.txtDisplay.Text + "9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(this.txtDisplay.Text);
            op = "-";
            this.txtDisplay.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(this.txtDisplay.Text);
            op = "*";
            this.txtDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(this.txtDisplay.Text);
            op = "/";
            this.txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            no2 = Convert.ToDouble(this.txtDisplay.Text);
            if(op == "+")
            {
                ans = no1 + no2;
            }

            if (op == "-")
            {
                ans = no1 - no2;
            }

            if (op == "*")
            {
                ans = no1 * no2;
            }

            if (op == "/")
            {
                ans = no1 / no2;
            }

            this.txtDisplay.Text = ans.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(this.txtDisplay.Text);
            op = "+";
            this.txtDisplay.Clear();
        }
    }
}
