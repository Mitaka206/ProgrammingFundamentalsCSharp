using System;
using System.Collections.Generic;
using System.Linq;

namespace p001_Demo
{
    class p001_Demo
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            var phoneBook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phoneBook.Add(input[1], input[2]);
                }
                else if (input[0] == "S")
                {
                    if (!phoneBook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{input[1]} -> {phoneBook[input[1]]}");
                    }
                }
                input = Console.ReadLine().Split().ToList();
            }
        }
    }
}
