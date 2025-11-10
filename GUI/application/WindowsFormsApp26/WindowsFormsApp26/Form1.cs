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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = @"C:\Users\USER\source\repos\WindowsFormsApp26\WindowsFormsApp26\CrystalReport1.rpt"; //Full Path
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Connection
            string cs = @"Data Source=NIBM-VS\SQLEXPRESS;Initial Catalog=studentdb;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Command
            string sql = "SELECT * FROM tblstudent WHERE sid=@sid";
            SqlCommand com = new SqlCommand(sql,con);
            com.Parameters.AddWithValue("@sid", this.txtSK.Text);

            //Access data using Data Adaptor
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            //disconnect
            con.Close();

            //Bind data with Crystal Report
            CrystalReport1 rpt1 = new CrystalReport1();
            rpt1.Load(@"C:\Users\USER\source\repos\WindowsFormsApp26\WindowsFormsApp26\CrystalReport1.rpt");
            rpt1.SetDataSource(ds.Tables[0]);

            this.crystalReportViewer1.ReportSource = rpt1;
        }
    }
}
