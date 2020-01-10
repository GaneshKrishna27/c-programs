using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStudentData1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Undergraduate ug = new Undergraduate();
            //graduate g = new graduate();
            Student s;
            Console.WriteLine("1.Undergraduate\n2.graduate");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("enter student name");
                string name = Console.ReadLine();
                Console.WriteLine("enter student id");
                int StudentId = int.Parse(Console.ReadLine());
                Console.WriteLine("enter student Grade");
                float grade = float.Parse(Console.ReadLine());
                s = new Undergraduate();
                bool res = s.Ispassed(grade);
                if(res==true)
                {
                    Console.WriteLine("pass");
                }
                else
                {
                    Console.WriteLine("fail");
                }
                
            }
            else if (choice == 2)
            {
                Console.WriteLine("enter student name");
                string name = Console.ReadLine();
                Console.WriteLine("enter student id");
                int StudentId = int.Parse(Console.ReadLine());
                Console.WriteLine("enter student Grade");
                float grade = float.Parse(Console.ReadLine());
                s = new Undergraduate();
                bool res = s.Ispassed(grade);
                if (res == true)
                {
                    Console.WriteLine("pass");
                }
                else
                {
                    Console.WriteLine("fail");
                }
            }
            else
                Console.WriteLine("invalid data");
            
            Console.ReadLine();
        }
    }
}
