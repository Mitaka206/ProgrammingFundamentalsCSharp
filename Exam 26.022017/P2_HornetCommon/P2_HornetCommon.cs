namespace P2_HornetCommon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class P2_HornetCommon
    {
        static void Main(string[] args)
        {
            var input = string.Empty;

            var messages = new List<string>();
            var broadcasts = new List<string>();

            while (input != "Hornet is Green")
            {
                input = Console.ReadLine();

                var digitPattern = new Regex(@"(?<first>^\d+) <-> (?<second>[a-zA-Z0-9]+)$"); //first IsDigit
                var symbolPattern = new Regex(@"(?<first>^\D+) <-> (?<second>[a-zA-Z0-9]+)$"); //first everything and Digit

                var firstIsDigit = digitPattern.Match(input);
                var firstIsEverything = symbolPattern.Match(input);

                if (firstIsDigit.Success)
                {
                    //messages
                    var firstQuery = new string(firstIsDigit.Groups["first"].Value.Reverse().ToArray());
                    var secondQuery = firstIsDigit.Groups["second"].Value;

                    messages.Add($"{firstQuery} -> {secondQuery}");
                }

                if (firstIsEverything.Success)
                {
                    //broadcasts
                    var firstQuery = firstIsEverything.Groups["first"].Value;
                    var secondQuery = firstIsEverything.Groups["second"].Value;

                    var freqLowUp = string.Empty;


                    foreach (var item in secondQuery)
                    {
                        if (item >= 'A' && item <= 'Z')// is upper case
                        {
                            freqLowUp = string.Concat(freqLowUp, (char)(item + 32));
                        }
                        else if(item >= 'a' && item <= 'z')// is lower case
                        {
                            freqLowUp = string.Concat(freqLowUp, (char)(item - 32));
                        }
                        else// is others
                        {
                            freqLowUp = string.Concat(freqLowUp, item);
                        }
                    }

                    broadcasts.Add($"{freqLowUp} -> {firstQuery}");
                }
            }
            Console.WriteLine("Broadcasts:");
            PrintResult(broadcasts);

            Console.WriteLine("Messages:");
            PrintResult(messages);
        }
        public static void PrintResult(List<string> output)
        {
            if (output.Any())
            {
                foreach (var item in output)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
