using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssignments
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
        public static void Temperature(double f)
        {
            double c;
            c = ((f - 32) * 5) / 9; ;
            Console.WriteLine("celsius" + c);
        }
        public static void Factorial(int num)
        {
            int fact=1;
            for (int j = 1; j <= num; j++)
            {
                fact = fact * j;
            }
            Console.Write("Factorial of " + num + " is: " + fact);
        }
        public static void Fibonacci(int n)
        {
            int f1 = 0,f2=1,f3;
            Console.WriteLine(f1 + "," + f2);

            for (int i = 0; i <= 40; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                if (f3 >= 40)
                    break;
                Console.Write(f3+"\t");
            }          
        }
        public static void Multiplication(int num)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + num * i);
            }
        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("HI!"+ name);
            Console.WriteLine("Welcome to the world of C#");
            int a, b,i;
            Console.WriteLine("Enter the Two Numbers : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for(i=a;i<=b;i++)
            {
                Console.Write(" " + i);
            }


            Console.WriteLine("enter no");
            int i = int.Parse(Console.ReadLine());
            string result = EvenorOdd(i);
            Console.WriteLine(result);

            Console.WriteLine("enter fahrenheit");
            double f= Convert.ToDouble(Console.ReadLine());
            Temperature(f);
            
            Console.WriteLine("enter factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            Factorial(num);
            */
            //Fibonacci(40);

            /*double prd1 = 22.5;
            double prd2 = 44.5;
            double prd3 = 9.98;
            Console.WriteLine("Enter product number(1 or 2 or 3) and quantity:");
            int prdnum = int.Parse(Console.ReadLine());
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;
            switch (prdnum)
            {
                case 1:
                    price = prd1 * quantity;
                    Console.WriteLine("Product price=" + prd1);
                    Console.WriteLine("Total price=" + price);
                    break;
                case 2:
                    price = prd2 * quantity;
                    Console.WriteLine("Product price=" + prd2);
                    Console.WriteLine("Total price=" + price);
                    break;

                case 3:
                    price = prd3 * quantity;
                    Console.WriteLine("Product price=" + prd3);
                    Console.WriteLine("Total price=" + price);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }*/
            /*
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            Multiplication(num);
            */
            for (int i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();

        }

    }
}
