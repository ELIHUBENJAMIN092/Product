using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public int Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return Price * Quantity + (Price * Quantity * Tax);
        }

        public override string ToString()
        {
            return base.ToString() + $" - Type: Variable Price - Measurement: {Measurement} - Quantity: {Quantity}";
        }
    }
}