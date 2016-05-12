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
            Assert.Fail();
        }

        [Test]
        public void GivenTheBasketHasFourMilk_WhenITotalTheBasket_ThenTheTotalShouldBe3_45()
        {
            Assert.Fail();
        }

        [Test]
        public void GivenTheBasketHasTwoButterOneBreadAndEightMilk_WhenITotalTheBasket_ThenTheTotalShouldBe9_00()
        {
            Assert.Fail();
        }
    }
}
