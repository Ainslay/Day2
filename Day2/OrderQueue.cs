using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class OrderQueue
    {
        // drum rolls queue ????
        private List<Order> _orders;

        // W konstruktorze gwarantuje poprawne utworzenie listy, dlatego pomijam sprawdzanie czy nie jest przypadkiem nullem
        public OrderQueue()
        {
            _orders = new List<Order>();    // staramy się korzystać konstruktora, taka jego dola że konstruuje
        }

        // Czy powininem testować mimo, że tylko kelner dodaje zamówienia i jego poprawność jest tam sprawdzana?
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        // Peek powinno sprawdzić czy w kolejce znajdują się jakieś zamówienia, jeśli nie zwrócić nulla
        public Order Peek()
        {
            if (_orders.Any())
            {
                Order order = _orders.First();
                RemoveOrder();
                return order;
            }
            return null;
        }

        public List<Order> GetOrders()
        {
            return _orders;
        }

        // Jako że RemoveOrder() jest metoda prywatną i jest używana tylko w Peek() po sprawdzeniu 
        // czy lista nie jest aby pusta, pomijam ten warunek w tej metodzie
        private void RemoveOrder()
        {
            _orders.Remove(_orders.First());
        }
    }
}
