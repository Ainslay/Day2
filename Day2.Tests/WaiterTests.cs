using System;
using Xunit;

using Day2;

namespace Day2.Tests
{
    public class WaiterTests
    {
        [Theory]
        [InlineData(null,null)]
        [InlineData(null,"")]
        [InlineData("","")]
        [InlineData(" "," ")]
        [InlineData("Adam","")]
        [InlineData(" ","Kowalski")]
        public void Given_InvalidParameters_When_ConstructingWaiter_Then_ThrowsException(string name, string surname)
        {
            Assert.Throws<Exception>(() => new Waiter(name, surname));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Given_InvalidStringParameter_When_CallingPlaceOrder_Then_ThrowsException(string dish)
        {
            var waiter = new Waiter("Jan", "Kowalski");
            var orderQueue = new OrderQueue();
            Assert.Throws<Exception>(() => waiter.PlaceOrder(dish, orderQueue));
        }

        [Fact]
        public void Given_NullOrderQueue_When_CallingPlaceOrder_Then_ThrowsException()
        {
            var waiter = new Waiter("Jan", "Kowalski");
            Assert.Throws<Exception>(() => waiter.PlaceOrder("Pizza", null));
        }
    }
}
