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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double sm, mm, em;
            double avg;
            string grade = "";

            //Inputs
            sm = Convert.ToDouble(this.txtSM.Text);
            mm = Convert.ToDouble(this.txtMM.Text);
            em = Convert.ToDouble(this.txtEM.Text);

            //Validation
            if(sm<0 || sm>100 || mm<0 || mm>100 || em<0 || em>100)
            {
                MessageBox.Show("Invalid Marks entered, range is 0-100", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.lblMessage.Text = "Invalid Marks entered, range is 0-100";
            }
            else
            {
                //Calculations
                avg = (sm + mm + em) / 3.00;
                if (avg < 40)
                {
                    grade = "Fail";
                    this.BackColor = Color.Red;
                }
                else if (avg < 60)
                {
                    grade = "Pass";
                    this.BackColor = Color.Pink;
                }
                else if (avg < 80)
                {
                    grade = "Credit";
                    this.BackColor = Color.Yellow;
                }
                else if (avg <= 100)
                {
                    grade = "Distinction";
                    this.BackColor = Color.Green;
                }

                //Display
                this.txtAvg.Text = avg.ToString();
                this.txtGrade.Text = grade;
            }   
        }
    }
}
