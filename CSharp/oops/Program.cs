using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Employee
    {
        int id;
        string name;

        public void GetData()
        {
            id = 890;
            name = "Akshay";
        }

        public void ShowData()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] e = new Employee[3];

            for (int i = 0; i < 3; i++)
            {
                e[i] = new Employee();
                e[i].GetData();
            }

            Console.WriteLine("Employee Data: ");
            for (int i = 0; i < 3; i++)
            {
                e[i].ShowData();
            }
            

            Console.Read();
        }
    }
}
