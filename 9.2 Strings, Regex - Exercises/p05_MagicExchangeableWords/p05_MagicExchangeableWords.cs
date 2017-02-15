using System;
using System.Collections.Generic;

namespace p05_MagicExchangeableWords
{
    class p05_MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var first = input[0];     // aabbdd
            var second = input[1];    // sshhrr

            var charDict = new Dictionary<char, char>();

            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                if (!charDict.ContainsKey(first[i]))
                {
                    charDict[first[i]] = second[i];
                }
                else if (charDict.ContainsValue(second[i]))
                {
                    Console.WriteLine("true");
                    break;
                }
            }
            if (first.Length != second.Length)
            {
                Console.WriteLine("false");
            }

        }
    }

}


