using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiess
{
    class MyClass
    {
        int id;
        public int empid 
        {
            get 
            {
                return id;
            }
            //set 
            //{
            //    id = value;
            //}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            //m.empid = 90;
            Console.WriteLine(m.empid);

            Console.Read();
        }
    }
}
