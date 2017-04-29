namespace P1_SweetDessert
{
    using System;

    class P1_SweetDessert
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = decimal.Parse(Console.ReadLine());
            var bananasPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());

            var setOfPortions = (long)Math.Ceiling(guests / 6);

            var fullPrice = setOfPortions * (2 * bananasPrice + 4 * eggsPrice + ((decimal)0.2 * berriesPrice));

            if (cash < fullPrice)
            {
                var total = fullPrice - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {total:f2}lv more.");
            }
            else
            {
                var total = fullPrice;
                Console.WriteLine($"Ivancho has enough money - it would cost {total:f2}lv.");
            }
        }
    }
}
