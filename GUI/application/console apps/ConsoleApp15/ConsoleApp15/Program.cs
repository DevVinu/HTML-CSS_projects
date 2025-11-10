using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sno = 0;
            string name;
            double sm, mm, em;
            double avg;
            string grade = "";

            //Input
            Console.WriteLine("Enter Student ID: ");
            sno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Science Marks: ");
            sm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Maths Marks: ");
            mm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter English Marks: ");
            em = Convert.ToDouble(Console.ReadLine());

            if(0>sm || sm>100 || 0>mm || mm>100 || 0>em || em>100)
            {
                Console.WriteLine("Invalid Mark, range is 1-100");
            }
            else
            {
                //Calculations
                avg = (sm + mm + em) / 3.00;
                if (avg < 40)
                {
                    grade = "Fail";
                    //Console.WriteLine("Grade is Fail");
                }
                else if (avg < 60)
                {
                    grade = "Pass";
                }
                else if (avg < 80)
                {
                    grade = "Credit";
                }
                else if (avg <= 100)
                {
                    grade = "Distinction";
                }

                //Print
                Console.WriteLine("Student NO: {0}", sno);
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Average: {0}", avg);
                Console.WriteLine("Grade: {0}", grade);
            }

            
            Console.ReadKey();

        }
    }
}
