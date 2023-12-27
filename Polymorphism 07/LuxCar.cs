using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Polymorphism_07
{
    internal class LuxCar:Car
    {
        //public new void Drive()
        //{
        //    Console.WriteLine("I am driving a LuxCar");
        //}
        public override void Drive()
        {
            Console.WriteLine("I am driving a LuxCar");
        }
    }
}
