using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_WinningTicket
{
    class p04_WinningTicket
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(i => i.Trim())
                .ToArray();

            foreach (var tiket in input)
            {
                if (tiket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (tiket.Contains("@")
                    || tiket.Contains("$")
                    || tiket.Contains("#")
                    || tiket.Contains("^"))
                {
                    var leftPart = string.Join("", Regex.Match(string.Join("", tiket.Take(10)), @"\$+|@+|\^+|#+"));
                    var rightPart = string.Join("", Regex.Match(string.Join("", tiket.Skip(10)), @"\$+|@+|\^+|#+"));

                    if (leftPart[0] == rightPart[0] && leftPart.Length >= 6 && leftPart.Length <= 10)
                    {
                        var partCount = leftPart.Length;

                        if (partCount >= 6 && partCount <= 9)
                        {
                            Console.WriteLine($"ticket \"{tiket}\" - {partCount}{leftPart[0]}");
                        }

                        if (partCount == 10)
                        {
                            Console.WriteLine($"ticket \"{tiket}\" - 10{leftPart[0]} Jackpot!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tiket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{tiket}\" - no match");
                }
            }
        }
    }
}

