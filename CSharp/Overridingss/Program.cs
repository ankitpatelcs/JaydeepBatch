using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overridingss
{
    abstract class Employee
    {
        virtual public void display()
        {
            Console.WriteLine("Calling Employee Function");
        }
    }
    class payroll : Employee
    {
        override public void display()
        {            
            Console.WriteLine("Calling payroll Function");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee p = new payroll();
            p.display();

            Console.Read();
        }
    }
}
