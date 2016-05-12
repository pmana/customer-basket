﻿using System.Linq;
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
    }
}
