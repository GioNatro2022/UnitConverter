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
            fromValueSynonims =new List<string>{"gram", "grams", "g" };
            toValueSynonims = new List<string> { "pound", "pounds", "lb", "lbs" };
            conversionLogic = new GramToPoundConversion();
            
        }

        protected override List<string> fromValueSynonims { get; set ; }
        protected override List<string> toValueSynonims { get; set; }
        protected override BaseConversion conversionLogic { get; set; }
    }


}
