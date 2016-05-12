using System.Collections.Generic;
using System.Linq;

namespace CustomerBasket
{
    public class HalfPriceBreadWithTwoButterOffer : IOffer
    {
        public IEnumerable<Discount> CalculateDiscounts(IEnumerable<Product> products)
        {
            var butter = products.Count(x => x.ProductId == Product.Butter.ProductId);
            var bread = products.Count(x => x.ProductId == Product.Bread.ProductId);
            if (butter == 2 && bread == 1)
            {
                yield return new Discount(Product.Bread, 50);
            }
            else
            {
                yield break;
            }
        }
    }
}