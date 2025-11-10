using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    class Student
    {
        //Member Variables
        int sno;
        string name;
        int age;

        //Default Constructor
        public Student()
        {
            sno = 0;
            name = "";
            age = 0;
        }

        //Parameterized Constructor
        public Student(int a, string b, int c)
        {
            sno = a;
            name = b;
            age = c;
        }

        //Destructor
        ~Student()
        {
            Console.WriteLine("Object Deleted.");
            Console.ReadKey();
        }

        //Member Functions
        public void inputData()
        {
            Console.WriteLine("Enter Student No: ");
            sno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Student No: {0}", sno);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Declare an object of Student class
            Student s1 = new Student();//Call to default constructor
            Student s2 = new Student(111, "aaa", 0); //Call to parameterized constructor
            //Call to member functions
            //s1.inputData();
            s1.display();

            //s2.inputData();
            s2.display();
            Console.ReadKey();
        }
    }
}
