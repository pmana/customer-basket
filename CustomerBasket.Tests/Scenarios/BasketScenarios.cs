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
            
        }

        [Test]
        public void GivenTheBasketHasTwoBreadAndTwoButter_WhenITotalTheBasket_ThenTheTotalShouldBe3_10()
        {
            
        }

        [Test]
        public void GivenTheBasketHasFourMilk_WhenITotalTheBasket_ThenTheTotalShouldBe3_45()
        {
            
        }

        [Test]
        public void GivenTheBasketHasTwoButterOneBreadAndEightMilk_WhenITotalTheBasket_ThenTheTotalShouldBe9_00()
        {
            
        }
    }
}
