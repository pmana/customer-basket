using System.Collections.Generic;

namespace CustomerBasket
{
    public interface IOffersRepository
    {
        IEnumerable<IOffer> GetOffers();
    }

    public class OffersRepository : IOffersRepository
    {
        public IEnumerable<IOffer> GetOffers()
        {
            return new IOffer[]
            {
                new FourMilkForThreeOffer(),
                new HalfPriceBreadWithTwoButterOffer()
            };
        }
    }
}
