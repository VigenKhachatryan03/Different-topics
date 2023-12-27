using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_17_4
{
    internal interface IMyInterface
    {
        string DisplayInfo();
    }
    class MyClass : IMyInterface
    {
        public string DisplayInfo()
        {
            return "Hello DisplayInfo";
        }
        public void MethodFromMyClass()
        {
            Console.WriteLine("Method From My Class");
        }
    }
}
