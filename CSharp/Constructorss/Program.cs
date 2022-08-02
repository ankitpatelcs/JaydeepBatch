using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructorss
{
    class MyClass
    {
        int id;
        string name;
        public MyClass(int id,string name)
        {
            this.id =id;
            this.name = name;
        }
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
        ~MyClass()
        {
            Console.WriteLine("calling destructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass(23,"Jaydeep");
            m.GetData();
            m.ShowData();

            Console.Read();
        }
    }
}
