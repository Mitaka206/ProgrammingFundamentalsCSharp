using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_PhonebookUpgrade
{
    class p02_PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var phoneBook = new Dictionary<string, string>();
            
            while (!input.Equals("END"))
            {
                string[] inputArgs = input.Split();
                string command = inputArgs[0];

                if (command.Equals("A"))
                {
                    string contact = inputArgs[1];
                    string phone = inputArgs[2];
                    phoneBook[contact] = phone;
                }
                else if (command.Equals("S"))
                {
                    string contact = inputArgs[1];
                    if (!phoneBook.ContainsKey(contact))
                    {
                        Console.WriteLine($"Contact {contact} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{contact} -> {phoneBook[contact]}");
                    }
                }
                else if (command.Equals("ListAll"))
                {
                    foreach (var item in phoneBook.OrderBy(name => name.Key))
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
