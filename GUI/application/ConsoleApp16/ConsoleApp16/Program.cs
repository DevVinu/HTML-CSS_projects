using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;

            Console.WriteLine("Enter a number: ");
            no = Convert.ToInt32(Console.ReadLine());

            if(no%2 == 0)
            {
                Console.WriteLine("{0} is an Even number", no);
            }
            else
            {
                Console.WriteLine("{0} is an Odd number", no);
            }

            Console.ReadKey();
        }
    }
}
