using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_CountNumbers
{
    class p07_CountNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<int, int> output = new SortedDictionary<int, int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (output.ContainsKey(input[i]))
                {
                    output[input[i]]++;
                }
                else
                {
                    output[input[i]] = 1;
                }
            }

            foreach (KeyValuePair<int, int> pair in output)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
