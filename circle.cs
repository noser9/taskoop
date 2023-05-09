using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    internal class circle:A
    {
        public double radius;
        const double PI = 3.14;
        public circle(double z)
        {
            this.radius = z;
        }
        public override void area()
        {
            Console.WriteLine(PI*radius*radius);
        }
        public override void circumference()
        {
            Console.WriteLine(2*PI*radius);
        }

    }
}
