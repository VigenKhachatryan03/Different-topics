﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerForDictionari_28
{
    internal class Words
    {
        public string Source { get; set; }
        public string Translation { get; set; }
        public Words(string source, string translation)
        {
            Source = source;
            Translation = translation;
        }
    }
}
