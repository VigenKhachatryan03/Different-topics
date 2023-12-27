using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIT_Cources_Video02
{
    public class ClassKey
    {
        private ConsoleKey _consoleKey;
        public ClassKey(ConsoleKey consoleKey)
        {
            _consoleKey = consoleKey;
        }
        public void GetInfo()
        {
            Console.WriteLine($"You pressrd {_consoleKey}");
        }
    }
}
