using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnVariablesWithDatatypes
{
    class Program
    {
        string name; // instance variable
        static double salary; // static variable
        static void Main(string[] args)
        {
            int i=50;
            int[] a = new int[4] { 12, 23, 34, 45 };
            Console.WriteLine(i);
            Console.WriteLine(Program.salary);
            Program obj = new Program();
            Console.WriteLine(obj.name);
            //Console.ReadKey();
            int k = 13;
            string name = "gany";
            Console.WriteLine("name:{0} +age:{1}", name, k);
            Console.ReadKey();
        }
    }
}
