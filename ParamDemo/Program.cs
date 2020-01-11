using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamDemo
{
    class Calculator
    {
        public void Add(params int[] x)
        {
            int res = 0;
            foreach (int i in x) res += i;
            res = x.Sum(e => e);

            Console.WriteLine(res);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Add(10, 20, 30, 40, 50, 60);
            Console.WriteLine("hello");
        }
    }
}
