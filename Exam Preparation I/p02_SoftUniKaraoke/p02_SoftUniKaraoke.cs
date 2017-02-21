using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_SoftUniKaraoke
{
    class p02_SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            var singers = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();
            var songs = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            var output = new Dictionary<string, List<string>>();

            var line = Console.ReadLine();

            while (line != "dawn")
            {
                var performance = line
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s.Trim())
                    .ToArray();

                var singer = performance[0];
                var song = performance[1];
                var award = performance[2];

                if (singers.Contains(singer))
                {
                    if (songs.Contains(song) && !output.ContainsKey(singer))
                    {
                        output[singer] = new List<string>();
                    }

                    if (songs.Contains(song) && !output[singer].Contains(award))
                    {
                        output[singer].Add(award);
                    }

                }
                line = Console.ReadLine();
            }

            if (output.Any())//ако имаме резултат
            {
                foreach (var kvp in output
                    .OrderByDescending(p => p.Value.Count)
                    .ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");

                    foreach (var awards in kvp.Value.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{awards}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
