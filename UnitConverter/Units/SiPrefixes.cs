using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Units
{
    public static class SiPrefixes
    {
        public static readonly ILookup<string,decimal> Prefixes = new Dictionary<string, decimal>()
        {
            //{"quetta", 1000000000000000000000000000000},
            //{"ronna",  1000000000000000000000000000},
            //{"yotta",  1000000000000000000000000},
            //{"zetta",  1000000000000000000000},
            {"exa",    1000000000000000000},
            {"peta",   1000000000000000},
            {"tera",   1000000000000},
            {"giga",   1000000000},
            {"mega",   1000000},
            {"kilo",   1000},
            {"K",      1000},
            {"hecto",  100},
            {"deca",   10},
            {"deci",   (decimal)0.1},
            {"centi",  (decimal)0.01},
            {"milli",  (decimal)0.001},
            {"micro",  (decimal)0.000001},
            {"nano",   (decimal)0.000000001},
            {"pico",   (decimal)0.000000000001},
            {"femto",  (decimal)0.000000000000001},
            {"atto",   (decimal)0.000000000000000001},
            {"zepto",  (decimal)0.000000000000000000001},
            {"yocto",  (decimal)0.000000000000000000000001},
            {"ronto",  (decimal)0.000000000000000000000000001},
            {"quecto", (decimal)0.000000000000000000000000000001},

        }.ToLookup(o => o.Key, o => o.Value);


    }
}
