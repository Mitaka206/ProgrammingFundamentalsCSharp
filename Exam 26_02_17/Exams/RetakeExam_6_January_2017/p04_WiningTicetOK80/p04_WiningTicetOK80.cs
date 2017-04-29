using System;
using System.Linq;

namespace Winning_Ticket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            var inputTicket = Console.ReadLine().Split(new char[] { ' ', '\n', '\r', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < inputTicket.Length; i++)
            {
                if (inputTicket[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if ((inputTicket[i].Contains("@")
                    || inputTicket[i].Contains("#")
                    || inputTicket[i].Contains("^")
                    || inputTicket[i].Contains("$"))
                    && inputTicket[i].Length == 20)
                {

                    var output = inputTicket[i].ToLower().Split(new char[] { ' ', ',', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }, StringSplitOptions.RemoveEmptyEntries).OrderByDescending(x => x).ToList();

                    var symbol = string.Join("", output[0].ToCharArray().Take(1));

                    int count = output[0].Count();

                    if (output.Count > 1)
                    {
                        count = Math.Min(output[0].Count(), output[1].Count());
                    }

                    if (count <= 9
                        && count >= 6)
                    {
                        Console.WriteLine($"ticket \"{ inputTicket[i] }\" - {count}{symbol}");
                    }
                    if (count /2 == 10)
                    {
                        Console.WriteLine($"ticket \"{ inputTicket[i] }\" - 10{symbol} Jackpot!");
                    }

                    if (count < 6)
                    {
                        Console.WriteLine($"ticket \"{ inputTicket[i] }\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ inputTicket[i] }\" - no match");
                }
            }
        }
    }
}
