using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface_17_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<ICar>();
            var human = new List<IHuman>();

            cars.Add(new BMW());
            cars.Add(new Audi());
            cars.Add(new Hibrid());

            human.Add(new Hibrid());

            foreach (var car in cars)
            {
                Console.WriteLine(car.Move(22222)) ;
            }

            Hibrid hibrid = new Hibrid();
            Console.WriteLine(((ICar)hibrid).Move(22222));
            Console.WriteLine(((IHuman)hibrid).Move(22222));
        }
    }
}
