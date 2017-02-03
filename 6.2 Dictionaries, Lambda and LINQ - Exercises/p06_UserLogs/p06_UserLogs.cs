using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_UserLogs
{
    class p06_UserLogs
    {
        static void Main(string[] args)
        {

            var dict = new SortedDictionary<string, SortedDictionary<string, int>>();

            string input = Console.ReadLine();
            int count = 1;
            while (!input.Equals("end") && count < 50)
            {
                count++;
                string[] inputIp = input.Split(' ', '=');
                string[] inputUser = input.Split('=');

                string user = inputUser.Last();
                string ip = inputIp[1];

                if (user.Length >=3 && user.Length<=50)
                {
                    if (!dict.ContainsKey(user))
                    {
                        dict[user] = new SortedDictionary<string, int>();
                    }

                    if (!dict[user].ContainsKey(ip))
                    {
                        dict[user][ip] = 1;
                    }
                    else
                    {
                        dict[user][ip]++;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + ":");
                
                foreach (var items in item.Value)
                {
                    if (items.Key != item.Value.Keys.Last())
                    {
                        Console.Write($"{items.Key} => {items.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{items.Key} => {items.Value}. ");
                    }
                    
                }
            }
        }
    }
}
