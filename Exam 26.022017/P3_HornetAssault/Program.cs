
namespace P3_HornetAssault
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var beeHives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            var allHornets = hornets.Sum();

            for (int i = 0; i < beeHives.Count; i++)
            {
                if (allHornets > beeHives[i])//hornets kils behive[i]
                {
                    beeHives[i] = 0;
                }
                else
                {
                    beeHives[i] -= allHornets;

                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                        allHornets = hornets.Sum();
                    }
                }
            }

            if (beeHives.Any(b => b > 0))
            {
                Console.WriteLine(string.Join(" ", beeHives.Where(b => b > 0)));
            }

            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
