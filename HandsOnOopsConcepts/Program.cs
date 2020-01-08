using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOopsConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator(5,6);
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            //c.Add(x, y);
            // c.Swap(x,y);
            int result = c.Add(x, y);
            Console.WriteLine(result);
            c.Subtract(x, y, out int sub);
            Console.WriteLine(sub);
            c.Swap(ref x, ref y);
            Console.WriteLine(x+ "  " + y);
            Console.ReadLine();
        }
    }
}
