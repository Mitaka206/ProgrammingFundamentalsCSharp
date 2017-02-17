using System;
using System.Globalization;

namespace coffe
{
    class coffe
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            decimal priceCaps = decimal.Parse(Console.ReadLine());

            DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            var capsCount = long.Parse(Console.ReadLine());

            decimal total = 0;

            int days = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
            
            for (int i = 1; i <= countOfOrders; i++)
            {
                decimal totalOrder = days * priceCaps * capsCount * i;
                Console.WriteLine($"The price for the coffee is: ${totalOrder:f2}");
                total += totalOrder;
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
