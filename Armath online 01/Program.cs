using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armath_online_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ob = new Jepe("K6", 200000, 300, 300, 500);
            ob.Drive("Hakob", 200000, "Red");
            ob.Info();
        }

    }
}

