using System;
using System.Text.RegularExpressions;

namespace p02_ExtractSentencesByKeyword
{
    class p02_ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            var keyword = Console.ReadLine();

            var text = Console.ReadLine();

            var output = Regex.Matches(text, @"(\S.+?[.!?])(?=\s+|$)");

            for (int i = 0; i < output.Count; i++)
            {
                if (output[i].ToString().Contains(keyword + " "))
                {
                    Console.WriteLine(output[i].ToString().Trim('.', '!', '?'));
                }
            }
        }
    }
}
