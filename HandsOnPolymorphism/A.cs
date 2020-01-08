using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPolymorphism
{
    abstract class A
    {
        public abstract void display(); 
        //public void display()
        //{
        //    Console.WriteLine("A display");
        //}
    }
    class B:A
    {
        public override void display()
        {
            Console.WriteLine("B display");
        }
    }
    class C : A
    {
        public override void display()
        {
            Console.WriteLine("C display");
        }
    }
}
