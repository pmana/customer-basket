﻿using System.Linq;
using NUnit.Framework;

namespace CustomerBasket.Tests
{
    [TestFixture]
    public class HalfPriceBreadWithTwoButterOfferTests
    {
        private HalfPriceBreadWithTwoButterOffer offer;

        [SetUp]
        public void SetUp()
        {
            offer = new HalfPriceBreadWithTwoButterOffer();
        }

        [Test]
        public void CalculateDiscounts_ForNoProducts_ReturnsNoDiscount()
        {
            var discounts = offer.CalculateDiscounts(Enumerable.Empty<Product>());

            Assert.That(discounts, Is.Empty);
        }

        [Test]
        public void CalculateDiscounts_ForNoBreadOrButterProducts_ReturnsNoDiscount()
        {
            var discounts = offer.CalculateDiscounts(new[] { Product.Milk, Product.Milk, Product.Milk, Product.Milk });

            Assert.That(discounts, Is.Empty);
        }

        [Test]
        public void CalculateDiscounts_ForBreadButNoButter_ReturnsNoDiscount()
        {
            var discounts = offer.CalculateDiscounts(new[] { Product.Bread, Product.Bread });

            Assert.That(discounts, Is.Empty);
        }

        [Test]
        public void CalculateDiscounts_ForButterButNoBread_ReturnsNoDiscount()
        {
            var discounts = offer.CalculateDiscounts(new[] { Product.Butter, Product.Butter });

            Assert.That(discounts, Is.Empty);
        }

        [Test]
        public void CalculateDiscounts_ForBreadAndOnlyOneButter_ReturnsNoDiscount()
        {
            var discounts = offer.CalculateDiscounts(new[] { Product.Bread, Product.Butter });

            Assert.That(discounts, Is.Empty);
        }

        [Test]
        public void CalculateDiscounts_ForBreadAndTwoButter_ReturnsOneDiscountForHalfThePriceOfBread()
        {
            var discounts = offer.CalculateDiscounts(new[] { Product.Bread, Product.Butter, Product.Butter }).ToArray();

            Assert.That(discounts, Has.Length.EqualTo(1));
            Assert.That(discounts[0].Value, Is.EqualTo(0.5m));
        }
    }
}
