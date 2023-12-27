using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Readonly_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GC.GetTotalMemory(false));
            //Console.WriteLine(GC.GetTotalMemory(false));

            //// const
            //MyClass ob = new MyClass();
            //int costField = MyClass.Field2;
            //// ob.Field2 !!!!

            ////readonly
            //int fieldRO = ob.FieldReadOnly;

            //Console.WriteLine(ob.FieldReadOnly);

            //Console.WriteLine(GC.GetTotalMemory(false));
            //Console.WriteLine(MyClass.Field);
            //Console.WriteLine(GC.GetTotalMemory(false));



            //MyClass obj = new MyClass();
            //Console.WriteLine(MyClass.Field2);



            //Console.WriteLine(myClassForConst.a);
            //Console.WriteLine(myClassForConst.a);

            //Console.WriteLine(MyClassForConst.CountOfHeads);


            //MyClassForConst myClassForConst = new MyClassForConst();
            //MyClassForConst myClassForConst2 = new MyClassForConst("Read Me 90000000000");

            //Console.WriteLine(myClassForConst.ReadVal);
            //Console.WriteLine(myClassForConst2.ReadVal);


            int age = 20;
            string hi = "Hello";
            string name = "KarApet";

            //Console.WriteLine(hi + " My name is " + name + " I am " + age + " years old");
            //Console.WriteLine("{0} My name is {1} I am {2} years old ", hi, name, age);
            Console.WriteLine($"{hi.ToUpper()} My name is {name.ToLower()} I am {age} years old ");

        }
    }
}
