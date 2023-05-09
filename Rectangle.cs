using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    internal class Rectangle:A
    {
        int heigh;
        int width;
        public Rectangle(int x1,int x2)
        {
            this.heigh = x1;
            this.width = x2;
        }
        public override void area()
        {
            Console.WriteLine(heigh*width);
        }
        public override void circumference()
        {
            Console.WriteLine((heigh+width)*2);
        }
    }
}
