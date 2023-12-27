using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_17_3
{
    internal class Bob : IHuman
    {
        public int Move(int distance)
        {
            return distance / 10;
        }
    }
}
