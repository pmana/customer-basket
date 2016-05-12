using NUnit.Framework;

namespace CustomerBasket.Tests
{
    [TestFixture]
    public class DiscountTests
    {
        [Test]
        public void Discount_WhenZeroPercent_SetsValueToZero()
        {
            var discount = new Discount(Product.Bread, 0);

            Assert.That(discount.Value, Is.EqualTo(0));
        }

        [Test]
        public void Discount_When100Percent_SetsValueToValueOfProduct()
        {
            var discount = new Discount(Product.Bread, 100);

            Assert.That(discount.Value, Is.EqualTo(1));
        }
    }
}
