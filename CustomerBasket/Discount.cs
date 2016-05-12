namespace CustomerBasket
{
    public class Discount
    {
        public Discount(Product product, decimal percentage)
        {
            Value = percentage == 0 ? 0 : product.Value * percentage / 100;
        }

        public decimal Value { get; private set; }
    }
}