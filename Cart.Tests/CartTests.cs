using Cart.Basket;
using Cart.Item;
using FluentAssertions;
using Xunit;

namespace Cart.Tests
{
    public class CartTests
    {
        private readonly BasketCheckout _sut;

        public CartTests()
        {
            _sut = new BasketCheckout();
        }
        [Fact]
        public void Given_CheckService_AddOrangeToBasket_When_Invoked_ExpectedOrangeValuesCorrect()
        {
            //Arrange
            var orange = new ShoppingItem
            {
                Name = ItemName.OrangeName,
                Price = ItemPrices.OrangePrice,
            };

            _sut.AddItemToBasket(orange);

            //Act
            var result = _sut.CalculateBasketTotal();

            //Assert
            const int expectedBasketItemValue = 10;
            result.Should().Be(expectedBasketItemValue);
        }

        [Fact]
        public void Given_CheckService_AddItemToBasket_When_Invoked_ShouldAddItemToBasket()
        {
            //Arrange
            var orange = new ShoppingItem
            {
                Name = ItemName.OrangeName
            };

            //Act
            _sut.AddItemToBasket(orange);

            //Assert
            const int expectedBasketItemCount = 1;
            _sut.BasketItems.Count.Should().Be(expectedBasketItemCount);
        }
    }
}