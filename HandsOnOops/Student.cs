using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOops
{
    class Student
    {
        int rollno;
        int sem;
        int marks;
        public string Name { get; set; }
        private string branch;
        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }
        public string Branch
        {
            get { return branch; }
            set { branch = value; }
        }
        public int Rollno
        {
            get { return rollno; }
            set { rollno = value; }
        }


        public int Sem
        {
            get { return sem; }
            set { sem = value; }
        }

        public Student()
        {
            this.rollno = 0;
            this.Name = "";
            this.marks = 0;
            this.sem = 3;
            this.branch = "it";
        }
        public Student(string name,int rollno,string branch,int sem,int marks)
        {
            this.rollno = rollno;
            this.Name = name;
            this.marks = marks;
            this.sem = sem;
            this.branch = "branch";
        }
        public void AcceptStudentDetails()
        {
            Console.WriteLine("enter the marks");
            this.marks =int.Parse(Console.ReadLine());
            Console.WriteLine("enter branch");
            this.branch = Console.ReadLine();
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("displayed");
            Console.WriteLine(this.Name + "\n" + this.rollno + "\n" + this.marks+"\n"+this.branch+"\n"+this.sem);
        }

    }
}
