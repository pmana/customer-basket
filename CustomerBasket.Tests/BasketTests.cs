using NUnit.Framework;
using Rhino.Mocks;

namespace CustomerBasket.Tests
{
    [TestFixture]
    public class BasketTests
    {
        private Basket basket;
        private IOffersRepository offersRepository;

        [SetUp]
        public void SetUp()
        {
            offersRepository = MockRepository.GenerateMock<IOffersRepository>();
            basket = new Basket(offersRepository);
        }

        [Test]
        public void CalculateTotal_ForOneProductWithNoDiscounts_ReturnsThatProductsValue()
        {
            basket.AddProducts(Product.Bread);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(1));
        }

        [Test]
        public void CalculateTotal_ForTwoProductsOfTheSameTypeWithNoDiscounts_ReturnsTwoTimesThatProductsValue()
        {
            basket.AddProducts(Product.Bread, Product.Bread);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(2));
        }

        [Test]
        public void CalculateTotal_ForTwoProductsOfDifferentTypesWithNoDiscounts_ReturnsTheAdditionOfThoseTwoProductValues()
        {
            basket.AddProducts(Product.Bread, Product.Milk);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(2.15m));
        }

        [Test]
        public void CalculateTotal_ForManyProductsOfDifferentTypesWithNoDiscounts_ReturnsTheExpectedTotal()
        {
            basket.AddProducts(Product.Bread, Product.Milk, Product.Milk, Product.Butter);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(4.10m));
        }

        [Test]
        public void CalculateTotal_AddingTheSameProductTwiceWithNoDiscounts_ReturnsTwiceThatProductsValue()
        {
            basket.AddProducts(Product.Bread);
            basket.AddProducts(Product.Bread);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(2));
        }
    }
}
