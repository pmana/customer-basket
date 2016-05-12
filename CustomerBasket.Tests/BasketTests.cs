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
            offersRepository.Stub(x => x.GetOffers()).Return(new IOffer[0]);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(1));
        }

        [Test]
        public void CalculateTotal_ForTwoProductsOfTheSameTypeWithNoDiscounts_ReturnsTwoTimesThatProductsValue()
        {
            basket.AddProducts(Product.Bread, Product.Bread);
            offersRepository.Stub(x => x.GetOffers()).Return(new IOffer[0]);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(2));
        }

        [Test]
        public void CalculateTotal_ForTwoProductsOfDifferentTypesWithNoDiscounts_ReturnsTheAdditionOfThoseTwoProductValues()
        {
            basket.AddProducts(Product.Bread, Product.Milk);
            offersRepository.Stub(x => x.GetOffers()).Return(new IOffer[0]);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(2.15m));
        }

        [Test]
        public void CalculateTotal_ForManyProductsOfDifferentTypesWithNoDiscounts_ReturnsTheExpectedTotal()
        {
            basket.AddProducts(Product.Bread, Product.Milk, Product.Milk, Product.Butter);
            offersRepository.Stub(x => x.GetOffers()).Return(new IOffer[0]);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(4.10m));
        }

        [Test]
        public void CalculateTotal_AddingTheSameProductTwiceWithNoDiscounts_ReturnsTwiceThatProductsValue()
        {
            basket.AddProducts(Product.Bread);
            basket.AddProducts(Product.Bread);
            offersRepository.Stub(x => x.GetOffers()).Return(new IOffer[0]);

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(2));
        }

        [Test]
        public void CalculateTotal_FetchesOffersFromTheOffersRepository()
        {
            offersRepository.Expect(x => x.GetOffers()).Return(new IOffer[0]);

            basket.CalculateTotal();

            offersRepository.VerifyAllExpectations();
        }

        [Test]
        public void CalculateTotal_AddingOneProductWithADiscount_ReturnsThatProductsValueMinusTheDiscount()
        {
            basket.AddProducts(Product.Bread);
            var offer = MockRepository.GenerateMock<IOffer>();
            var discount = new Discount(Product.Bread, 90);
            offer.Stub(x => x.CalculateDiscounts(null)).IgnoreArguments().Return(new[] {discount});
            offersRepository.Stub(x => x.GetOffers()).Return(new[] {offer});

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(0.1m));
        }

        [Test]
        public void CalculateTotal_AddingTwoProductsWithADiscount_ReturnsThoseProductsValuesMinusTheDiscount()
        {
            basket.AddProducts(Product.Bread, Product.Butter);
            var offer = MockRepository.GenerateMock<IOffer>();
            var discount = new Discount(Product.Bread, 50);
            offer.Stub(x => x.CalculateDiscounts(null)).IgnoreArguments().Return(new[] {discount});
            offersRepository.Stub(x => x.GetOffers()).Return(new[] {offer});

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(1.3m));
        }

        [Test]
        public void CalculateTotal_AddingTwoProductsWithTwoDiscounts_ReturnsThoseProductsValuesMinusBothDiscounts()
        {
            basket.AddProducts(Product.Bread, Product.Butter);
            var offer = MockRepository.GenerateMock<IOffer>();
            var discount1 = new Discount(Product.Bread, 50);
            var discount2 = new Discount(Product.Butter, 10);
            offer.Stub(x => x.CalculateDiscounts(null)).IgnoreArguments().Return(new[] {discount1, discount2});
            offersRepository.Stub(x => x.GetOffers()).Return(new[] {offer});

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(1.22m));
        }

        [Test]
        public void CalculateTotal_AddingThreeProductsWithTwoDiscountsInTwoOffers_ReturnsThoseProductsValuesMinusBothDiscounts()
        {
            basket.AddProducts(Product.Bread, Product.Butter, Product.Milk);
            var offer1 = MockRepository.GenerateMock<IOffer>();
            var discount1 = new Discount(Product.Bread, 50);
            offer1.Stub(x => x.CalculateDiscounts(null)).IgnoreArguments().Return(new[] {discount1});
            var offer2 = MockRepository.GenerateMock<IOffer>();
            var discount2 = new Discount(Product.Butter, 20);
            offer2.Stub(x => x.CalculateDiscounts(null)).IgnoreArguments().Return(new[] {discount2});
            offersRepository.Stub(x => x.GetOffers()).Return(new[] { offer1, offer2 });

            var total = basket.CalculateTotal();

            Assert.That(total, Is.EqualTo(2.29m));
        }
    }
}
