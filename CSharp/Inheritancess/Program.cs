using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritancess
{
    class Employee
    {
        int id;
        string name;
        protected void GetEmp()
        {
            id = 90;
            name = "Jaydeep";
        }

        protected void ShowEmp()
        {
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Name: {0}", name);
        }
    }
    class Payroll : Employee
    {
        int salary;
        internal void GetData()
        {
            GetEmp();
            salary = 56000;            
        }
        internal void Showdata()
        {
            ShowEmp();
            Console.WriteLine("Salary: {0}",salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Payroll p = new Payroll();
            p.GetData();
            p.Showdata();

            Console.ReadKey();
        }
    }
}
