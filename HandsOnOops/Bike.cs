using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOops
{
    class Bike
    {
        string name;
        string color;
       // public void 
        public void StartEngine()
        {
            Console.WriteLine("Bike started at " + DateTime.Now.Hour);
        }
        public void FillGas(int litre)
        {
            Console.WriteLine("Bike filled with " + litre + litre);
        }
        public int Travel(int distance,int speed)
        {
            int time = (int)(distance / speed);
            Console.WriteLine("you will reach destination " + time);
            return (time);
        }
        
    }
}
