using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollections
{
    class DemoDictionary
    {
        static void Main(string [] args)
        {
            
            Console.WriteLine("enter no of emps");

            int count = int.Parse(Console.ReadLine());
            Dictionary<string, int> dt = new Dictionary<string, int>();
            int salary; string name;
            for(int c=0;c<count;c++)
            {
                Console.WriteLine("enter name of emps");
                name = Console.ReadLine();
                Console.WriteLine("enetr the salary of emp");
                salary = int.Parse(Console.ReadLine());
                dt.Add(name, salary);

            }
            int hsalary = 0;
            string hname = "";
            foreach(KeyValuePair<string,int>emp in dt)
            {
                if (emp.Value > hsalary) 
                {   
                    hsalary = emp.Value;
                    hname = emp.Key; 
                }
            }
            Console.WriteLine("the highest pais emps is " + hname);
            Console.ReadLine();

            


        }

    }
}
