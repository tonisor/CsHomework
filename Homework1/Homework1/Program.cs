using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        struct Vec3
        {
            public double x, y, z;
            public override string ToString()
            {
                return "" + x + "," + y + "," + z;
            }
            public override bool Equals(Object obj)
            {
                if (!(obj is Vec3))
                    return false;
                return Equals((Vec3)obj);
            }
            public bool Equals(Vec3 vec)
            {
                return x == vec.x && y == vec.y && z == vec.z;
            }
            public override int GetHashCode()
            {
                return x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode();
            }
            public double this[int key]
            {
                get
                {
                    if (key == 0)
                        return x;
                    else if (key == 1)
                        return y;
                    else if (key == 2)
                        return z;
                    else
                        throw new IndexOutOfRangeException();
                }
                set
                {
                    if (key == 0)
                        x = value;
                    else if (key == 1)
                        y = value;
                    else if (key == 2)
                        z = value;
                    else
                        throw new IndexOutOfRangeException();
                }
            }
            public static explicit operator double[](Vec3 v)  // explicit byte to digit conversion operator
            {
                return new double[] { v.x, v.y, v.z };
            }
        }
        static void Main(string[] args)
        {
            var point1 = new Vec3();
            point1.x = point1.y = point1.z = 3;
            point1[1] = 1;
            var str = point1.ToString();
            var d = (double[])point1;
            Console.WriteLine("{0}", d[0]);
            Console.ReadKey();
        }
    }
}
