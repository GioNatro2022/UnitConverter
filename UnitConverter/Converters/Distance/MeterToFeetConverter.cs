using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Base;

namespace UnitConverter.Converters.Distance
{
    public class MeterToFeetConverter : BaseConverter
    {
        public MeterToFeetConverter()
        {
            fromValueSynonims = new List<string>() { "meter", "meters", "m"};
            toValueSynonims = new List<string>() { "feet", "feets", "ft" };

        }

        protected override List<string> fromValueSynonims { get ; set; }
        protected override List<string> toValueSynonims { get; set ; }
        protected override BaseConversion conversionLogic { get; set ; }
    }

    public class FeetToMeterConversion : BaseConversion
    {
        public override decimal LeftToRightConversion(decimal value, decimal UnitModifier = 1)
        {

            return Math.Round(value * (decimal)3.281 * UnitModifier,6);

        }


        public override decimal RightToLeftConversion(decimal value, decimal UnitModifier = 1)
        {
            return Math.Round(value / ((decimal)3.281 * UnitModifier), 6);
        }
    }
}
