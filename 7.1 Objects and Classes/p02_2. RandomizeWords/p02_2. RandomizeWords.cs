using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02_2.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var random = new Random();

            for (int i = 0; i < input.Count; i++)
            {
                var currentWord = input[i];
                var randIndex = random;
            }
        }
    }
}
