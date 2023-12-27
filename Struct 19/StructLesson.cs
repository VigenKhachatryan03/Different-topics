using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_19
{
    internal class MyClass
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void DisplayInfo() {
            Console.WriteLine($"Age:{Age}--Name:{Name}");
        }
    }
    internal struct MyStruct:IBase
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public MyStruct(int Age, string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Age:{Age}--Name:{Name}");
        }

    }
    interface IBase
    {

    }

}
