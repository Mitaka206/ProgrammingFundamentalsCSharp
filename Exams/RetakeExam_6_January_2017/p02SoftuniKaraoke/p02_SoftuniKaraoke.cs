using System;
using System.Collections.Generic;
using System.Linq;

namespace p02SoftuniKaraoke
{
    class p02_SoftuniKaraoke
    {
        static void Main(string[] args)
        {
            var singers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();
            var output = new Dictionary<string, List<string>>();

            while (input != "dawn")
            {
                var awards = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Last();
                var currentSinger = input.Split(',').First();

                for (int i = 0; i < singers.Count; i++)
                {
                    if (singers[i] == currentSinger)
                    {
                        if (!output.ContainsKey(currentSinger))
                        {
                            output[currentSinger] = new List<string>();
                        }
                        if (!output[currentSinger].Contains(awards) && !awards.Any(char.IsDigit))
                        {
                            output[currentSinger].Add(awards);
                        }
                    }
                }

                input = Console.ReadLine();
            }/// no chance

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                foreach (var items in item.Value)
                {
                    Console.WriteLine($"--{items}");
                }
            }

        }
    }
}
