using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_17
{
    internal class MyData : IDataProcess
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetMyData());
        }
    }
}
