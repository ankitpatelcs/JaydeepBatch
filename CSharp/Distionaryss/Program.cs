using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distionaryss
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("ID", 501);
            d.Add("Fname", "Jaydeep");
            d.Add("Salary", 25000.5);
            d.Add("Gender", 'M');

            foreach (var item in d)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.Read();
        }
    }
}
