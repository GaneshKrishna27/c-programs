using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton employee =Singleton.GetInstance;
            employee.printDetails("hi");
            Singleton student =Singleton.GetInstance;
            student.printDetails("gaa");

        }
    }


    class Singleton
    {
        static int count = 0;
        static Singleton Instance=null; //memory not allocated so object does
        public static Singleton GetInstance
        {
            get
            {//Instance is null memory will be alloted
                if (Instance == null) return new Singleton();//obj
                else return Instance;//existing instance ref returned
            }
        }
        private Singleton()//contructor private
        {
            count++;
            Console.WriteLine(count);
        }
        public void printDetails(string s)
        {
            Console.WriteLine("printing " + s);
        }
    }
}

