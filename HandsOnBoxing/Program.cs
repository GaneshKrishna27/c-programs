using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing
            int i = 10;
            char ch = 'a';
            double d = 100.66;
            object o = i;
            object o1 = d;
            //unboxing
            object ob = 12;
            int k = (int)ob;
            object ob1 = 12.4;
            double d1 = (double)ob1;
            Console.WriteLine(o);

            



        }
    }
}
