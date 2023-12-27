using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            //Car car = new LuxCar();
            //Car luxCar = new LuxCar();
            human.GetDrive(new Car());
            human.GetDrive(new LuxCar());
        }
    }
}
