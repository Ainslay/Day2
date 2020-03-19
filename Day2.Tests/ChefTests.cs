using System;
using Xunit;
using Day2;
using System.Collections;
using System.Collections.Generic;

namespace Day2.Tests
{
    public class ChefTests
    {
        [Theory]
        [ClassData(typeof(ChefConstructionData))]
        public void Given_InvalidParameters_When_ConstructingChef_Then_ThrowsException(string name, string surname)
        {
            Assert.Throws<Exception>(() => new Waiter(name, surname));
        }

        [Fact]
        public void Given_EmptyOrderQueue_When_CallingReadFromOrderQueue_CurrentOrderEqualsNull()
        {
            var orderQueue = new OrderQueue();
            var chef = new Chef("Jan", "Kowalski");
            Order expected = null;

            chef.ReadFromOrderQueue(orderQueue);

            Assert.Equal(expected, chef.GetCurrentOrder());
        }

        [Fact]
        public void Given_ValidOrderQueue_When_CallingReadFromOrderQueue_CurrentOrderEqualsExpected()
        {
            var orderQueue = new OrderQueue();
            var expected = new Order("Pizza");
            var chef = new Chef("Jan", "Kowalski");
            orderQueue.AddOrder(expected);

            chef.ReadFromOrderQueue(orderQueue);

            Assert.Equal(expected, chef.GetCurrentOrder());
        }
    }

    // Chciałem przetestować atrybut ClassData, trochę czaję trochę nie, chyba jeszcze za wcześnie
    public class ChefConstructionData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { null, null };
            yield return new object[] { null, "" };
            yield return new object[] { " ", " " };
            yield return new object[] { "Adam", "" };
            yield return new object[] { " ", "Kowalski" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
