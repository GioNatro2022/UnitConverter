using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Base;

namespace UnitConverter.Converters.Distance
{
    public class MeterToInchConverter: BaseConverter
    {
        public MeterToInchConverter()
        {
            fromValueSynonims = new List<string>() { "meter", "meters", "m" };
            toValueSynonims = new List<string>(){"inch", "inches", "in"};
            validator = new BaseValidator(fromValueSynonims, toValueSynonims);
            conversionLogic = new MeterToInchCoversion();
        }
        protected override List<string> fromValueSynonims { get; set; }
        protected override List<string> toValueSynonims { get; set; }
        protected override BaseConversion conversionLogic { get; set; }
        protected override BaseValidator validator { get; set; }

    }

    public class MeterToInchCoversion : BaseConversion
    {
        public override decimal LeftToRightConversion(decimal value, decimal UnitModifier = 1)
        {

            return Math.Round(value * (decimal)39.37 * UnitModifier, 6);

        }

    
        public override decimal RightToLeftConversion(decimal value, decimal UnitModifier = 1)
        {
            return Math.Round(value / ((decimal)39.37 * UnitModifier), 6);
        }
    }
}
