using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_WinningTicket
{
    class p04_WinningTicket
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var ticket = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.WriteLine(string.Join(" ", ticket));
            Console.WriteLine();
            int max = 0;
            string jack = "10$ Jackpot!";

            for (int i = 0; i < ticket.Count; i++)
            {
                if (ticket[i].Contains('$') || ticket[i].Contains('@') || ticket[i].Contains('#') || ticket[i].Contains('^'))
                {
                    var winSymbols = ticket[i].ToString().Split(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }, StringSplitOptions.RemoveEmptyEntries).OrderByDescending(x => x.Count()).ToList();
                    string oneSymbol = winSymbols[0].Distinct().ToString();

                    if (winSymbols.Count() > max)
                    {
                        max = winSymbols[0].Count();
                        
                        if (max >= 10)
                        {
                            Console.WriteLine($"ticket {ticket[i]} - {jack}");
                        }
                        else if (max >= 6 || max <= 9)
                        {
                            Console.WriteLine($"ticket {ticket[i]} - {max}{oneSymbol}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid ticket");
                        }
                    }
                }
                
            }
            
        }
    }
}

