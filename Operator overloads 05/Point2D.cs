using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloads_05
{
    public class Point2D
    {
        private int _x, _y;

        public Point2D(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public Point2D()
        {        }
        public void ShowInfo()
        {
            Console.WriteLine(_x + "\t" + _y);
        }

        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            Point2D point = new Point2D();
            point._x = point1._x + point2._x;
            point._y = point1._y + point2._y;
            return point;
        }
        public static Point2D operator ++(Point2D point2D)
        {
            Point2D result = new Point2D();
            result._x = point2D._x + 1;
            result._y = point2D._y + 1;
            return result;
        }
        public static Point2D operator --(Point2D point2D)
        {
            Point2D result = new Point2D();
            result._x = point2D._x - 1;
            result._y = point2D._y - 1;
            return result;
        }
        public static bool operator >(Point2D point1, Point2D point2)
        {
            if (point1._x > point2._x)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Point2D point1, Point2D point2)
        {
            if (point1._x < point2._x)
            {
                return true;
            }
            return false;
        }
        public static bool operator true(Point2D point2D)
        {
            if (point2D._x !=0 || point2D._y !=0)
            {
                return true;
            }
            return false;
        }
        public static bool operator false(Point2D point2D)
        {
            if (point2D._x ==0 && point2D._y ==0)
            {
                return true;
            }
            return false;
        }

        // and etc (||, &&, ==, !==, !,  )
        
    }
}
