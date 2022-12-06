using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Base;

namespace UnitConverter.Converters.Memory
{
    public class LitersToPintConverter: BaseConverter
    {
        public LitersToPintConverter()
        {
            fromValueSynonims = new List<string>() { "liter", "liters", "l" };
            toValueSynonims = new List<string>() { "pint", "pints", "p" };
            validator = new BaseValidator(fromValueSynonims, toValueSynonims);
            conversionLogic = new LiterstoPintConversion();
        }
        protected override List<string> fromValueSynonims { get; set; }
        protected override List<string> toValueSynonims { get; set; }
        protected override BaseConversion conversionLogic { get; set; }
        protected override BaseValidator validator { get; set; }

    }

    public class LiterstoPintConversion : BaseConversion
    {
        public override decimal RightToLeftConversion(decimal value, decimal UnitModifier = 1)
        {
            return Math.Round(value / ((decimal)2.113 * UnitModifier), 6);
        }

        public override decimal LeftToRightConversion(decimal value, decimal UnitModifier = 1)
        {
            return Math.Round(value * (decimal)2.113 * UnitModifier, 6);

        }
    }
}
