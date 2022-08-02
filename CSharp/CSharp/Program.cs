using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int id;
            string name;
            Console.Write("Enter Id: ");
            id= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.WriteLine("\nID: {0}\nName: {1}",id,name);
            */
            Console.WriteLine("Byte: {0} to {1}",Byte.MinValue,Byte.MaxValue);
            Console.WriteLine("SByte: {0} to {1}",SByte.MinValue,SByte.MaxValue);
            Console.WriteLine("Int16: {0} to {1}", Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("short: {0} to {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("UInt16: {0} to {1}", UInt16.MinValue, UInt16.MaxValue);

            Console.WriteLine("UInt32: {0} to {1}", UInt32.MinValue, UInt32.MaxValue);
            Console.WriteLine("Int32: {0} to {1}", Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("int: {0} to {1}", int.MinValue, int.MaxValue);

            Console.WriteLine("UInt64: {0} to {1}", UInt64.MinValue, UInt64.MaxValue);
            Console.WriteLine("Int64: {0} to {1}", Int64.MinValue, Int64.MaxValue);
            Console.WriteLine("long: {0} to {1}", long.MinValue, long.MaxValue);


            Console.Read();
        }
    }
}
