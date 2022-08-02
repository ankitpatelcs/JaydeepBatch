using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    class Shape
    {
        internal void Area(double r)
        {
            Console.WriteLine("Area of Circle: {0}", 3.14 * r * r);
        }
        internal void Area(int a)
        {
            Console.WriteLine("Area of Square: {0}",a*a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.Area(15.25);
            s.Area(15);

            Console.Read();
        }
    }
}
