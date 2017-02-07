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
            
            var mazalo = new SortedDictionary<SortedDictionary<string, int>, List<string>>();
            var output = new SortedDictionary<string, int>();
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

                if (output.ContainsKey(name))//---?????????????????
                {
                    mazalo[output] = new List<string>();
                    //как да пълня неща в листа????????????????????
                }
            }
            
            foreach (var item in mazalo)
            {
                foreach (var names in output)
                {
                    Console.WriteLine($"{names.Key}: {names.Value} [{string.Join(", ", item.Value)}]");
                }
            }
        }
    }
}
