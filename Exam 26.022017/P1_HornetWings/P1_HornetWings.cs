namespace P2_HornetWings
{
    using System;

    class P1_HornetWings
    {
        static void Main(string[] args)
        {
            var wingFlaps = long.Parse(Console.ReadLine());//in numbers
            var distance = decimal.Parse(Console.ReadLine());//in meters for 1000 wingflaps
            var endurance = long.Parse(Console.ReadLine());//in numbers

            var fullDistance = (wingFlaps / 1000) * distance;
            var secondDistance = wingFlaps / 100;
            var secondsRest = (wingFlaps / endurance) * 5;

            var fullSeconds = secondDistance + secondsRest;

            Console.WriteLine($"{fullDistance:f2} m.");
            Console.WriteLine($"{fullSeconds:f0} s.");
        }
    }
}
