using System;
using System.Numerics;

namespace p04_CharacterMultiplier
{
    class p04_CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            BigInteger sum = 0;

            var first = input[0].ToCharArray();
            var second = input[1].ToCharArray();

            var minLen = Math.Min(first.Length, second.Length);

            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += first[i] * second[i];
                }
            }
            else
            {
                for (int i = 0; i < minLen; i++)
                {
                    sum += first[i] * second[i];
                }
                var reminder = Math.Abs(first.Length - second.Length);

                for (int i = Math.Max(first.Length, second.Length) - reminder; i <= reminder; i++)
                {
                    if (first.Length > second.Length)
                    {
                        sum += first[i];
                    }
                    else
                    {
                        sum += second[i];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
