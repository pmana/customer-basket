using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBasket
{
    public class FourMilkForThreeOffer : IOffer
    {
        public IEnumerable<Discount> CalculateDiscounts(IEnumerable<Product> products)
        {
            return Enumerable.Empty<Discount>();
        }
    }
}