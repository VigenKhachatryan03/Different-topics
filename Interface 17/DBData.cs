using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_17
{
    internal class DBData : IDataProvider
    {
        public string GetMyData()
        {
            return "Data comes from DB";
        }
    }
}
