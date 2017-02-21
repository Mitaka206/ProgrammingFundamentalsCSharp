using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_RoliTheCoder
{
    class p04_RoliTheCoder
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var output = new Dictionary<string, List<string>>();

            while (line != "Time for Code")
            {
                var groups = @"#[A-Za-z]*";
                var coders = @"@[A-Za-z].*";

                var group = Regex.Match(line, groups).ToString();

                var coderMatch = Regex.Match(line, coders)
                    .ToString()
                    .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(c => c.Trim())
                    .ToList();
                
                if (!output.ContainsKey(group))
                {
                    output[group] = new List<string>();
                }
                output[group] = coderMatch.Distinct().ToList();
                
                line = Console.ReadLine();
            }

            foreach (var kvp in output.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{kvp.Key.Substring(1)} - {kvp.Value.Count}");

                foreach (var coder in kvp.Value.OrderBy(a => a))
                {
                    Console.WriteLine($"{coder}");
                }
            }
        }
    }
}
