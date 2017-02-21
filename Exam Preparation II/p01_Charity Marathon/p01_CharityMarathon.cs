using System;

namespace p01_Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenMaratonInDays = double.Parse(Console.ReadLine());//days
            double numOfRunners = double.Parse(Console.ReadLine());//count
            double averageLaps = double.Parse(Console.ReadLine());//laps
            double lenTrack = double.Parse(Console.ReadLine());//meters
            double capacityTrack = double.Parse(Console.ReadLine());//count
            double moneyPerKM = double.Parse(Console.ReadLine());//money

            double d = capacityTrack * lenMaratonInDays;

            double countRunners = Math.Min(d, numOfRunners);

            double totalMeters = countRunners * averageLaps * lenTrack;
            double totalKm = totalMeters / 1000;

            double donatMoney = totalKm * moneyPerKM;

            Console.WriteLine($"Money raised: {donatMoney:F2}");

        }
    }
}
