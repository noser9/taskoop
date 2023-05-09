using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle(8);
            c.area();
            c.circumference();
            Rectangle r = new Rectangle(4,2);
            r.area();
            r.circumference();
        }
    }
}
