using System;
using System.Collections.Generic;

namespace CustomerBasket
{
    public class FourMilkForThreeOffer : IOffer
    {
        public IEnumerable<Discount> CalculateDiscounts(IEnumerable<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}