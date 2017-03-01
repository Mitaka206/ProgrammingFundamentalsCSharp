using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace p4
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(^\d+)\s+=\s+(\w+.*)\s+->\s+(\w+.*):(\d+$)");

            int lines = int.Parse(Console.ReadLine());

            var first = new Dictionary<string, Dictionary<string, int>>();
            var second = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();
                var match = regex.Match(input);

                if (match.Success)
                {
                    var lastActivity = int.Parse(match.Groups[1].Value);
                    var legionName = match.Groups[2].Value;
                    var soldierType = match.Groups[3].Value;
                    var soldierCount = int.Parse(match.Groups[4].Value);

                    if (!first.ContainsKey(soldierType))
                    {
                        first[soldierType] = new Dictionary<string, int>();
                    }
                    if (!first[soldierType].ContainsKey(legionName))
                    {
                        first[soldierType][legionName] = 0;
                    }
                    first[soldierType][legionName] += soldierCount;
                    
                }
            }
            
            var command = Console.ReadLine();


            if (command.Contains("\\"))
            {
                foreach (var item in first)
                {
                    var comm = command.Split('\\').ToArray();

                    var dig = int.Parse(comm[0]);
                    var solType = comm[1];

                    if (item.Key.Contains(solType))
                    {
                        foreach (var kvp in item.Value)
                        {
                            Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                        }
                    }
                    
                }
            }
            else
            {
                foreach (var item in second)
                {
                    foreach (var kvp in item.Value)
                    {
                        Console.WriteLine($"{kvp.Value} : {kvp.Key}");
                    }
                }
            }
        }
    }
}
