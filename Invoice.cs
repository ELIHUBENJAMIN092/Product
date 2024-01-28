using Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Invoice : IPay
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal ValueToPay()
        {
            decimal totalValue = 0;
            foreach (var product in _products)
            {
                totalValue += product.ValueToPay();
            }

            return totalValue;
        }

        public override string ToString()
        {
            return $"INVOICE\n-------------------------------------------------\nTotal Value to Pay: {ValueToPay():C}\n";
        }
}