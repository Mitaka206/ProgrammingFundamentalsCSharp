using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p10_СръбскоUnleashed
{
    class p10_СръбскоUnleashed
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string name = string.Empty;

            string moneyString = string.Empty;
            var moneyList = new List<int>();
            int ticketsPrice = 0;
            int ticketsCount = 0;

            var cast = new Dictionary<string, int>();
            var titleList = new List<string>();
            var titleString = string.Empty;

            var output = new Dictionary<string, Dictionary<string, int>>();

            while (input != "End")
            {
                string correctInputPattern = @"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)";

                if (Regex.IsMatch(input, correctInputPattern))
                {
                    name = input.Split('@')
                    .First()
                    .Trim();

                    moneyString = input.Split(new string[] { "@Sunny Beach ", "@Belgrade ", }, StringSplitOptions.RemoveEmptyEntries)
                        .Last()
                        .ToString();
                    moneyList = moneyString.Split(new char[] { ' ', '@' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();
                    ticketsPrice = moneyList[0];
                    ticketsCount = moneyList[1];

                    titleList = input.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries)
                        .Skip(1)
                        .ToList();
                    titleList = titleList.ToString().Split()
                        .Take(1)
                        .ToList();
                    //titleString = 

                    if (!cast.ContainsKey(name))
                    {
                        cast[name] = 0;
                    }
                    cast[name] += ticketsCount * ticketsPrice;
                    ////-------------------------------------------------Help Me, Please !-------------------
                    //if (!output.ContainsKey(titleList))
                    //{
                    //    output[titleList] = new Dictionary<string, int>();
                    //}
                    //output[titleList] = cast;
                    ////--------------------------------------^^^^^^^-------^------------------------^-------------
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", titleList));
            //---------------------------------------------------------------------------------------
            //foreach (var item in output)
            //{
           // Console.WriteLine(string.Join(" ", item));
            //--------------------------------------------^^^^^^-------------------------------^-----
            foreach (var casts in cast.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"#  {casts.Key} -> {casts.Value}");
            }

            //}
        }
    }
}
