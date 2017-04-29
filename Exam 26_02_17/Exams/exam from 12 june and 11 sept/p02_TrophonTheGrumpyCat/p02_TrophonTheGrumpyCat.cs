using System;
using System.Linq;

namespace p02_TrophonTheGrumpyCat
{
    class p02_TrophonTheGrumpyCat
    {
        static void Main(string[] args)
        {
            var priceRaitings = Console.ReadLine().Split().Select(int.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());

            string cheapOrExpensive = Console.ReadLine();
            string command = Console.ReadLine();

            var left = priceRaitings.Take(entryPoint);
            var right = priceRaitings.Skip(entryPoint + 1);

            var leftSum = 0;
            var rightSum = 0;
            var sum = 0;

            switch (cheapOrExpensive)
            {
                case "cheap":
                    switch (command)
                    {
                        case "positive":
                            leftSum = left.Where(element => element <= priceRaitings[entryPoint] && element >= 0).Sum();
                            rightSum = right.Where(element => element <= priceRaitings[entryPoint] && element >= 0).Sum();
                            break;

                        case "negative":
                            leftSum = left.Where(element => element <= priceRaitings[entryPoint] && element < 0).Sum();
                            rightSum = right.Where(element => element <= priceRaitings[entryPoint] && element < 0).Sum();
                            break;

                        case "all":
                            leftSum = left.Where(element => element <= priceRaitings[entryPoint]).Sum();
                            rightSum = right.Where(element => element <= priceRaitings[entryPoint]).Sum();
                            break;

                        default:
                            break;
                    }

                    sum = Math.Max(leftSum, rightSum);
                    break;

                case "expensive":
                    switch (command)
                    {
                        case "positive":
                            leftSum = left.Where(element => element >= priceRaitings[entryPoint] && element >= 0).Sum();
                            rightSum = right.Where(element => element >= priceRaitings[entryPoint] && element >= 0).Sum();
                            break;

                        case "negative":
                            leftSum = left.Where(element => element >= priceRaitings[entryPoint] && element < 0).Sum();
                            rightSum = right.Where(element => element >= priceRaitings[entryPoint] && element < 0).Sum();
                            break;

                        case "all":
                            leftSum = left.Where(element => element >= priceRaitings[entryPoint]).Sum();
                            rightSum = right.Where(element => element >= priceRaitings[entryPoint]).Sum();
                            break;

                        default:
                            break;
                    }

                    sum = Math.Max(leftSum, rightSum);
                    break;
            }

            if (sum == leftSum)
            {
                Console.WriteLine($"Left - {sum}");
            }
            else
            {
                Console.WriteLine($"Right - {sum}");
            }
        }
    }
}
