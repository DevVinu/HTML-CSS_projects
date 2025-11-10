using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int no1, no2;
            double no3;
            double sum, avg;

            //Input Data
            Console.WriteLine("Enter an integer number: ");
            no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an integer number: ");
            no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a decimal number: ");
            no3 = Convert.ToDouble(Console.ReadLine());

            //Calculations
            sum = no1 + no2 + no3;
            avg = sum / 3.00;

            //Display
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Sum is {0}", sum);
            Console.WriteLine("{0} is the sum and average is {1}", sum, avg);
            Console.ReadKey();
        }
    }
}
