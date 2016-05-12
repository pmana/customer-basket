using System;

namespace CustomerBasket
{
    public class Product
    {
        public Guid ProductId { get; private set; }
        public decimal Value { get; private set; }

        // these would normally come from a datastore, they are here as static members for convenience
        public static readonly Product Bread = new Product
        {
            ProductId = Guid.NewGuid(),
            Value = 1
        };

        public static readonly Product Butter = new Product
        {
            ProductId = Guid.NewGuid(),
            Value = 0.8m
        };

        public static readonly Product Milk = new Product
        {
            ProductId = Guid.NewGuid(),
            Value = 1.15m
        };
    }
}
