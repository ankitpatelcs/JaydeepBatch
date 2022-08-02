using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericss
{
    class MyClass<Type1, Type2, Type3>
    {
        Type1 id;
        Type2 name;
        Type3 salary;

        public MyClass(Type1 i, Type2 n)
        {
            id = i;
            name = n;
        }

        public MyClass(Type1 i, Type2 n, Type3 s)
        {
            id = i;
            name = n;
            salary = s;
        }

        internal void display()
        {
            Console.WriteLine("Value1: " + id);
            Console.WriteLine("Value2: " + name);
            Console.WriteLine("Value3: " + salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int, string, double> m1 = new MyClass<int, string, double>(23, "Jaydeep");
            m1.display();

            //MyClass<string, DateTime> m2 = new MyClass<string, DateTime>("Shankar", DateTime.Now);
            //m2.display();

            Console.Read();
        }
    }
}
