using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp26
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Create connection
            string cs = @"Data Source=NIBM-VS\SQLEXPRESS;Initial Catalog=studentdb;
                        Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Command
            string sql = "SELECT * FROM tbluser WHERE uname=@uname AND pword=@pword";
            SqlCommand com = new SqlCommand(sql,con);
            com.Parameters.AddWithValue("@uname", this.txtUN.Text);
            com.Parameters.AddWithValue("@pword", this.txtPW.Text);

            //Access Data
            SqlDataReader dr = com.ExecuteReader();
            if(dr.Read() == true)
            {
                frmHome h = new frmHome(this.txtUN.Text);
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error");
            }

            //Disconnect
            con.Close();
        }
    }
}
