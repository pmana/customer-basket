using System.Collections.Generic;

namespace CustomerBasket
{
    public interface IOffer
    {
        IEnumerable<Discount> CalculateDiscounts(IEnumerable<Product> products);
    }
}