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

            while (!resourceType.Equals("stop"))
            {
                long resourceQuantity = long.Parse(Console.ReadLine());

                //if (!resources.ContainsKey(resourceType))
                //{
                //    resources[resourceType] = 0;
                //}

                //resources[resourceType] += resourceQuantity;

                Console.WriteLine($"{resourceType} -> {resourceQuantity}");

                resourceType = Console.ReadLine();
            }
        }
    }
}

