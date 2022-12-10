using System;
using System.Collections.Generic;
using System.Linq;
using UnitConverter.Units;

namespace UnitConverter.Base
{
    public abstract class BaseConverter
    {
        protected abstract List<string> fromValueSynonims { get; set; }
        protected abstract List<string> toValueSynonims { get; set; }
        protected abstract BaseValidator validator { get; set; }
        protected abstract BaseConversion conversionLogic { get; set; }
        public BaseConverter()
        {
            validator = new BaseValidator(fromValueSynonims, toValueSynonims);
        }

        public decimal PerformConversion(string fromValueUnit, string toUnit)
        {
            decimal result;
            decimal modifier = 1;
            decimal secondModifier=1;

            validator.Validate(fromValueUnit, toUnit);

            fromValueUnit = fromValueUnit.ToLower();
            toUnit = toUnit.ToLower();



            var splits = fromValueUnit.Split(' ');
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
            {
                secondModifier = secondPrefix.First();
                toUnit = toUnit.Replace(secondPrefix.Key, "");
            }

            //if conversion is in same unit but different modifier
            if ((toValueSynonims.Contains(unit) && toValueSynonims.Contains(toUnit) )|| (fromValueSynonims.Contains(unit) && fromValueSynonims.Contains(toUnit)))
            {

                result = modifier / secondModifier * value;
            }
            else if (toValueSynonims.Contains(unit))// converting from left to right 
            {

                if(!fromValueSynonims.Contains(toUnit))
                    throw new ArgumentException($"Synonim for unit: {toUnit} not Found");
                result = conversionLogic.RightToLeftConversion(value* modifier, secondModifier);
                
            }
            else //converting from right to left 
            {
                if (!toValueSynonims.Contains(toUnit))
                    throw new ArgumentException($"Synonim for unit: {toUnit} not Found");
                result  = conversionLogic.LeftToRightConversion(value * modifier, secondModifier);

            }         
            return result;
        }
        

    }


}
