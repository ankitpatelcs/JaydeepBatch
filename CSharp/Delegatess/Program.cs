using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatess
{
    public delegate void FirstDelegate();
    public delegate string SecondDelegate(int id,string name);

    class MyClass
    {
        public void display()
        {
            Console.WriteLine("calling from diaplay");
        }

        public void show()
        {
            Console.WriteLine("calling fron show");
        }

        public string Getdata(int id, string name)
        {
            return $"Id: {id} and Name: {name}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            FirstDelegate del1 = new FirstDelegate(m.display);
            //multicasting
            del1 += new FirstDelegate(m.show);
            del1.Invoke();

            del1 -= new FirstDelegate(m.show);
            del1.Invoke();

            SecondDelegate del2 = new SecondDelegate(m.Getdata);
            string data= del2.Invoke(90, "Rakesh");
            Console.WriteLine(data);

            Console.Read();
        }
    }
}
