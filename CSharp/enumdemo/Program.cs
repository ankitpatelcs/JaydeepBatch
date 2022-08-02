using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumdemo
{
    enum Weekdays
    {
        Sunday=1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Weekdays.Saturday);

            int i = 90;
            object o = i;
            Console.WriteLine("ID: "+i);

            string a = "5";
            int b=Convert.ToInt32(a);
            Console.WriteLine(b);


            Console.Read();
        }
    }
}
