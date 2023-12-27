using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;
            Figure[] figures = new Figure[3];
            figures[0] = new Rectangle(20, 30);
            figures[1] = new Rectangle(10, 50, "Shape");
            figures[2] = new Rectangle(10, 50, "Rectangle");

            for (int i = 0; i < figures.Length; i++)
            {
                figures[i].DisplayInfo();
                Console.WriteLine(figures[i].Surface());
                Console.WriteLine(new string('_', 100));
            }
        }
    }
}
