using System;
using System.Linq;

namespace p01_SinoTheWalker
{
    class p01_SinoTheWalker
    {
        static void Main(string[] args)
        {
            var startTime = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            long steps = long.Parse(Console.ReadLine());
            var stepForSecond = long.Parse(Console.ReadLine());

            TimeSpan time = new TimeSpan(startTime[0], startTime[1], startTime[2]);

            var timeForSteps = steps * stepForSecond;

            TimeSpan fulltime = time.Add(TimeSpan.FromSeconds(timeForSteps));

            Console.WriteLine($"Time Arrival: {fulltime.Hours:d2}:{fulltime.Minutes:d2}:{fulltime.Seconds:d2}");

        }
    }
}
