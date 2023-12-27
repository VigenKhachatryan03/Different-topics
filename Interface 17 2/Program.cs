using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            //myClass.MethodInterface1();
            //myClass.MethodInterface2();

            //IInterface1 myInterface1 = new MyClass();
            //myInterface1.MethodInterface1();
            //IInterface2 myInterface2 = new MyClass();
            //myInterface2.MethodInterface2();
            IInterface1 myInterface11 = new MyClass();
            myInterface11.MethodInterface();
            IInterface2 myInterface21 = new MyClass();
            myInterface21.MethodInterface();

            IInterface1 myInterface12 = myClass as IInterface1;
            myInterface12.MethodInterface();
            IInterface2 myInterface22 = myClass as IInterface2;
            myInterface22.MethodInterface();
        }
    }
}
