using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisionmaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=4;
            if (a>10)
            {
                if (a % 5 == 0)
                {
                    Console.WriteLine("a is greater and divisible by 5");
                }
                else
                {
                    Console.WriteLine("a is greater NOT divisible by 5");
                }
            }
            else
            {
                Console.WriteLine("false");
            }
            

            Console.Read();
        }
    }
}
