using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloads_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D point1 = new Point2D(10, 20);
            point1.ShowInfo();
            Point2D point2 = new Point2D(1, -3);
            point2.ShowInfo();

            point1++;
            point2--;

            point1.ShowInfo();

            Point2D point3 = point1 + point2;
            point3.ShowInfo();

            if (point1>point2)
            {
                Console.WriteLine("p1 is bigger");
            }
        }
    }
}
