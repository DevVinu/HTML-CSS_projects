using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            

            for(int count = 1; count <=100; count = count + 1)
            {
                sum = sum + count;
                
            }

            Console.WriteLine("Sum of 1-100 is {0}", sum);
            Console.ReadKey();
        }
    }
}
