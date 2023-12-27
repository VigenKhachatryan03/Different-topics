using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDataProcess myData = new MyData();
            myData.ProcessData(new FileData());
            myData.ProcessData(new DBData());
        }
    }
}
