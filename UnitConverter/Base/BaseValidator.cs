using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var splits = input.Split(' ');

            if (splits.Length != 2)
                throw new ArgumentException("invalid input, value and unit should be separated by single space");

            var value = Convert.ToDecimal(splits[0]);
            var unit = splits[1];

            if (value<0)
                throw new ArgumentException("invalid input, value cannot be negative");

            if(!_fromValueSynonims.Contains(unit)  && !_toValueSynonims.Contains(unit))
                throw new ArgumentException($"invalid input, cannot find synonim for unit: {unit}");



        }

    }
}
