using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers of 1-50");

            for(int count = 1; count<= 50; count++)
            {
                if(count%2 == 0)
                {
                    Console.Write(count+", ");
                }
            }

            Console.WriteLine("\n\nOdd numbers of 1-50");

            for (int count = 1; count <= 50; count++)
            {
                if (count % 2 != 0)
                {
                    Console.Write(count+", ");
                }
            }

            Console.ReadKey();
        }
    }
}
