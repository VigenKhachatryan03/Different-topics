using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Readonly_05
{
    internal class MyClass
    {
        public int Field = 100;
        public const int Field2 = 200;

        public readonly int FieldReadOnly = 300;

        public MyClass()
        {
            FieldReadOnly = 3;
        }

        public void SetValue()
        {
            //error
            //FieldReadOnly = 3;
        }
    }
}
