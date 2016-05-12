using System.Linq;

namespace CustomerBasket
{
    public class Basket
    {
        private Product[] products;

        public void AddProducts(params Product[] productsToAdd)
        {
            products = productsToAdd;
        }

        public decimal CalculateTotal()
        {
            return products.Sum(x => x.Value);
        }
    }
}
