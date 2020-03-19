using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Order
    {
        private string _dish;
        // private bool _isBeingCooked; to pole wydaje mi się zbędne,
        // ponieważ każde zaczęte zamówienie jest aktualnie zdejmowane z kolejki

        public Order(string dish)
        {
            _dish = dish;
        }

        public void PrintOrderDetails()
        {
            Console.WriteLine(_dish);
        }

    }
}
