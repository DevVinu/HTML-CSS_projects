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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int no1, no2;
            int sum;
            double avg;

            //Inputs
            no1 = Convert.ToInt32(this.txtNo1.Text);
            no2 = Convert.ToInt32(this.txtNo2.Text);

            //Calculations
            sum = no1 + no2;
            avg = sum / 2.00;

            //Display
            this.txtSum.Text = sum.ToString();
            this.txtAvg.Text = avg.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtNo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
