using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int no1 = 34, no2 = 23, no3 = 11;
            int sum;
            double avg;

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
