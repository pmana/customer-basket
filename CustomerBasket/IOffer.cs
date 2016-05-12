using System.Collections.Generic;

namespace CustomerBasket
{
    public interface IOffer
    {
        IEnumerable<Discount> CalculateDiscount(IEnumerable<Product> products);
    }
}