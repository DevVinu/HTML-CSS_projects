using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            int max;

            Console.WriteLine("Enter Number1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number3: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            max = n1;

            if(n2>max)
            {
                max = n2;
            }
        
            if(n3>max)
            {
                max = n3;
            }

            Console.WriteLine("Max of {0}, {1}, {2} is {3}", n1, n2, n3, max);
            Console.ReadKey();
        }
    }
}
