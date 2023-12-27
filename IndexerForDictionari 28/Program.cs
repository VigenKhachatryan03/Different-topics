using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IndexerForDictionari_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DictionaryL dictionary = new DictionaryL()
            {
                arr = new[]
                {
                    new Words("red", "karmir"),
                    new Words("green", "kanach"),
                    new Words("blue", "kaput"),
              
                }
            };
            Console.WriteLine(dictionary["red"]);
            dictionary["blue"] = "kaput";
        }

    }
}
