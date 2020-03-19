using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nie wiem jak umożliwić wielu szefom kuchni równoległe gotowanie
            // Dlatego zostawiłem to w ten sposób
            try
            {
                var orderQueue = new OrderQueue();
                var chef1 = new Chef("Janek", "Kowalski");
                var chef2 = new Chef("Grzegorz", "Anonim");
                var waiter = new Waiter("Adam", "Koronek");

                waiter.PlaceOrder("Makaron", orderQueue);
                waiter.PlaceOrder("Pizza", orderQueue);
                waiter.PlaceOrder("Spaghetti Carbonara", orderQueue);
                waiter.PlaceOrder("Pizza śmietanowa", orderQueue);

                // Zastanawiam się czemu wyrzuca exception o modyfikacji kolekcji
                foreach (var order in orderQueue.GetOrders().ToList())
                {
                    chef1.ReadFromOrderQueue(orderQueue);
                    chef1.Cook();
                    chef2.ReadFromOrderQueue(orderQueue);
                    chef2.Cook();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR OCCURED: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
