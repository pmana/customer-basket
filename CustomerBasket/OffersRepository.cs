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
            throw new System.NotImplementedException();
        }
    }
}
