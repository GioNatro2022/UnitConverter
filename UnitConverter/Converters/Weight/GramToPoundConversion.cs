using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Base;

namespace UnitConverter.Converters.Weight
{
    public class GramToPoundConversion : BaseConversion
    {

       
        public override decimal LeftToRightConversion(decimal value , decimal UnitModifier = 1)
        {
            return Math.Round(value / ((decimal)453.6*UnitModifier), 6);
        }

        public override decimal RightToLeftConversion(decimal value, decimal UnitModifier = 1)
        {

            return Math.Round(value * ((decimal)453.6/UnitModifier), 6);

        }
    }
}
