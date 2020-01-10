using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnString
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string str = "welcome";
             Console.WriteLine(str.Length + "\n" + str.Replace("e", "k")+"\n"+str.ToUpper());
             Console.WriteLine(str.Contains("lc"));
             Console.WriteLine(string.Compare("hello", "Hello"));
             string str2 = "WELCOME";
             Console.WriteLine(str.Equals(str2, StringComparison.InvariantCultureIgnoreCase));
             */

            Employee[] eArray = new Employee[3] { ("gsan", "300", 20000),("kkk", "150", 50000),("gkgkg", "522", 10000)};

            foreach(Employee e in eArray)
            {
                Console.WriteLine(e.ToString());
            }
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("gsan", "300", 20000));
            elist.Add(new Employee("kkk", "150", 50000));
            elist.Add(new Employee("gkgkg", "522", 10000));
            foreach(Employee e in elist)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
