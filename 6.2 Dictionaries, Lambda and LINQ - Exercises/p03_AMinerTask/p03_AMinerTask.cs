using System;
using System.Collections.Generic;

namespace p03_AMinerTask
{
    class p03_AMinerTask
    {
        static void Main(string[] args)
        {
            string resourceType = Console.ReadLine();

            var resources = new Dictionary<string, long>();

            while (resourceType != "stop")
            {
                long quantity = long.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resourceType))
                {
                    resources[resourceType] = 0;
                }

                resources[resourceType] += quantity;
                
                resourceType = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

