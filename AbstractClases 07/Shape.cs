using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClases_07
{
    internal abstract class Shape
    {
        public abstract void GetSurface();
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Abstract class");
        }
    }

    class Triangle:Shape 
    {

        public override void GetSurface()
        {
            
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }

    }
}
