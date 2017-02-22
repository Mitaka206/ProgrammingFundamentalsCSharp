using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace p03_RageQuit
{
    class p03_RageQuit
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();
            
            Regex regex = new Regex(@"(\D+)(\d+)");

            MatchCollection collection = regex.Matches(input);

            StringBuilder output = new StringBuilder();

            foreach (Match match in collection)
            {
                for (int i = 0; i < int.Parse(match.Groups[2].ToString()); i++)
                {
                    output.Append(match.Groups[1]);
                }
            }
            var uniqueSymbols = output.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(string.Join("", output));

        }
    }
}
