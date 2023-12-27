using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Armath_online_01
{
    internal abstract class Car
    {
        protected string NameJepe;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public virtual void Drive(string name, decimal price, string color)
        {
            Name = name;
            Price = price;
            Color = color;
        }
        public virtual void Drive(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public virtual void Info()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
