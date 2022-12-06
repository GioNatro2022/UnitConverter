using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Base;

namespace UnitConverter.Converters.Volume
{
    public class LitersToCubicInchConverter: BaseConverter
    {
        public LitersToCubicInchConverter()
        {
            fromValueSynonims = new List<string>() { "liter", "liters", "l" };
            toValueSynonims = new List<string>() { "cubic inch", "cubic inches", "cubicinch", "cubicinches" };
            conversionLogic = new LittersToCubicInchConversion();
            validator = new BaseValidator(fromValueSynonims, toValueSynonims);

        }
        protected override List<string> fromValueSynonims { get; set; }
        protected override List<string> toValueSynonims { get; set; }
        protected override BaseConversion conversionLogic { get; set; }
        protected override BaseValidator validator { get; set; }

    }

    public class LittersToCubicInchConversion: BaseConversion
    {
        public override decimal RightToLeftConversion(decimal value, decimal UnitModifier = 1)
        {
            return Math.Round(value / ((decimal)61.024 * UnitModifier), 6);

        }

        public override decimal LeftToRightConversion(decimal value, decimal UnitModifier = 1)
        {
            return Math.Round(value * (decimal)61.024 * UnitModifier, 6);

        }
    }
}
