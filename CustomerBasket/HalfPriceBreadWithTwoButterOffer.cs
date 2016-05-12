using System;
using System.Collections.Generic;

namespace CustomerBasket
{
    public class HalfPriceBreadWithTwoButterOffer : IOffer
    {
        public IEnumerable<Discount> CalculateDiscounts(IEnumerable<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}