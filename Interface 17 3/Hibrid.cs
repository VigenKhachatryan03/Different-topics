using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_17_3
{
    internal class Hibrid : IHuman, ICar
    {
        int IHuman.Move(int distance)
        {
            return distance / 1000;
        }

        int ICar.Move(int distance)
        {
            return distance / 100;
        }
    }
}
