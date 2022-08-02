using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterfacess
{
    interface IEmployee
    {
        void display();
        void show();
    }
    class Employee : IEmployee
    {
        public void display()
        {
            Console.WriteLine("calling from diaplay");
        }

        public void show()
        {
            Console.WriteLine("calling fron show");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee e = new Employee();
            e.display();
            e.show();

            Console.Read();
        }
    }
}
