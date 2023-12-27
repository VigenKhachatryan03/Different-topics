using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static void SetTupleMethod(Tuple<int, string, string> tupleStudent)
        {
            Console.WriteLine($"St name is {tupleStudent.Item2}, age is {tupleStudent.Item1}");
        } 
        static Tuple<int, string, string> SetTupleMethod()
        {
            var tupleStudent = new Tuple<int, string, string>(20, "Tom", "Smith");
            return tupleStudent;
        }
    }
}
