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

        [Test]
        public void CalculateDiscounts_ForFourMilk_ReturnsOneDiscountForThePriceOfOneMilk()
        {
            var discounts = offer.CalculateDiscounts(new[] { Product.Milk, Product.Milk, Product.Milk, Product.Milk }).ToArray();

            Assert.That(discounts, Has.Length.EqualTo(1));
            Assert.That(discounts[0].Value, Is.EqualTo(1.15m));
        }

        [Test]
        public void CalculateDiscounts_ForEightMilk_ReturnsTwoDiscountsForThePriceOfOneMilk()
        {
            var discounts = offer.CalculateDiscounts(
                new[] { Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk }).ToArray();

            Assert.That(discounts, Has.Length.EqualTo(2));
            Assert.That(discounts[0].Value, Is.EqualTo(1.15m));
            Assert.That(discounts[1].Value, Is.EqualTo(1.15m));
        }

        [Test]
        public void CalculateDiscounts_ForElevenMilk_ReturnsTwoDiscountsForThePriceOfOneMilk()
        {
            var discounts = offer.CalculateDiscounts(
                new[] { Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk,
                    Product.Milk, Product.Milk, Product.Milk, Product.Milk }).ToArray();

            Assert.That(discounts, Has.Length.EqualTo(2));
            Assert.That(discounts[0].Value, Is.EqualTo(1.15m));
            Assert.That(discounts[1].Value, Is.EqualTo(1.15m));
        }

        [Test]
        public void CalculateDiscounts_ForTwelveMilk_ReturnsTwoDiscountsForThePriceOfOneMilk()
        {
            var discounts = offer.CalculateDiscounts(
                new[] { Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk,
                    Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk }).ToArray();

            Assert.That(discounts, Has.Length.EqualTo(3));
            Assert.That(discounts[0].Value, Is.EqualTo(1.15m));
            Assert.That(discounts[1].Value, Is.EqualTo(1.15m));
            Assert.That(discounts[2].Value, Is.EqualTo(1.15m));
        }

        [Test]
        public void CalculateDiscounts_ForFourMilkAlongsideOtherProducts_ReturnsOneDiscountForThePriceOfOneMilk()
        {
            var discounts = offer.CalculateDiscounts(
                new[] { Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Bread, Product.Butter }).ToArray();

            Assert.That(discounts, Has.Length.EqualTo(1));
            Assert.That(discounts[0].Value, Is.EqualTo(1.15m));
        }

        [Test]
        public void CalculateDiscounts_ForEightMilkAlongsideOtherProducts_ReturnsTwoDiscountsForThePriceOfOneMilk()
        {
            var discounts = offer.CalculateDiscounts(
                new[] { Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk, Product.Milk,
                    Product.Milk, Product.Milk, Product.Bread, Product.Bread, Product.Bread, Product.Bread  }).ToArray();

            Assert.That(discounts, Has.Length.EqualTo(2));
            Assert.That(discounts[0].Value, Is.EqualTo(1.15m));
            Assert.That(discounts[1].Value, Is.EqualTo(1.15m));
        }
    }
}
