using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBasket
{
    public class HalfPriceBreadWithTwoButterOffer : IOffer
    {
        public IEnumerable<Discount> CalculateDiscounts(IEnumerable<Product> products)
        {
            var allProducts = products.ToArray();
            var eligibleButter = (int) Math.Floor(allProducts.Count(x => x.ProductId == Product.Butter.ProductId)/2d);
            var eligibleBread = allProducts.Count(x => x.ProductId == Product.Bread.ProductId);
            return Enumerable.Range(0, Math.Min(eligibleBread, eligibleButter))
                .Select(x => new Discount(Product.Bread, 50));
        }
    }
}