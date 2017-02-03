using System;
using System.Collections.Generic;

namespace p001_Demo
{
    class p001_Demo
    {
        static void Main(string[] args)
        {
            var outDict = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] inputIp = input.Split();
                
                string ip = inputIp[0];

                foreach (var item in inputIp)
                {
                    if (!outDict.ContainsKey(ip))
                    {
                        outDict[ip] = 0;
                    }
                    outDict[ip]++;
                }
                input = Console.ReadLine();
            }

            foreach (var item in outDict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            
        }
        
    }
}

