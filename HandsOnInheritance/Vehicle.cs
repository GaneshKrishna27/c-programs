using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    abstract class Vehicle
    {
        protected string color;
        public Vehicle()  //parent default constructor invoke automatically for all child objects
        {
            this.color = "white";
            Console.WriteLine("constructor frm vehicle");

        }
        public Vehicle(string clr)  //parent parameter constructor has to be invoked using base keyword and providing value
        {
            this.color = clr;
            Console.WriteLine("parameter");
        }
        public abstract void fillfuel();
        public void start()
        {
            Console.WriteLine("vehicle started");

        }
        public void stop()
        {
            Console.WriteLine("vehicle stopped");
        }
    }
    
    class Bus:Vehicle
    {
        int seating;
        int speed;
        public Bus()
        {
            this.seating = 80;
            this.speed = 120;
        }
        public void run()
        {
            Console.WriteLine("bus is driving");
        }
        public void stop()
        {
            Console.WriteLine("bus is stopped");
        }

    }
    class car : Vehicle
    {
        int speed;
        string type;
        public car()
        {
            this.speed = 160;
            this.type = "standard";
            Console.WriteLine("constractor frm car ");
        }
        public car(string clr,int spd,string type)
        {
            this.speed = spd;
            this.type = type;
        }
        public void drive()
        {
            Console.WriteLine(this.color+" car is driving at speed "+this.speed);
        }
    }


}
