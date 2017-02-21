using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03_NetherRealms
{
    class p03_NetherRealms
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var output = new SortedDictionary<string, List<decimal>>();

            var players = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < players.Count; i++)
            {
                var toChar = players[i].Where(c => Char.IsLetter(c) || Char.IsSymbol(c)).ToList();// 
                var intSum = toChar.Select(c => (decimal)c).Sum();

                var toDesimal = GetDesimal(players[i]).ToList();
                var desimalSum = toDesimal.Sum();

                foreach (char c in players[i].Where(c => c == '*' || c == '/'))
                {
                    if (c == '*')
                    {
                        desimalSum *= 2;
                    }
                    else
                    {
                        desimalSum /= 2;
                    }
                }

                if (!output.ContainsKey(players[i]))
                {
                    output[players[i]] = new List<decimal>() { intSum, desimalSum };
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]:f2} damage");
            }
        }
        public static decimal[] GetDesimal(string input)
        {
            int n = 0;
            MatchCollection matches = Regex.Matches(input, @"[+-]?\d+(\.\d+)?");
            decimal[] decimalarray = new decimal[matches.Count];

            foreach (Match m in matches)
            {
                decimalarray[n] = decimal.Parse(m.Value);
                n++;
            }
            return decimalarray;
        }
    }
}
