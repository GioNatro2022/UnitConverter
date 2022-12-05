using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Base
{
    public abstract class BaseConversion
    {

  
        abstract public decimal RightToLeftConversion(decimal value, decimal UnitModifier=1);
        abstract public decimal LeftToRightConversion(decimal value, decimal UnitModifier = 1);

    }
}
