using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_17_2
{
    internal class MyClass : IInterface1, IInterface2
    {
        void IInterface1.MethodInterface()
        {
            Console.WriteLine("IInterface_1 method");
        }

        void IInterface2.MethodInterface()
        {
            Console.WriteLine("IInterface_2 method");
        }

        public void MethodInterface1()
        {
            Console.WriteLine("Implemented MethodInterface1() as IInterface1");
        }

        public void MethodInterface2()
        {
            Console.WriteLine("Implemented MethodInterface2() as IInterface2");
        }
    }
}
