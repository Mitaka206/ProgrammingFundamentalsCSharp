using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_RoliTheCoderOK
{
    class p04_RoliTheCoderOK
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, List<string>>> eventDB =
                new Dictionary<string, Dictionary<string, List<string>>>();

            string input = Console.ReadLine();

            while (!input.Equals("Time for Code"))
            {


                string pattern = @"[0-9a-zA-Z]+\s+#[0-9a-zA-Z]+\s*(@[a-zA-Z]+\s*)*";
                Regex regex = new Regex(pattern);
                if (!regex.IsMatch(input))
                {
                    goto end;
                }
                var coders = input.Split('#').ToList();
                char[] splitter = new char[] { '@', ' ' };
                string[] eventNameAndPeople = coders[1].Split(splitter, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string id = coders[0];
                string eventName = eventNameAndPeople[0];

                List<string> participants = new List<string>();

                for (int i = 1; i < eventNameAndPeople.Count(); i++)
                {
                    participants.Add(eventNameAndPeople[i]);
                }

                if (!eventDB.ContainsKey(id))
                {
                    eventDB.Add(id, new Dictionary<string, List<string>>());
                    eventDB[id].Add(eventName, new List<string>());
                    for (int i = 0; i < participants.Count; i++)
                    {
                        eventDB[id][eventName].Add(participants[i]);
                    }
                }
                else
                {
                    if (!eventDB[id].ContainsKey(eventName))
                    {
                        goto end;
                    }
                    else
                    {
                        for (int i = 0; i < participants.Count; i++)
                        {
                            if (eventDB[id][eventName].Contains(participants[i]))
                            {
                                continue;
                            }
                            else
                            {
                                eventDB[id][eventName].Add(participants[i]);
                            }
                        }
                    }
                }
            end: input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> pair in eventDB.OrderByDescending(a => a.Value.Values.Sum(p => p.Count)).ThenBy(a => a.Key))
            {
                foreach (KeyValuePair<string, List<string>> innerpair in eventDB[pair.Key])
                {
                    Console.WriteLine($"{innerpair.Key} - {innerpair.Value.Count}");
                    eventDB[pair.Key][innerpair.Key].Sort();
                    for (int i = 0; i < innerpair.Value.Count; i++)
                    {
                        Console.WriteLine("@" + eventDB[pair.Key][innerpair.Key][i]);
                    }
                }

            }
        }
    }
}
