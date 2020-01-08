using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[4];
            i[0] = 12;
            i[1] = 14;
            i[2] = 25;
            i[3] = 546;

            int k = i[3];
            Console.WriteLine(i[1]);

            for (int a = 0; a < 4; a++) 
            {
                Console.WriteLine(i[a]);

            }
            foreach(int no in i)
            {
                Console.WriteLine(no);
            }
            Console.ReadKey();

        }
    }
}
