using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Parent pto = new Parent();
                        Child cdo = new Child();
                        GrandChild gco = new GrandChild();
                        pto.getValues(12, "c#");
                        pto.Display();
                        cdo.getValues(23, "asp.net");
                        cdo.Display();
                        cdo.Calculate(30);
                        gco.getValues(33, "asp.core");
                        gco.Display();
                        gco.Calculate(20);
                        gco.multiply(10);
            */
            Vehicle ve = new Vehicle();
            car alto = new car();
            Bus volvo = new Bus();
            ve.start();
            ve.stop();
            alto.start();
            alto.stop();
            volvo.start();
            volvo.run();
            volvo.stop();
            Console.ReadLine();
        }
    }
}
