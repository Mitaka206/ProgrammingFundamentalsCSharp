using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03_RageQuit //https://judge.softuni.bg/Contests/Practice/DownloadResource/1655
{
    class p03_RageQuit
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();

            var numbers = input.Where(c => char.IsDigit(c)).ToList();

            var uniqueSymbols = Regex.Replace(input, @"[\d-]", string.Empty)
                .Distinct()
                .Count();

            var strings = Regex.Split(input, @"\d+").ToList(); //get strings - ASD, &, S@

            var output = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < int.Parse(numbers[i].ToString()); j++)
                {
                    output.Add(strings[i]);
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(string.Join("", output));

        }
    }
}
