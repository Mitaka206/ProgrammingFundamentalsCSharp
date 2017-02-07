using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03_RageQuit 
{
    class p03_RageQuit
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();

            var numbers = Regex.Split(input, @"\D+").Skip(1).Select(int.Parse).ToList(); // get numbers - 2, 5, 1
            //var numbers = input.Where(c => char.IsDigit(c)).Select(c => int.Parse(c.ToString())).ToList(); // get numbers - 2, 5, 1

            var uniqueSymbols = Regex.Replace(input, @"[\d-]", string.Empty)
                .Distinct()
                .Count();

            var strings = Regex.Split(input, @"\d+").ToList(); //get strings - ASD, &, S@

            var output = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers[i]; j++)
                {
                    output.Add(strings[i]);
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(string.Join("", output));

        }
    }
}
