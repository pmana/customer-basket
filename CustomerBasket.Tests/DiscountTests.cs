using NUnit.Framework;

namespace CustomerBasket.Tests
{
    [TestFixture]
    public class DiscountTests
    {
        [Test]
        public void Discount_WhenZeroPercent_SetsValueToValueOfOriginalProduct()
        {
            var discount = new Discount(Product.Bread, 0);

            Assert.That(discount.Value, Is.EqualTo(1));
        }

        [Test]
        public void Discount_When100Percent_SetsValueToZero()
        {
            var discount = new Discount(Product.Bread, 100);

            Assert.That(discount.Value, Is.EqualTo(0));
        }
    }
}
