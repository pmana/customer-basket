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
            return products[0].Value;
        }
    }
}
