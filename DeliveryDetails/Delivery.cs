using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDetails
{
    class Delivery
    {
        public void Display(string bowler,string batman)
        {
            Console.WriteLine("name of the bowler and batman" + bowler + batman);
        }
        public void Display(long runs)
        {
            if(runs==6)
            {
                Console.WriteLine("its a six "+runs);

            }
            else if(runs==4)
            {
                Console.WriteLine("its a four "+runs);
            }
            else
            {
                Console.WriteLine("its a run " + runs);
            }
        }
    }
}
