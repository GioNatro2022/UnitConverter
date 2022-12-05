using UnitConverter.Units;

namespace UnitConverter.Base
{
    public abstract class BaseConverter
    {

       // private BaseSynonim rightValue;
       // private BaseSynonim leftValue;
        protected abstract List<string> fromValueSynonims { get; set; }
        protected abstract List<string> toValueSynonims { get; set; }
        protected abstract BaseConversion conversionLogic { get; set; }
        

        public decimal PerformConversion(string fromValueUnit, string toUnit)
        {
            decimal result;
            decimal modifier = 1;
            decimal secondModifier=1;
            fromValueUnit=fromValueUnit.ToLower();
            toUnit = toUnit.ToLower();

            var splits = fromValueUnit.Split(' ');
            
            if (splits.Length!=2)
                throw new ArgumentException("invalid input, value and unit should be separated by single space");
            
            var value = Convert.ToDecimal(splits[0]);
            var unit = splits[1];
            var prefix= SiPrefixes.Prefixes.Where(p => unit.Contains(p.Key)).FirstOrDefault();
            var secondPrefix= SiPrefixes.Prefixes.Where(p => toUnit.Contains(p.Key)).FirstOrDefault();
            if (prefix != null)
            {
                unit = unit.Replace(prefix.Key, "");
                modifier = prefix.First();
            }

            if (secondPrefix != null)
                secondModifier = secondPrefix.First();


            if (toValueSynonims.Contains(unit))
            {

                if(!fromValueSynonims.Contains(toUnit))
                    throw new ArgumentException($"Synonim for unit: {toUnit} not Found");
                result = conversionLogic.RightToLeftConversion(value* modifier, secondModifier);
                
            }
            else if(fromValueSynonims.Contains(unit))
            {
                if (!toValueSynonims.Contains(toUnit))
                    throw new ArgumentException($"Synonim for unit: {toUnit} not Found");
                result  = conversionLogic.LeftToRightConversion(value * modifier, secondModifier);

            }
            else
            {
                throw new ArgumentException($"Synonim for unit: {unit} not Found");
            }

            return result;



        }
        

    }


}
