using NUnit.Framework;

namespace CustomerBasket.Tests
{
    [TestFixture]
    public class OffersRespositoryTests
    {
        [Test]
        public void GetOffers_ReturnsANonEmptySetOfOffers()
        {
            var repository = new OffersRepository();

            var offers = repository.GetOffers();

            Assert.That(offers, Is.Not.Empty);
        }
    }
}
