using System;
using System.Collections.Generic;

namespace p01_PhoneBook
{
    class p01_PhoneBook
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var phoneBook = new Dictionary<string, string>();

            while (!input.Equals("END"))
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if (command.Equals("A"))
                {
                    string contact = commandArgs[1];
                    string phone = commandArgs[2];
                    phoneBook[contact] = phone;
                }
                else if (command.Equals("S"))
                {
                    string contact = commandArgs[1];
                    if (!phoneBook.ContainsKey(contact))
                    {
                        Console.WriteLine($"Contact {contact} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{contact} -> {phoneBook[contact]}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
