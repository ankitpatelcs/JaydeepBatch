using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class MyClass
    {
        internal void WriteData(string filename)
        {
            StreamWriter sw = File.CreateText(filename);
            Console.Write("\nEnter data to write: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Close();
            Console.WriteLine("file Write Success.");
        }
        internal void ReadData(string filename)
        {
            StreamReader sr = File.OpenText(filename);
            Console.Write("\nContent From File: {0}",sr.ReadToEnd());
            sr.Close();
            Console.WriteLine("Read File Success.");
        }
        internal void AppendData(string filename)
        {
            StreamWriter sw = File.AppendText(filename);
            Console.Write("\nEnter data to Append: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Close();
            Console.WriteLine("file Append Success.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            string filename = @"C:\Ankit Patel\Rakesh.txt";
            m.WriteData(filename);
            m.ReadData(filename);
            m.AppendData(filename);
            m.ReadData(filename);

            Console.Read();
        }
    }
}
