using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_14
{
    public class Rectangle : Figure
    {
        public Rectangle(double w, double h) : base(w, h, "զուգահեռագիծ")
        {

        }
        public Rectangle(double w, double h, string type) : base(w, h, type)
        {

        }
        public Rectangle(double w) : base(w, "քառակուսի")
        {

        }
        public bool IsSquare()
        {
            if (Width == Height) return true;
            return false;
        }
        public override double Surface()
        {
            return Width * Height;
        }
        public override double Perimeter()
        {
            return 2*(Width+Height);
        }
    }
}
