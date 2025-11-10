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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int nor = 0, nod = 0;
            double rcost = 0;
            double accost = 0, mcost = 0, discount = 0, tourcost = 0;

            nor = Convert.ToInt32(this.nuNoR.Value);

            //Room Cost
            if(this.cmbType.Text == "Standard")
            {
                rcost = 50;
            }
            else if(this.cmbType.Text == "Luxury")
            {
                rcost = 70;
            }
            else if(this.cmbType.Text == "Deluxe")
            {
                rcost = 100;
            }

            //No days
            DateTime cin = Convert.ToDateTime(this.dtCIn.Text);
            DateTime cout = Convert.ToDateTime(this.dtCOut.Text);

            if(cin == cout)
            {
                nod = 1;
            }
            else
            {
                TimeSpan ts = cout - cin;
                nod = ts.Days;
            }            

            //Acc Cost
            accost = nor * rcost * nod;

            //Meal Cost
            if(this.chkMeal.Checked == true)
            {
                mcost = nod * 20;
            }

            //Apply Discount
            string[] saarc = {"Sri Lanka", "India", "Pakistan", "Bangladesh", 
                "Nepal", "Bhutan", "Maldives", "Afghanistan" };

            for(int i=0; i<8; i++)
            {
                if(this.cmbCountry.Text == saarc[i])
                {
                    discount = accost * 10 / 100;
                    break;
                }
            }

            //TOur Cost
            tourcost = accost + mcost - discount;

            //Display
            this.txtTCost.Text = tourcost.ToString("C");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
