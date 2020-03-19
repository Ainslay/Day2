using System;

using Xunit;
using Day2;

namespace Day2.Tests
{
    public class OrderQueueTests
    {
        [Fact]
        public void When_CallingPeek_Then_ReturnsNull()
        {
            var orderQueue = new OrderQueue();
            Order expected = null;

            var result = orderQueue.Peek();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_CallingPeek_Then_ReturnsOrder()
        {
            var orderQueue = new OrderQueue();
            orderQueue.AddOrder(new Order("Pizza"));

            var result = orderQueue.Peek();

            Assert.IsType<Order>(result);
        }

        [Fact]
        public void When_CallingPeek_Then_RemovesOrderFromQueue()
        {
            var orderQueue = new OrderQueue();
            var order = new Order("Pizza");
            orderQueue.AddOrder(order);

            orderQueue.Peek();

            Assert.DoesNotContain(order, orderQueue.GetOrders());
        }
    }
}
