using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_SweetDessert
{
    class p01_SweetDessert
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var numberOfGuests = double.Parse(Console.ReadLine());
            var pricesOfBananas = double.Parse(Console.ReadLine());
            var priceOfEgs = double.Parse(Console.ReadLine());
            var priceOfBerries = double.Parse(Console.ReadLine());

            var forGuests = Math.Ceiling(numberOfGuests / 6);

            var sum = forGuests*(2 * pricesOfBananas + 4 * priceOfEgs + 0.2 * priceOfBerries);

            if (sum <= money)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {sum:F2}lv.");
            }
            else
            {
                var odatherSum = sum - money;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(sum-money):F2}lv more.");
            }
        }
    }
}
