using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tuple_04;

namespace Extention_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            ob.MyMethod1();
            ob.MyMethod2();
            ob.MyMethod4();
            var a = "saSaSaSAFAF".ToUpperFirstLetter();
            Console.WriteLine(a);
        }
    }
    static class NewExtentionForMyClass
    {
        public static void MyMethod4(this MyClass ob)
        {
            Console.WriteLine("MM4");
        }

        public static string ToUpperFirstLetter(this string ob)
        {
            if (ob.Length > 0)
            {
                ob = ob.ToLower();
                char[] chars = ob.ToCharArray();
                chars[0] = char.IsUpper(chars[0]) ? chars[0] : char.ToUpper(chars[0]);
                return new string(chars);
            }
            return ob;
        }
    }
}
