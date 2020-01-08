using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStudentDetails
{
    class student
    {
        static string collegename;
        int rollno;
        string name;
        int classes;
        int sem;
        string branch;

        public void displayresult()
        {
            int sum = 0;
            int[] marks = new int[5];

            for (int i = 0; i < 5; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + marks[i];
            }
            int avg = sum / 5;
            int f = 0;
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    f = 1;
                    Console.WriteLine("failed");
                }
            }
            .
            if (f == 0)
            { 
            if (avg < 50)
            {
                Console.WriteLine("fail");

            }
            else
                Console.WriteLine("passed");
        }
        }
        public student(int rollno,
            string name,
            int classes,
            int sem,
            string branch)

        {
            this.name = name;
            this.classes = classes;
            this.rollno = rollno;
            this.sem = sem;
            this.branch = branch;



        }
        public void display()
        {
            Console.WriteLine(name + " " + classes + " " + rollno + " " + sem + " " + branch);
        }
        public static void clgname()
        {
            collegename = Console.ReadLine();
            Console.WriteLine(collegename);
        }
    }
}