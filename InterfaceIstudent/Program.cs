using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIstudent
{
    class Employee
    {
        string str,str1;
        int i;
        public Employee(string str,string str1,int i)
        {
            this.str = str;
            this.str1 = str1;
            this.i = i;
        }
        public int salary { get => salary; set => salary = value; }
    }
    public class salaryException:Exception
    {
        public salaryException(string s):base(s)
        {
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee("sena", "100", 0);
            {
                try
                {
                    if (emp.salary == 0) throw new salaryException("salary cannot be zero");
                }
                catch(salaryException e)
                {
                    Console.WriteLine(e.Message + "" + e.StackTrace);
                }
            }

        }
    }
}
