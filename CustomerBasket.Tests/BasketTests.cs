using NUnit.Framework;

namespace CustomerBasket.Tests
{
    [TestFixture]
    public class BasketTests
    {
        private Basket basket;

        [SetUp]
        public void SetUp()
        {
            basket = new Basket();
        }

        [Test]
        public void CalculateTotal_ForOneProduct_ReturnsThatProductsValue()
        {
            basket.AddProducts(new Bread());

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(1));
        }
    }
}
