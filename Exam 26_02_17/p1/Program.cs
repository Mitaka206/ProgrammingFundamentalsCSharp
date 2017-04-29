using System;

namespace p1
{
    class Program
    {

        static void Main(string[] args)
        {
            var wingFlaps = int.Parse(Console.ReadLine());// count
            var distance = decimal.Parse(Console.ReadLine());//in meters
            var endurance = decimal.Parse(Console.ReadLine());

            var fullDist = (wingFlaps / 1000) * distance;

            var time = wingFlaps / 100;

            var enduranceTime = wingFlaps / endurance * 5;

            var fullTime = time + enduranceTime;

            Console.WriteLine($"{fullDist:F2} m.");
            Console.WriteLine($"{fullTime:F0} s.");
        }

    }
}
