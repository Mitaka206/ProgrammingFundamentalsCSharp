using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class p04_RoliTheCoder
{
    static void Main(string[] args)
    {
        var output = new SortedDictionary<string, List<string>>();

        string input = Console.ReadLine();

        while (input != "Time for Code")
        {
            var strings = input.Split(new char[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> aaa = new List<string>();

            Regex regex = new Regex(@"[\d]");

            if (!regex.IsMatch(strings[1]))
            {
                for (int i = 2; i < strings.Count; i++)
                {
                    aaa.Add(strings[i]);
                }
                output[strings[1]] = aaa;
            }

            input = Console.ReadLine();
        }                                 //https://judge.softuni.bg/Contests/Practice/DownloadResource/1662
                                          
        foreach (var item in output)         
        {                                    // мога ли да го подредя или тярбва даси мисля нова логика
            Console.WriteLine($"{item.Key} - {item.Value.Count}");
            Console.WriteLine(string.Join("\r\n", item.Value.OrderBy(x => x)));
        }
    }
}