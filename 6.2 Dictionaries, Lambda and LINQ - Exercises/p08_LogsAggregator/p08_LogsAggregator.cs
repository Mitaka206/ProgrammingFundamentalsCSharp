using System;
using System.Collections.Generic;
using System.Linq;

namespace p08_LogsAggregator
{
    class p08_LogsAggregator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var output = new SortedDictionary<string, int>();
            var list = new List<string>();

            var mazalo = new SortedDictionary<SortedDictionary<string, int>, List<string>>();

            string[] arr;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                arr = input.Split();

                string ip = arr[0];
                string name = arr[1];
                int duration = int.Parse(arr[2]);

                if (!output.ContainsKey(name))
                {
                    output[name] = 0;
                }
                output[name] += duration;

                //??????????????

            }

        }
    }
}
