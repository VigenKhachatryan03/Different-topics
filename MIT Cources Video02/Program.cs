using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIT_Cources_Video02
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;


            do
            {
                key = Console.ReadKey().Key;
                Console.WriteLine();
                Console.WriteLine((int)key);
                ClassKey classKey = new ClassKey(key );
                classKey.GetInfo();
            }
            while (key != ConsoleKey.Escape);










        }

    }

}
