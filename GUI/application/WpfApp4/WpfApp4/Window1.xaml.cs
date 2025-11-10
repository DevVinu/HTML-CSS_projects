using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int no1, no2;
            double sum, avg;

            no1 = Convert.ToInt32(this.txtNo1.Text);
            no2 = Convert.ToInt32(this.txtNo2.Text);

            sum = no1 + no2;
            avg = sum / 2.00;

            this.txtSum.Text = sum.ToString();
            this.txtAvg.Text = avg.ToString();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
