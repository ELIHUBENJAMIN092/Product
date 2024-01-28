using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return Price + (Price * Tax);
        }

        public override string ToString()
        {
            return base.ToString() + " - Type: Fixed Price";
        }
    }
}