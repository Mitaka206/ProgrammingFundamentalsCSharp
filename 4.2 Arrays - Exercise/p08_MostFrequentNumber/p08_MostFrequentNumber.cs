using System;
using System.Linq;

namespace p08_MostFrequentNumber
{
    class p08_MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            var nums = input.Select((n, i) => new { Value = n, Index = i })
            .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
            .GroupBy(s => new { s.Value, s.Diff })
            .OrderByDescending(g => g.Count())
            .First()
            .Select(f => f.Value)
            .ToArray();

            Console.WriteLine(nums[0]);
        }
    }
}
