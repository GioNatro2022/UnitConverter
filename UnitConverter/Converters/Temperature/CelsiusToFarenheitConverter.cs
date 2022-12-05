using UnitConverter.Base;

namespace UnitConverter.Converters.Temperature
{
    public class CelsiusToFarenheitConverter : BaseConverter
    {

        public CelsiusToFarenheitConverter()
        {
            conversionLogic = new CelsiusToFarenheitConversion();
            fromValueSynonims = new List<string> {"celsius", "celsiuses", "c" };
            toValueSynonims = new List<string> { "farenheit", "farenheits", "f" };
        }
        protected override List<string> fromValueSynonims { get; set; }
        protected override List<string> toValueSynonims { get; set; }
        protected override BaseConversion conversionLogic { get; set; }
    }

    public class CelsiusToFarenheitConversion : BaseConversion
    {
        public override decimal LeftToRightConversion(decimal value, decimal UnitModifier = 1)
        {
            return Math.Round((value* 9/5)+32, 6);
        }

        public override decimal RightToLeftConversion(decimal value, decimal UnitModifier = 1)
        {
            return Math.Round((value -32) * 5/9, 6);

        }
    }
}
