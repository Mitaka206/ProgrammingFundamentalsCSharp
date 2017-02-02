using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_OddOccurrences
{
    class p02_OddOccurrences
    {
        static void Main(string[] args)
        {

            char[] delimiters = ",;:.!()\"\'\\/[] ".ToCharArray();

            List<string> input = Console.ReadLine().ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

            var dictCount = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (!dictCount.ContainsKey(item))
                {
                    dictCount[item] = 0;
                }
                dictCount[item]++;
            }

            List<string> output = new List<string>();

            foreach (var item in dictCount)
            {
                if (item.Value %2 != 0)
                {
                    output.Add(item.Key); 
                }
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
