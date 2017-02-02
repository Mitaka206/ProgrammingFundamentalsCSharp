using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_CountRealNumbers
{
    class p01_CountRealNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var dictCount = new SortedDictionary<double, int>();
            
            foreach (var item in input)
            {
                if (!dictCount.ContainsKey(item))
                {
                    dictCount[item] = 0;
                }
                dictCount[item]++;
            }

            foreach (var item in dictCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
