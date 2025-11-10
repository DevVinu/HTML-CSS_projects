using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    class Vehicle
    {
        string bname, category;

        public void input()
        {
            Console.WriteLine("Enter Brand Name: ");
            bname = Console.ReadLine();
            Console.WriteLine("Enter Category: ");
            category = Console.ReadLine();
        }
    }

    class Car : Vehicle //Single level inheritance
    {
        string regno, color, country;

        public Car()
        {
            regno = "AA0000";
            color = "White";
            country = "Sri Lanka";            
        }

        public void calImportCost()
        {
            double imcost = 0.00;
            if(country == "Japan")
            {
                imcost = 400;
            }
            else if(country == "England")
            { 
                imcost = 300;
            }
            else if (country == "USA")
            {
                imcost = 600;
            }
            else 
            {
                imcost = 450;
            }
            Console.WriteLine("Import Cost: {0}", imcost);
        }

        public void inputCarData()
        {
            Console.WriteLine("Enter Reg No: ");
            regno = Console.ReadLine();
            Console.WriteLine("Enter Color: ");
            color = Console.ReadLine();
            Console.WriteLine("Enter Country of Origin: ");
            country = Console.ReadLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();
            v1.input();
            Car c1 = new Car();
            c1.inputCarData();
            c1.calImportCost();
            Car c2 = new Car();
            c2.inputCarData();
            c2.calImportCost();
            Console.ReadKey();
        }
    }
}
