using System;
using System.Collections.Generic;
using System.Linq;

namespace p09_LegendaryFarming
{
    class p09_LegendaryFarming
    {
        static void Main(string[] args)
        {
            var output = new Dictionary<string, int>();
            var info = new List<string>();

            output["shards"] = 0;
            output["motes"] = 0;
            output["fragments"] = 0;

            bool isTrue = true;

            while (isTrue)
            {
                string input = Console.ReadLine();

                info = input.ToLower()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int i = 1; i <= info.Count; i += 2)
                {
                    if (!output.ContainsKey(info[i]))
                    {
                        output[info[i]] = 0;
                    }
                    output[info[i]] += int.Parse(info[i - 1]);

                    if (output["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        output["shards"] -= 250;
                        isTrue = false;
                        break;
                    }

                    if (output["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        output["fragments"] -= 250;
                        isTrue = false;
                        break;
                    }

                    if (output["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        output["motes"] -= 250;
                        isTrue = false;
                        break;
                    }
                }
            }
            foreach (var item in output.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (item.Key == "motes" || item.Key == "fragments" || item.Key == "shards")
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

            foreach (var item in output.OrderBy(x => x.Key))
            {
                if (item.Key != "motes" && item.Key != "fragments" && item.Key != "shards")
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}
