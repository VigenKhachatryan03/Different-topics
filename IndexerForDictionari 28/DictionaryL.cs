using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerForDictionari_28
{
    internal class DictionaryL
    {
        public Words[] arr;
        public DictionaryL()
        {
            arr = new Words[3];
        }
        public string this[string source]
        {
            get
            {
                Words obj = null;
                foreach (var word in arr)
                {
                    if (word.Source == source)
                    {
                        obj = word;
                        break;
                    }
                }
                return obj.Translation;

            }
            set
            {
                foreach (var word in arr)
                {
                    if (word.Source == source)
                    {
                        word.Translation = value;
                        break;
                    }
                }
            }
        }
    }
}
