using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explisite_Implisite_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            long y = x;

            int z = (int)y;

            Second second = new Second();

            Time time = new Time();

            Time time1 = second;

            Console.WriteLine(time1.H);
            Console.WriteLine(time1.M);
            Console.WriteLine(time1.S);
        }
    }
}
