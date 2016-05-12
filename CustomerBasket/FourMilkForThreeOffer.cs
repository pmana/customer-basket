using System.Collections.Generic;
using System.Linq;

namespace CustomerBasket
{
    public class FourMilkForThreeOffer : IOffer
    {
        public IEnumerable<Discount> CalculateDiscounts(IEnumerable<Product> products)
        {
            var eligibleProducts = products.Count(x => x.ProductId == Product.Milk.ProductId);

            if (eligibleProducts >= 4)
            {
                return new[] {new Discount(Product.Milk, 100)};
            }
            return Enumerable.Empty<Discount>();
        }
    }
}