using System;
using System.Globalization;

namespace p01_SoftuniCoffeeOrders
{
    class p01_SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal fullSum = 0;

            for (int i = 0; i < n; i++)
            {
                var price = decimal.Parse(Console.ReadLine());
                var dateAsString = Console.ReadLine();
                var capsuleCount = long.Parse(Console.ReadLine());

                DateTime date = DateTime.ParseExact(dateAsString, "d/M/yyyy", CultureInfo.InvariantCulture);

                var dayInMonth = DateTime.DaysInMonth(date.Year, date.Month);

                var result = price * dayInMonth * capsuleCount;

                fullSum += result;

                Console.WriteLine($"The price for the coffee is: ${result:F2}");
            }
            Console.WriteLine($"Total: ${fullSum:F2}");
        }
    }
}
