﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeService;

namespace NamespaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.display();

            Console.Read();
        }
    }
}
