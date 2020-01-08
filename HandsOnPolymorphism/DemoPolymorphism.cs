using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnPolymorphism
{
    class DemoPolymorphism
    {
        int l, w, b;
        public void draw()
        {
            Console.WriteLine("a shape can be draw");
        }
        public void draw(int i,int w)
        {
            Console.WriteLine("a rectangle can be used");

        }
        public void draw(int i,int w,int b)
        {
            Console.WriteLine("a box can be drawn");
        }
    }
}
