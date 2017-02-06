using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class p03_NetherRealms
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        var output = new SortedDictionary<string, List<decimal>>();

        var players = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        for (int i = 0; i < players.Count; i++)
        {
            var toChar = players[i].Where(c => Char.IsLetter(c)).ToList();
            var intSum = toChar.Select(c => (decimal)c).Sum();
            
            var toDesimal = getDesimal(players[i]).ToList();
            var desimaSum = toDesimal.Sum();

            var skils = new List<decimal>() { intSum, desimaSum };

            if (!output.ContainsKey(players[i]))
            {
                output[players[i]] = skils;
            }
        }

        foreach (var item in output)
        {
            Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1] * 2 * 2:f2} damage");
        }
    }
    public static decimal[] getDesimal(string input)
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
