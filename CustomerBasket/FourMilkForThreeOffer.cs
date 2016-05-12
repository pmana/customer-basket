using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBasket
{
    public class FourMilkForThreeOffer : IOffer
    {
        public IEnumerable<Discount> CalculateDiscounts(IEnumerable<Product> products)
        {
            var eligibleProducts = (int) Math.Floor(products.Count(x => x.ProductId == Product.Milk.ProductId)/4d);
            return Enumerable.Range(0, eligibleProducts).Select(x => new Discount(Product.Milk, 100));
        }
    }
}