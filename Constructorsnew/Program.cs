using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructorsnew
{
    class Employee
    {
        int eid;
        string ename;
        double esal;
        // Default constructor
        //public Employee()
        //{
        //    eid = 101;
        //    ename = "ABC";
        //    esal= 10000.0;
        //}
        // Parameterized constructor
        public Employee(int Eid,string Ename,double Esal)
        {
            eid = Eid;
            ename = Ename;
            esal = Esal;
        }
        public void Display()
        {
            Console.WriteLine("Employee ID: " + eid);
            Console.WriteLine("Employee Name: " + ename);
            Console.WriteLine("Employee Salary: " + esal);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of Employee class
            Employee emp = new Employee(101,"ABC",10000.0);
            emp.Display();
            Employee e = new Employee(102, "XYZ", 20000.0);
            e.Display();
        }
    }
}
