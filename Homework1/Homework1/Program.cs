using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        struct Vec2
        {
            public float x, y;
            public override string ToString()
            {
                return "" + x + "," + y;
            }
        }
        struct Circle
        {
            public Vec2 center;
            public float radius;
            public override string ToString()
            {
                return "" + center + ":" + radius;
            }
        }
        static void Main(string[] args)
        {
            var circle = new Circle();
            var point2 = new Vec2();
            point2.x = point2.y = 3;
            circle.center = point2;

            var str = circle.ToString();

            Console.WriteLine("{0}", str);
            Console.ReadKey();
        }
    }
}
