namespace P4_HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class P4_HornetArmada
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var InputPattern = new Regex(@"(?<lastActiviti>\d+) = (?<legionName>.*?) -> (?<soldierType>.*?):(?<soldierCount>\d+)");

            var legions = new List<Legions>();// L

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var match = InputPattern.Match(input);

                if (match.Success)
                {
                    var soldierType = match.Groups["soldierType"].Value;
                    var soldierCount = long.Parse(match.Groups["soldierCount"].Value);

                    var legion = new Legions
                    {
                        Activity = long.Parse(match.Groups["lastActiviti"].Value),
                        Name = match.Groups["legionName"].Value,
                        Soldiers = new Dictionary<string, long>()
                    };

                    if (!legions.Any(l => l.Name == legion.Name))
                    {
                        legions.Add(legion);// L
                    }

                    if (legions.Find(l => l.Name == legion.Name).Activity < legion.Activity)
                    {
                        legions.Find(l => l.Name == legion.Name).Activity = legion.Activity;
                    }

                    if (!legions.Find(l => l.Name == legion.Name).Soldiers.ContainsKey(soldierType))
                    {
                        legions.Find(l => l.Name == legion.Name).Soldiers[soldierType] = 0;
                    }

                    legions.Find(l => l.Name == legion.Name).Soldiers[soldierType] += soldierCount;

                }
            }

            var command = Console.ReadLine();

            var commandPattern = new Regex(@"(?<activity>\d+)\\(?<type>.*)");

            var commandMatch = commandPattern.Match(command);

            var sType = command;

            if (commandMatch.Success)
            {
                var activityLimit = long.Parse(commandMatch.Groups["activity"].Value);
                sType = commandMatch.Groups["type"].Value;

                foreach (var legion in legions.Where(l => l.Activity < activityLimit && l.Soldiers.ContainsKey(sType)).OrderByDescending(l => l.Soldiers[sType]))
                {
                    Console.WriteLine($"{legion.Name} -> {legion.Soldiers[sType]}");
                }
            }
            else
            {
                foreach (var legion in legions.Where(l => l.Soldiers.ContainsKey(sType)).OrderByDescending(l => l.Activity))
                {
                    Console.WriteLine($"{legion.Activity} : {legion.Name}");
                }
            }
        }
    }

    public class Legions
    {
        public long Activity { get; set; }

        public string Name { get; set; }

        public Dictionary<string, long> Soldiers { get; set; }// type, count
    }
}
