using System;
using System.Collections.Generic;

namespace p04_FixEmails
{
    class p04_FixEmails
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine();

                string domain = email.Substring(email.Length - 2, 2).ToLower();

                if (domain != "uk" && domain != "us")
                {
                    emails[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }  
    }
}
