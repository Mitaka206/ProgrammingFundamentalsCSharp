using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_PopulationCounter
{
    class p07_PopulationCounter
    {
        static void Main(string[] args)
        {

            var fullPopulation = new Dictionary<string, Dictionary<string, long>>();
            
            string input = Console.ReadLine();
            string[] output; 

            while (!input.Equals("report"))
            {
                output = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string city = output[0];
                string county = output[1];
                long population = long.Parse(output[2]);

                if (!fullPopulation.ContainsKey(county))
                {
                    fullPopulation[county] = new Dictionary<string, long>();
                    fullPopulation[county]["total"] = 0;//add ghost city
                }
                fullPopulation[county]["total"] += population;
                fullPopulation[county][city] = population;
                
                input = Console.ReadLine();
            }

            foreach (var item in fullPopulation.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                Console.WriteLine($"{item.Key} (total population: {fullPopulation[item.Key]["total"]}) ");

                foreach (var city in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (city.Key != "total")
                    {
                        Console.WriteLine($"=>{city.Key}: {city.Value}");
                    }
                }
            }
        }
    }
}
