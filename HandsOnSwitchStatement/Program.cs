using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSwitchStatement
{
    class Program
    {
        public static void EvenorOdd(int i)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        public static void NaturalNos(int j)
        {
            for(int g=0;g<=j;g++)
            {
                Console.Write(g + "\t");
            }
        }

        public static void Multiplication(int k)
        {
            int a,c;
            for (a = 1; a <= 10; a++)
                c = k * a;
        }
        static void Main(string[] args)
        {
            int no;
            Console.WriteLine("eneter no");
            no = Convert.ToInt32(Console.ReadLine());
            switch(no)
            {
                case 1:
                    EvenorOdd(58);
                    break;
                case 2:
                    NaturalNos(100);
                    break;
                case 3:
                    Multiplication(5);
                    break;
                case '4':                   
                    break;
               default:
                    
                    break;
            }
        }
    }
}
