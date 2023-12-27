using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarKeyword_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var res = calculate(50);
            res = (23, 32, 34, 42, "s");

            Console.WriteLine(res);

        

            //var number = (21, 22, 33, 23456, "hgh");
            //Console.WriteLine(number.Item1);
            //Console.WriteLine(number.Item2);
            //Console.WriteLine(number.Item1 + number.Item2);

        }

        static (int, int, int, int, string) calculate(int side)
        {
            int erankyun = 3*side;
            int qarankyun = 4 * side;
            int hngankyun = 5 * side;
            int vecankyun = 6 * side;

            var result = (erankyun, qarankyun, hngankyun, vecankyun, "ayo");

            return result;
        }
    }
}
