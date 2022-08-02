using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(23);
            li.Add(36);
            li.Add(78);
            li.Add(96);
            List<string> li2 = new List<string>();
            li2.Add("Jaydeep");
            li2.Add("Rakesh");
            li2.Add("Shankar");
            li2.Add("Akashay");
            li2.Add("Jenees");

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            foreach (var item in li2)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
