using System.Linq;

namespace CustomerBasket
{
    public class Basket
    {
        private IProduct[] products;

        public void AddProducts(params IProduct[] productsToAdd)
        {
            products = productsToAdd;
        }

        public decimal CalculateTotal()
        {
            return products.Sum(x => x.Value);
        }
    }
}
