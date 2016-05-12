namespace CustomerBasket
{
    public class Discount
    {
        public Discount(Product product, decimal percentage)
        {
            Value = product.Value;
        }

        public decimal Value { get; private set; }
    }
}