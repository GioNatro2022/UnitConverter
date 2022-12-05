using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units
{
    public static class SiPrefixes
    {
        public static readonly ILookup<string, decimal> Prefixes = new Dictionary<string, decimal>()
        {
            {"kilo", 1000 },
            {"giga", 1000000000 },
            {"mega", 1000000 }

        }.ToLookup(o => o.Key, o => o.Value);


    }
}
