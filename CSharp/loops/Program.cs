using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            Console.WriteLine("====While Loop====");
            while (i<5)
            {
                Console.WriteLine("While loop");
                i++;
            }
            i = 6;
            Console.WriteLine("\n====Do-While Loop====");
            do
            {
                Console.WriteLine("Do-While loop");
                i++;
            } while (i < 5);

            for ( i = 0; i < 5; i++)
            {
                Console.WriteLine("=for loopo=");
            }

            Console.Read();
        }
    }
}
