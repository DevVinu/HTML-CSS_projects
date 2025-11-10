using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class frmHome : Form
    {
        string uname;

        public frmHome()
        {
            InitializeComponent();
        }

        public frmHome(string u)
        {
            InitializeComponent();
            uname = u;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Welcome, " + uname;
        }

        private void studentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void userReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
        }
    }
}
