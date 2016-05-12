using System.Linq;
using NUnit.Framework;

namespace CustomerBasket.Tests.Scenarios
{
    // in a real project these would likely be broken up into their own classes per scenario, or following a
    // framework like SpecFlow
    [TestFixture]
    public class BasketScenarios
    {
        [Test]
        public void GivenTheBasketHasOneBreadButterAndMilk_WhenITotalTheBasket_ThenTheTotalShouldBe2_95()
        {
            var basket = new Basket();
            basket.AddProducts(Product.Bread, Product.Butter, Product.Milk);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(2.95m));
        }

        [Test]
        public void GivenTheBasketHasTwoBreadAndTwoButter_WhenITotalTheBasket_ThenTheTotalShouldBe3_10()
        {
            var basket = new Basket();
            basket.AddProducts(Product.Bread, Product.Bread, Product.Butter, Product.Butter);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(3.10m));
        }

        [Test]
        public void GivenTheBasketHasFourMilk_WhenITotalTheBasket_ThenTheTotalShouldBe3_45()
        {
            var basket = new Basket();
            basket.AddProducts(Product.Milk, Product.Milk, Product.Milk, Product.Milk);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(3.45m));
        }

        [Test]
        public void GivenTheBasketHasTwoButterOneBreadAndEightMilk_WhenITotalTheBasket_ThenTheTotalShouldBe9_00()
        {
            var basket = new Basket();
            basket.AddProducts(Product.Butter, Product.Butter, Product.Bread);
            basket.AddProducts(Enumerable.Range(0, 8).Select(x => Product.Milk).ToArray());

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(9m));
        }
    }
}
