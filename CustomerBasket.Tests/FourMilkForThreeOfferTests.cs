using System.Linq;
using NUnit.Framework;

namespace CustomerBasket.Tests
{
    [TestFixture]
    public class FourMilkForThreeOfferTests
    {
        private FourMilkForThreeOffer offer;

        [SetUp]
        public void SetUp()
        {
            offer = new FourMilkForThreeOffer();
        }

        [Test]
        public void CalculateDiscounts_ForNoProducts_ReturnsNoDiscount()
        {
            var discounts = offer.CalculateDiscounts(Enumerable.Empty<Product>());

            Assert.That(discounts, Is.Empty);
        }

        [Test]
        public void CalculateDiscounts_ForNoMilkProducts_ReturnsNoDiscount()
        {
            var discounts = offer.CalculateDiscounts(new[] {Product.Bread, Product.Bread});

            Assert.That(discounts, Is.Empty);
        }

        [Test]
        public void CalculateDiscounts_ForOneMilk_ReturnsNoDiscount()
        {
            var discounts = offer.CalculateDiscounts(new[] { Product.Milk });

            Assert.That(discounts, Is.Empty);
        }

        [Test]
        public void CalculateDiscounts_ForThreeMilk_ReturnsNoDiscount()
        {
            var discounts = offer.CalculateDiscounts(new[] { Product.Milk, Product.Milk, Product.Milk });

            Assert.That(discounts, Is.Empty);
        }
    }
}
