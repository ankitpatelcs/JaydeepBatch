using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eg
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 0;
            b = 1;
            Console.Write(" {0} {1}",a,b);

            for (int i = 0; i < 20; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
            Console.Read();
        }
    }
}
