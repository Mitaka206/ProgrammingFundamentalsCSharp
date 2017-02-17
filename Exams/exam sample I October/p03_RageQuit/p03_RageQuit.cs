using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace p03_RageQuit 
{
    class p03_RageQuit
    {
        static void Main(string[] args)
        {              
            var input = Console.ReadLine().ToUpper();//jJlY$2@5y3 --> JJLY$2@5Y3

            Regex regex = new Regex(@"(\D+)(\d+)");// определяме двете групи(1)(2) от (НЕчисла)(числа)

            MatchCollection collection = regex.Matches(input);//разделяме на колекция  -> JJLY$2  @5  Y3  -> (гр1: JJLY @ Y) (гр2: 2 5 3)
            
            StringBuilder output = new StringBuilder();

            foreach (Match item in collection)
            {
                for (int i = 0; i < int.Parse(item.Groups[2].ToString()); i++)
                {
                    output.Append(item.Groups[1]);//долепяме item пъти (2;5;3)
                }
            }
            var uniqueSymbols = output.ToString().Distinct().Count();// трябва да броим outpu за по-сигурно

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(string.Join("", output));

        }
    }
}
