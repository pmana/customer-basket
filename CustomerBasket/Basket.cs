using System.Collections.Generic;
using System.Linq;

namespace CustomerBasket
{
    public class Basket
    {
        private readonly IOffersRepository offersRepository;
        private readonly List<Product> products;

        public Basket(IOffersRepository offersRepository)
        {
            this.offersRepository = offersRepository;
            products = new List<Product>();
        }

        public void AddProducts(params Product[] productsToAdd)
        {
            products.AddRange(productsToAdd);
        }

        public decimal CalculateTotal()
        {
            var offers = offersRepository.GetOffers();
            return products.Sum(x => x.Value);
        }
    }
}
