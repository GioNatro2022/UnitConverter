using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Base;

namespace UnitConverter.Converters.Weight
{
    public class GramToPoundConverter : BaseConverter
    {
        public GramToPoundConverter()
        {
            fromValueSynonims =new List<string>{"gram", "grams", "g", "gm" };
            toValueSynonims = new List<string> { "pound", "pounds", "lb", "lbs" };
            validator = new BaseValidator(fromValueSynonims, toValueSynonims);
            conversionLogic = new GramToPoundConversion();
            
        }

        protected override List<string> fromValueSynonims { get; set ; }
        protected override List<string> toValueSynonims { get; set; }
        protected override BaseConversion conversionLogic { get; set; }
        protected override BaseValidator validator { get; set; }

    }
    public class GramToPoundConversion : BaseConversion
    {


        public override decimal LeftToRightConversion(decimal value, decimal UnitModifier = 1)
        {
            return Math.Round(value / ((decimal)453.6 * UnitModifier), 6);
        }

        public override decimal RightToLeftConversion(decimal value, decimal UnitModifier = 1)
        {

            return Math.Round(value * ((decimal)453.6 / UnitModifier), 6);

        }
    }

}
