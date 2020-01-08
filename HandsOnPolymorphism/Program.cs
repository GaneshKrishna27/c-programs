using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  DemoPolymorphism d = new DemoPolymorphism();
              d.draw();
              //d.draw(10);
              d.draw(10, 20);
              d.draw(10, 20, 30);
              Console.ReadLine();*/

            A obj;

            
            obj = new B();
            obj.display();
            obj = new C();
            obj.display();

        }
    }
}
