using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIterativeStatements
{
    class Program
    {
        public static void Greet(String name)
        {
            int flag = 1;
            while(flag<=10)
            {
                Console.WriteLine("hello " + name);
                flag++;
            }
        }
        public static void DisplayNaturalNos(int i)
        {
            int flag = 1;
            while(flag<=i)
            {
                Console.Write(flag+ " ");
                flag++;
            }
        }
        public static void WholeNos(int i)
        {
            int flag = 0;
            do
            {
                Console.Write(flag + "\t");
                flag++;
            } while (flag <= i);
        }
        public static int ReturnFactorial(int k)
        {
            int fact = 1;
            for(int i =1;i<=k;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static void DisplayEven(int no)
        {
           
            for(int j=1;j<=no;j++)
            {
                if (j % 2 == 1)
                    continue;
                Console.Write(j + "\t");
            }
        }
        public static string CheckVowel(char ch)
        {
            string result = null;
            switch(ch)
            {
                case 'a':
                    result = "vowel";
                    break;
                case 'e':
                    result = "vowel";
                    break;
                case 'i':
                    result = "vowel";
                    break;
                case 'o':
                    result = "vowel";
                    break;
                case 'u':
                    result = "vowel";
                    break;
                default:
                    result = "invalid";
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            //Greet("gany");
            //DisplayNaturalNos(100);
            //WholeNos(100);
            //Console.WriteLine(ReturnFactorial(5));
            //DisplayEven(100);
            Console.WriteLine(CheckVowel('0'));
        }
    }
}
