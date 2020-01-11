using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    interface Ifactory
    {
        void manufacture(int cnt);
    }
    class Bike : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("manufacturing " + cnt);
        }
    }
    class Car : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("car manufacturing " + cnt);
        }
    }
    abstract class VehicleFactory
    {
        public abstract Ifactory generateVehicles(string type );
    }
    class ConcreateVehicleFactory:VehicleFactory
    {
        public override Ifactory generateVehicles(string type)
        {
            if (type == "Bike") return new Bike();
            else return new Car();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory obj = new ConcreateVehicleFactory();
            Ifactory myVehicle=obj.generateVehicles("Bike");
            myVehicle.manufacture(10);
            myVehicle = obj.generateVehicles("car");
            myVehicle.manufacture(20);
             
        }
    }
}
