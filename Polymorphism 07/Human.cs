using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_07
{
    internal class Human
    {
        public void GetDrive(Car car)
        {
            car.Drive();
        }
        //public void GetDrive(LuxCar car)
        //{
        //    car.Drive();
        //}
    }
}
