namespace P3_FutballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class P3_FutballLeague
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            key = Regex.Escape(key);

            var regexPattern = new Regex($@"{key}(?<team1>.*?){key}.+?{key}(?<team2>.*?){key}.+?(?<score1>\d+):(?<score2>\d+)");

            var teamScores = new Dictionary<string, long>();
            var teamGoals = new Dictionary<string, long>();

            var input = Console.ReadLine();

            while (input != "final")
            {
                var match = regexPattern.Match(input);

                if (match.Success)
                {
                    var firstTeam = match.Groups["team1"].Value;                // bulgaria
                    var secondTeam = match.Groups["team2"].Value;               // france
                    var firstScore = long.Parse(match.Groups["score1"].Value);  // 2 
                    var secondScore = long.Parse(match.Groups["score2"].Value); // 5

                    if (!teamScores.ContainsKey(firstTeam))
                    {
                        teamScores[firstTeam] = 0;
                    }
                    if (!teamScores.ContainsKey(secondTeam))
                    {
                        teamScores[secondTeam] = 0;
                    }
                    if (firstScore == secondScore)
                    {
                        teamScores[firstTeam] += 1;
                        teamScores[secondTeam] += 1;
                    }
                    if (firstScore > secondScore)
                    {
                        teamScores[firstTeam] += 3;
                    }
                    if (secondScore > firstScore)
                    {
                        teamScores[secondTeam] += 3;
                    }
                    
                    if (!teamGoals.ContainsKey(firstTeam))
                    {
                        teamGoals[firstTeam] = 0;
                    }
                    if (!teamGoals.ContainsKey(secondTeam))
                    {
                        teamGoals[secondTeam] = 0;
                    }
                    teamGoals[firstTeam] += firstScore;
                    teamGoals[secondTeam] += secondScore;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("League standings:");
            var count = 0;
            foreach (var item in teamScores.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                count++;
                Console.WriteLine($"{count}. {string.Join("", item.Key.ToUpper().Reverse())} {item.Value}");
            }


            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in teamGoals.OrderByDescending(t => t.Value).ThenBy(a => a.Key).Take(3))
            {
                Console.WriteLine($"- {string.Join("", item.Key.ToUpper().Reverse())} -> {item.Value}");
            }
        }
    }
}
