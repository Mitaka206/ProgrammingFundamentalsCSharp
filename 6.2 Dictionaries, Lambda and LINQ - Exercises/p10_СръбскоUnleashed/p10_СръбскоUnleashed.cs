using System;
using System.Collections.Generic;
using System.Linq;

namespace p10_СръбскоUnleashed
{
    class p10_СръбскоUnleashed
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string name = string.Empty;
            string money = string.Empty;
            var title = new List<string>();

            var cast = new Dictionary<string, string>();

            while (input != "End")
            {
                name = input.Split('@')
                    .First()
                    .Trim();
                money = input.Split(new string[] { "@Sunny Beach ", "@Belgrade ", }, StringSplitOptions.RemoveEmptyEntries)
                    .Last()
                    .ToString();
               // int moneys = MoneyInt(money);

                title = input.Split('@', ' ')
                    .Skip(2)
                    .Reverse()
                    .Skip(2)
                    .Reverse()
                    .ToList();

                //if (name == "Sunny Beach" || name != "Belgrade")
                //{
                //    cast[name] += 0;
                //}
                //Console.WriteLine(money);
                //input = Console.ReadLine();
            }

            foreach (var item in cast)
            {
                Console.WriteLine(string.Join(" ", title));
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
            //Console.WriteLine(money);

            //Console.WriteLine(string.Join(" ", title));
        }

        private static int MoneyInt(string money)
        {
            return int.Parse(money);
        }
    }
}
