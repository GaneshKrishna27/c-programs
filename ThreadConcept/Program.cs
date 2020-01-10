using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass tc = new ThreadClass();
            Thread th = new Thread(tc.countEven);
            Thread th1 = new Thread(tc.countOdd);
            th.Start();
            th1.Start();
            Console.WriteLine("main thread ends");
            Console.ReadLine();
        }
    }
    class ThreadClass
    {
        public void countEven()
        {
            for(int i=0;i<100;i+=2)
            {
                Console.WriteLine(i);
                if (i == 60) Thread.Sleep(4000);

            }
        }
        public void countOdd()
        {
            for(int i =1;i<100;i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }

}
