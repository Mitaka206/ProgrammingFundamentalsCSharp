using System;
using System.Linq;

namespace p03_EnduranceRally
{
    class p03_EnduranceRally
    {
        static void Main(string[] args)
        {
            var racers = Console.ReadLine().Split().ToArray();
            var forFuel = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var index = Console.ReadLine().Split().Select(long.Parse).ToArray();

            double sum = 0;
            long zone = 0;

            for (int i = 0; i < racers.Length; i++)
            {
                int fuel = racers[i].ToCharArray().First();
                sum = fuel;

                for (int j = 0; j < forFuel.Length; j++)
                {
                    if (index.Contains(j))
                    {
                        sum += forFuel[j];
                    }
                    else
                    {
                        sum -= forFuel[j];
                        if (sum < 0)
                        {
                            zone = j;
                            break;
                        }
                    }
                }

                if (sum < 0)
                {
                    Console.WriteLine($"{racers[i]} - reached {zone}");
                }
                else
                {
                    Console.WriteLine($"{racers[i]} - fuel left { sum:f2}");
                }

            }
        }
    }
}

