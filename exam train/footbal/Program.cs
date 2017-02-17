using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace footbal
{
    class Program
    {
        static void Main(string[] args)
        {
            var trim = Console.ReadLine();
            var input = Console.ReadLine();

            var points = new Dictionary<string, int>();
            var top3 = new Dictionary<string, int>();

            while (input == "final")
            {
                var aaa = input.Split(new string[] { trim }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                StringBuilder output = new StringBuilder();
                for (int i = 0; i < aaa.Length; i++)
                {
                    output.Append(aaa[i] + "@");
                }
                string basi = output.ToString();

                var colection = Regex.Matches(basi, @"([A-z]{4,12})|(\d+:\d+)");

                string firstCountry = colection[0].ToString().ToUpper();
                string secondCountry = colection[1].ToString().ToUpper();
                string result = colection[2].ToString();

                firstCountry = string.Join("", firstCountry.Reverse());
                secondCountry = string.Join("", secondCountry.Reverse());
                var countryScore = result.Split(':').Select(int.Parse).ToArray();
                int countyScoreFirst = countryScore[0];
                int countyScoreSecond = countryScore[2];



                input = Console.ReadLine();
            }
        }
    }
}
