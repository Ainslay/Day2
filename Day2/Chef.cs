using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day2
{
    public class Chef
    {
        private string _name;
        private string _surname;
        private bool _isCooking;
        private Order _currentOrder;

        public Chef(string name, string surname)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                throw new Exception("Waiter object could not be instanciated.");
            }
            _name = name;
            _surname = surname;
            _isCooking = false;
            _currentOrder = null;
        }

        // Nie za bardzo wiem co mógłbym tu testować
        public void Cook()
        {
            if(_isCooking == false && _currentOrder != null)
            {
                StartCooking();

                Console.Write($"{GetFullName()} is cooking ");
                _currentOrder.PrintOrderDetails();
                Thread.Sleep(3000);

                FinishCooking();

                Console.WriteLine("Order served.");
            }
        }


        public void ReadFromOrderQueue(OrderQueue orderQueue)
        {
            _currentOrder = orderQueue.Peek();
        }

        public string GetFullName()
        {
            return $"{_name} {_surname}";
        }

        public Order GetCurrentOrder()
        {
            return _currentOrder;
        }

        // Te dwie zmieniłem na private bo korzystać z nich powinna tylko metoda cook
        private void StartCooking()
        {
            _isCooking = true;
        }

        private void FinishCooking()
        {
            _isCooking = false;
            _currentOrder = null;
        }
    }
}
