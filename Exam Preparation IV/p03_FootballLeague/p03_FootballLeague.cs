using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace p03_FootballLeague
{
    class p03_FootballLeague
    {
        static void Main(string[] args)
        {
            var pattern = @"(\d+):(\d+)";

            var key = Console.ReadLine();

            var line = Console.ReadLine();

            var points = new Dictionary<string, int>();
            var score = new Dictionary<string, int>();

            while (line != "final")
            {
                var teams = line
                .Split(new string[] { key }, StringSplitOptions.None)//NB
                .ToArray();

                var firstTeam = string.Join("", teams[1].ToUpper().Reverse().ToArray());
                var secondTeam = string.Join("", teams[teams.Length - 2].ToUpper().Reverse().ToArray());

                // Console.WriteLine($"{firstTeam} {secondTeam}");
                var scores = Regex.Match(line, pattern);

                var firstScore = int.Parse(scores.Groups[1].Value);
                var secondScore = int.Parse(scores.Groups[2].Value);

                if (!score.ContainsKey(firstTeam) || !score.ContainsKey(secondTeam))
                {
                    score[firstTeam] = 0;//---------------------
                    score[secondTeam] = 0;//---------------------
                }
                score[firstTeam] += firstScore;
                score[secondTeam] += secondScore;

                if (!points.ContainsKey(firstTeam) || !points.ContainsKey(secondTeam))
                {
                    points[firstTeam] = 0;//-------------------------
                    points[secondTeam] = 0;//---------------------------
                }

                if (firstScore > secondScore)
                {
                    points[firstTeam] += 3;
                }
                if (secondScore > firstScore)
                {
                    points[secondTeam] += 3;
                }
                if (secondScore == firstScore)
                {
                    points[secondTeam]++;
                    points[firstTeam]++;
                }


                line = Console.ReadLine();
            }

            int place = 1;
            Console.WriteLine("League standings:");
            foreach (var item in points.OrderByDescending(s => s.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{place++}. {item.Key} {item.Value}");
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in score.OrderByDescending(s => s.Value).ThenBy(t => t.Key).Take(3))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

        }
    }
}
