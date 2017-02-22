using System;
using System.Globalization;

namespace p01_SoftUniCoffeeOrders
{
    class p01_SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            var ordersCount = decimal.Parse(Console.ReadLine());

            decimal total = 0;
            for (int i = 0; i < ordersCount; i++)
            {
                var price = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var countCaps = decimal.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                
                var totalOneOrder = daysInMonth * countCaps * price;
                total += totalOneOrder;

                Console.WriteLine($"The price for the coffee is: ${totalOneOrder:F2}");
            }
            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
