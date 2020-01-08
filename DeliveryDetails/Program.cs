using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choice the sports \n1.Player details of the delivery\n2.runs details of the delivery");
            int choice = int.Parse(Console.ReadLine());
            Delivery d = new Delivery();


            if (choice == 1)
            {
                Console.WriteLine("enter bowler name");
                string name = Console.ReadLine();
                Console.WriteLine("enter batman name");
                string batman = Console.ReadLine();
                
                d.Display(name, batman);
            }
            else if (choice == 2)
            {
                Console.WriteLine("enter num of runs");
                long runs = long.Parse(Console.ReadLine());
                d.Display(runs);

            }
            else
                Console.WriteLine("invalid option");


            Console.ReadKey();
        }
    }
}
