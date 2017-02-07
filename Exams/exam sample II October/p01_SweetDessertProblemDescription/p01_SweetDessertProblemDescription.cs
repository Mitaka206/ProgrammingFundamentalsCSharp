using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_SweetDessertProblemDescription
{
    class p01_SweetDessertProblemDescription
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double guests = double.Parse(Console.ReadLine());
            double bananaPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());

            var portions = Math.Ceiling(guests / 6);

            var fullPrice = portions * (2 * bananaPrice + 4 * eggsPrice + 0.2 * berriesPrice);

            if (fullPrice > money)
            {
                var difference = fullPrice - money;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {difference:F2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {fullPrice:F2}lv.");
            }
        }
    }
}
