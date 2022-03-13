using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumerMercado
{
    class FixedPriceProduct : Product
    {

        public override decimal ValueToPay()
        {
            return Price + (Price *(decimal)Tax);
        }
        public override string ToString()
        {
            return $"\n\t{base.ToString()}" +
                 $"\n\t Value to Pay.....:{$"{ValueToPay():C2}",18} ";
        }
    }
}
