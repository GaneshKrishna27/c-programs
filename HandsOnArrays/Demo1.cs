using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo1
    {
        static void Main()
        {
            int[] a = new int[5] { 10, 12, 15, 69, 35 };
            //int sum = 0;
            foreach (int i in a)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
           
        

        


    
}
