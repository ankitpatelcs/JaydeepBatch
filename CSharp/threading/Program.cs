using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace threading
{
    class MyClass
    {
        internal void display()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\tThread Name: {0}, {1}",Thread.CurrentThread.Name,i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            Thread.CurrentThread.Name = "Parent";
            //child
            Thread t = new Thread(new ThreadStart(m.display));
            t.Name = "Child";
            t.Start();

            t.Join();
            for (int i = 0; i < 10; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine("Thread Name: {0}, {1}", Thread.CurrentThread.Name, i);
            }

            Console.Read();
        }
    }
}
