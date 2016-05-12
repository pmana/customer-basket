using System.Collections.Generic;
using System.Linq;

namespace CustomerBasket
{
    public class Basket
    {
        private readonly List<Product> products;

        public Basket()
        {
            products = new List<Product>();
        }

        public void AddProducts(params Product[] productsToAdd)
        {
            products.AddRange(productsToAdd);
        }

        public decimal CalculateTotal()
        {
            return products.Sum(x => x.Value);
        }
    }
}
