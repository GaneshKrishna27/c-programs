using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArraysTopic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n value ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements");
            int[] a = new int[n];
            for(int i=0; i<=n;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int low, high;
            low = a[0];
            high = a[0];
            for(int i=0;i<n;i++)
            {
                if (a[i] > high) high = a[i];
                if (a[i] < low) low = a[i];

            }
            Console.WriteLine("max value:" + high);
            Console.WriteLine("min value:" + low);
            Console.ReadLine();

        }
    }
}
