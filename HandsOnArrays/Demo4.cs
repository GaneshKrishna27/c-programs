using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo4
    {
        static void Main()
        {
            string[] names = new string[8] { "ganesh", "krishna", "sai", "jeeva", "krishnasai", "gk", "sgk", "gsgk" };
            int flag = 0;
            Console.WriteLine("enter name");
            string input = Console.ReadLine();
            foreach (string i in names)
            {
                if (input == i)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                Console.WriteLine("name not exist");
            else
                Console.WriteLine("name exist");                   
        }
    }
}
