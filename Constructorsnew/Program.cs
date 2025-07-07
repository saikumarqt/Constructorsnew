using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructorsnew
{
    //wap to create a class student with sid, sname, sage as data members.
    //different students can have different sid, sname, sage.
    //Parameterized constructor should be used to initialize the data members.
    /*
     * While defining a constructor, we can use the same name as the class name.
     * while defining a constructor if we have used parametes is called as
     * parameterized constructor.
     * A class can contain multiple parameterized constructors.
     * but we should differentiate with the number of parameters and the type of parameters and
     * order of parameters or signatures.
     * what is signature will represent?
     * signature will represent the number of parameters and the type of parameters and order of 
     * parameters.
     * 
     * Constrcutor Overloading is a concept where we can have multiple constructors in a class
     * Defing multiple constructors in a class is called as constructor overloading.
     * 
     */
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
