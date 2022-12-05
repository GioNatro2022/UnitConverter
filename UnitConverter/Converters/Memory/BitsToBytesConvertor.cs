using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Base;

namespace UnitConverter.Converters.Memory
{
    public class BitsToBytesConvertor : BaseConverter
    {
        public BitsToBytesConvertor()
        {
            fromValueSynonims = new List<string>() { "bit", "bits", "b" };
            toValueSynonims = new List<string>() { "byte", "bytes" };
        }
        protected override List<string> fromValueSynonims { get; set; }
        protected override List<string> toValueSynonims { get; set; }
        protected override BaseConversion conversionLogic { get; set; }
    }

    public class BitsToBytesConversion : BaseConversion
    {
        public override decimal RightToLeftConversion(decimal value, decimal UnitModifier = 1)
        {
            return Math.Round(value * (decimal)0.125 * UnitModifier, 6);
        }

        public override decimal LeftToRightConversion(decimal value, decimal UnitModifier = 1)
        {
            return Math.Round(value / ((decimal)0.125 * UnitModifier), 6);
        }
    }
}
