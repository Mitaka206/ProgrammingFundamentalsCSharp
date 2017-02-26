using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03_futballLeagueRegex
{
    class p03_futballLeagueRegex
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            key = Regex.Escape(key);
            var regex = new Regex($@"{key}(.*?){key}.+?{key}(.*?){key}.+?(\d+):(\d+)");

            var points = new Dictionary<string, long>();
            var goals = new Dictionary<string, long>();

            var line = Console.ReadLine();
            
            while (line != "final")
            {

                var gameScore = regex.Match(line);

                var firstTeam = string.Join("", gameScore.Groups[1]
                    .Value
                    .ToUpper()
                    .Reverse());
                var secondTeam = string.Join("", gameScore.Groups[2]
                    .Value
                    .ToUpper()
                    .Reverse());

                var firstScore = long.Parse(gameScore.Groups[3].Value);
                var secondScore = long.Parse(gameScore.Groups[4].Value);

                if (!goals.ContainsKey(firstTeam))
                {
                    goals[firstTeam] = 0;
                }
                if (!goals.ContainsKey(secondTeam))
                {
                    goals[secondTeam] = 0;
                }
                if (!points.ContainsKey(firstTeam))
                {
                    points[firstTeam] = 0;
                }
                if (!points.ContainsKey(secondTeam))
                {
                    points[secondTeam] = 0;
                }

                goals[firstTeam] += firstScore;
                goals[secondTeam] += secondScore;
                
                if (firstScore > secondScore)
                {
                    points[firstTeam] += 3;
                }
                else if (firstScore < secondScore)
                {
                    points[secondTeam] += 3;
                }
                else
                {
                    points[firstTeam]++;
                    points[secondTeam]++;
                }

                line = Console.ReadLine();
            }

            int place = 1;
            Console.WriteLine("League standings:");
            foreach (var item in points
                .OrderByDescending(s => s.Value)
                .ThenBy(t => t.Key))
            {
                Console.WriteLine($"{place++}. {item.Key} {item.Value}");
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in goals.OrderByDescending(s => s.Value)
                .ThenBy(t => t.Key)
                .Take(3))
            {
                Console.WriteLine($"- {item.Key} -> {item.Value}");
            }
        }
    }
}
