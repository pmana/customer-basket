using System.Linq;
using NUnit.Framework;

namespace CustomerBasket.Tests
{
    [TestFixture]
    public class HalfPriceBreadWithTwoButterOfferTests
    {
        private HalfPriceBreadWithTwoButterOffer offer;

        [SetUp]
        public void SetUp()
        {
            offer = new HalfPriceBreadWithTwoButterOffer();
        }

        [Test]
        public void CalculateDiscounts_ForNoProducts_ReturnsNoDiscount()
        {
            var discounts = offer.CalculateDiscounts(Enumerable.Empty<Product>());

            Assert.That(discounts, Is.Empty);
        }
    }
}
