using System;
using System.Collections.Generic;
using System.Linq;

namespace p10_SerbianUnleashed
{
    class p10_SerbianUnleashed
    {
        static void Main(string[] args)
        {

            var singers = new Dictionary<string, Dictionary<string, long>>();

            string[] input;
            while (true)
            {
                input = Console.ReadLine().Split(' ');

                if (input[0] == "End")
                {
                    break;
                }

                bool getLocation = false;

                string singer = string.Empty;
                string location = string.Empty;

                int ticketsPrice = 0;
                int ticketsCount = 0;

                if (int.TryParse(input[input.Length - 2], out ticketsPrice) && int.TryParse(input[input.Length - 1], out ticketsCount))
                {
                    for (int i = 0; i < input.Length - 2; i++)
                    {
                        if (input[i][0] == '@' || getLocation)
                        {
                            location += input[i] + " ";
                            getLocation = true;
                        }
                        else
                        {
                            singer += input[i] + " ";
                        }
                    }
                    
                    if (singer.Length > 0 && location.Length > 0)
                    {
                        singer = singer.Trim();
                        location = location.Trim().Substring(1);

                        if (!singers.ContainsKey(location))
                        {
                            singers.Add(location, new Dictionary<string, long>());
                        }

                        long oldPrice = 0;
                        singers[location].TryGetValue(singer, out oldPrice);
                        singers[location][singer] = oldPrice + ticketsCount * ticketsPrice;
                    }
                }
            }

            foreach (var places in singers)
            {
                Console.WriteLine(places.Key);
                var singerPrice = places.Value.OrderByDescending(pair => pair.Value);

                foreach (var singer in singerPrice)
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
