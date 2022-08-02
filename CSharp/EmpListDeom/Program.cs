using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpListDeom
{
    class Employee
    {
        public int empid { get; set; }
        public string fname { get; set; }
        public string email { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { empid = 1, fname = "Jaydeep", email = "j@gmail.com" });
            li.Add(new Employee { empid = 2, fname = "Akshay", email = "a@gmail.com" });
            li.Add(new Employee { empid = 3, fname = "Rakesh", email = "r@gmail.com" });

            foreach (var item in li)
            {
                Console.WriteLine();
                Console.WriteLine(item.empid);
                Console.WriteLine(item.email);
                Console.WriteLine(item.fname);
            }
            Console.Read();
        }
    }
}
