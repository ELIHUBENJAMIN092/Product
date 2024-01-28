using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class ComposedProduct : Product
    {
        public decimal Discount { get; set; }
        public List<Product> Products { get; } = new List<Product>();

        public override decimal ValueToPay()
        {
            decimal totalValue = 0;

            foreach (var product in Products)
            {
                totalValue += product.ValueToPay();
            }

            return totalValue - (totalValue * Discount);
        }

        public override string ToString()
        {
            return $"Composed Product - Discount: {Discount:P}";
        }
    }
}
