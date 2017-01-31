using System;
using System.Linq;

namespace p01_MaxSequenceEqualElements
{
    class p01_MaxSequenceEqualElements
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var output = input.Select((n, i) => new { Value = n, Index = i })
            .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
            .GroupBy(s => new { s.Value, s.Diff })
            .OrderByDescending(g => g.Count())
            .First()
            .Select(f => f.Value)
            .ToList();

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
