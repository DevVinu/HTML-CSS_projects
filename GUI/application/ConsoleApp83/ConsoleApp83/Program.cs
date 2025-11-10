using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    class Cylinder
    {
        int radius, height;

        public Cylinder()
        {
            radius = 5;
            height = 10;
        }

        public Cylinder(int x, int y)
        {
            radius = x;
            height = y;
        }

        ~Cylinder() { }

        public void calArea()
        {
            double sa = (2 * 3.14 * radius * height) + (2 * 3.14 * radius * radius);
            Console.WriteLine("Surface Area of the Cylinder: {0}", sa);
        }

        public void calVolume()
        {
            double vol = 3.14 * radius * radius * height;
            Console.WriteLine("Volume of the Cylinder: {0}", vol);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            c1.calArea();
            c1.calVolume();

            Cylinder c2 = new Cylinder(10, 20);
            c2.calArea();
            c2.calVolume();
            Console.ReadKey();
        }
    }
}
