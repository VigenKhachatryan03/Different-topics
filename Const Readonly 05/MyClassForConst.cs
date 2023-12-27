using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Const_Readonly_05
{
    internal class MyClassForConst
    {
        public int a = 1;
        public const int CountOfHeads = 3;
        public readonly string ReadVal;

        public MyClassForConst()
        {
            ReadVal = "Read Me 010101001010010";
        }
        public MyClassForConst(string ReadVal)
        {
            this.ReadVal = ReadVal;
        }
    }
}
