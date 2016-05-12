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
            basket.AddProducts(Product.Bread);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(1));
        }

        [Test]
        public void CalculateTotal_ForTwoProductsOfTheSameType_ReturnsTwoTimesThatProductsValue()
        {

            basket.AddProducts(Product.Bread, Product.Bread);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(2));
        }

        [Test]
        public void CalculateTotal_ForTwoProductsOfDifferentTypes_ReturnsTheAdditionOfThoseTwoProductValues()
        {

            basket.AddProducts(Product.Bread, Product.Milk);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(2.15m));
        }

        [Test]
        public void CalculateTotal_ForManyProductsOfDifferentTypes_ReturnsTheExpectedTotal()
        {

            basket.AddProducts(Product.Bread, Product.Milk, Product.Milk, Product.Butter);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(4.10m));
        }
    }
}
