using System;

namespace Armath_online_01
{
    internal class Jepe : Car
    {

        string NameJepe;
        decimal priceJepe;
        int speed;
        int width;
        int length;

        public Jepe(string NameJepe, decimal priceJepe, int speed, int width, int length)
        {
            this.NameJepe = NameJepe;
            this.priceJepe = priceJepe;
            this.speed = speed;
            this.width = width;
            this.length = length;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"I am good CAAR, my color is {Color}");
        }
    }
}

