using System;

namespace p02_AdvertisementMessage
{
    class p02_AdvertisementMessage
    {
        static void Main(string[] args)
        {
            string[] phrases = new[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] events = new[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] autor = new[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = new[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{phrases[random.Next(0, phrases.Length)]} { events[random.Next(0, events.Length)]} { autor[random.Next(0, autor.Length)]} - {cities[random.Next(0, cities.Length)]}");
            }

        }
    }
}
