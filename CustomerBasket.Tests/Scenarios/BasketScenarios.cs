using System.Linq;
using NUnit.Framework;

namespace CustomerBasket.Tests.Scenarios
{
    // in a real project these would likely be broken up into their own classes per scenario, or following a
    // framework like SpecFlow
    [TestFixture]
    public class BasketScenarios
    {
        private Basket basket;

        [SetUp]
        public void SetUp()
        {
            basket = new Basket(new OffersRepository());
        }

        [Test]
        public void GivenTheBasketHasOneBreadButterAndMilkAndNoDiscounts_WhenITotalTheBasket_ThenTheTotalShouldBe2_95()
        {
            basket.AddProducts(Product.Bread, Product.Butter, Product.Milk);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(2.95m));
        }

        [Test]
        public void GivenTheBasketHasTwoBreadAndTwoButterAndNoDiscounts_WhenITotalTheBasket_ThenTheTotalShouldBe3_10()
        {
            basket.AddProducts(Product.Bread, Product.Bread, Product.Butter, Product.Butter);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(3.10m));
        }

        [Test]
        public void GivenTheBasketHasFourMilkAndNoDiscounts_WhenITotalTheBasket_ThenTheTotalShouldBe3_45()
        {
            basket.AddProducts(Product.Milk, Product.Milk, Product.Milk, Product.Milk);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(3.45m));
        }

        [Test]
        public void GivenTheBasketHasTwoButterOneBreadAndEightMilkAndNoDiscounts_WhenITotalTheBasket_ThenTheTotalShouldBe9_00()
        {
            basket.AddProducts(Product.Butter, Product.Butter, Product.Bread);
            basket.AddProducts(Enumerable.Range(0, 8).Select(x => Product.Milk).ToArray());

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(9m));
        }
    }
}
