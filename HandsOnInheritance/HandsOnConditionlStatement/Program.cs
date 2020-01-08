using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionlStatement
{
    class Program
    {
        public static string EvenorOdd(int i)
        {
            if (i % 2 == 0)
            {
                return "even";

            }
            else
            {
                return "odd";
            }
        }
        public static int Max(int i, int j, int k)
        {
            if (i > j)
            {
                if (i > k)
                    return i;
                else
                    return k;
            }
            else
            {
                if (j > k)
                    return j;
                else
                    return k; 
                
            }

            
        }

        public static string Result(double m1, double m2, double m3)
        {
            double avg = (m1 + m2 + m3) / 3;
            if (avg >= 70)
                return "distinction "+avg+"%";
            else if (avg >= 60 && avg < 60)
                return "first class "+avg+"%";
            else if (avg >= 50 && avg <= 60)
                return "second class "+avg+"%";
            else
                return "fail";
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("enter no");
            //int i = int.Parse(Console.ReadLine());
            //string result = EvenorOdd(i);
            //Console.WriteLine(result);
            //Console.WriteLine(Max(12,25,33));
            //Console.ReadKey();
            Console.WriteLine(Result(85.5, 55.6, 99.9));
            Console.ReadKey();
        }

    }
}
