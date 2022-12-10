using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Units;

namespace UnitConverter.Base
{
    public class BaseValidator
    {
        private List<string> _fromValueSynonims;
        private List<string> _toValueSynonims;
        public BaseValidator(List<string> fromValueSynonims, List<string> toValueSynonims)
        {
            _fromValueSynonims= fromValueSynonims;
            _toValueSynonims = toValueSynonims;
        }

        public void Validate(string input, string toUnit)
        {

            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(toUnit))
                throw new ArgumentException("inputs cannot be empty!");
            input = input.ToLower();
            toUnit = toUnit.ToLower();
            var splits = input.Split(' ');
            

            if (splits.Length != 2)
                throw new ArgumentException("invalid input, value and unit should be separated by single space");

            decimal value;
            var res = decimal.TryParse(splits[0], out value);
            if(!res)
                throw new ArgumentException("invalid input, value cannot be convreted to decimal");

            var unit = splits[1];

            if (value<0)
                throw new ArgumentException("invalid input, value cannot be negative");
            


            var prefix = SiPrefixes.Prefixes.Where(p => unit.Contains(p.Key)).FirstOrDefault();
            var secondPrefix = SiPrefixes.Prefixes.Where(p => toUnit.Contains(p.Key)).FirstOrDefault();

            if (prefix != null)
            {
                unit = unit.Replace(prefix.Key, "");
            }

            if (secondPrefix != null)
            {
                toUnit = toUnit.Replace(secondPrefix.Key, "");
            }
            if (!_fromValueSynonims.Contains(unit)  && !_toValueSynonims.Contains(unit))
                throw new ArgumentException($"invalid input, cannot find synonim for unit: {unit}");



        }

    }
}
