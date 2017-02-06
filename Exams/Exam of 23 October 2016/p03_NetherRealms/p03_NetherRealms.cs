using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class p03_NetherRealms
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        var output = new SortedDictionary<string, Dictionary<int, decimal>>();

        var players = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        for (int i = 0; i < players.Count; i++)
        {
            var toChar = players[i].Where(c => Char.IsLetter(c)).ToList();
            var intSum = toChar.Select(c => (int)c).Sum();
            
            var toDesimal = getDesimal(players[i]).ToList();
            var desimaSum = toDesimal.Sum();

            Console.WriteLine($"{players[i]} - {intSum} health, {desimaSum*2*2:f2} damage");

            if (!output.ContainsKey(players[i]))
            {
               // output[players[i]].Add(intSum);
            }
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
