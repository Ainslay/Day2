using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Waiter
    {
        private string _name;
        private string _surname;

        public Waiter(string name, string surname) // musimy być w 100% pewni, że konstruktor stworzy w 100% poprawny obiekt
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                throw new Exception("Waiter object could not be instanciated.");
            }
            _name = name;
            _surname = surname;
        }

        public void PlaceOrder(string dish, OrderQueue orderQueue)
        {
            if(string.IsNullOrWhiteSpace(dish) || orderQueue == null)
            {
                throw new Exception("Invalid order name. Order could not be placed.");
            }
            orderQueue.AddOrder(new Order(dish));
        }

        // Konstruktor gwarantuje poprawne imię i nazwisko, pomijam sprawdzenie w GetFullName()
        public string GetFullName()
        {
            return $"{_name} {_surname}";
        }
    }
}
