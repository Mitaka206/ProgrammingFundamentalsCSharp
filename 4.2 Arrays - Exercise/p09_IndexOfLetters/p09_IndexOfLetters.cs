using System;

namespace p09_IndexOfLetters
{
    class p09_IndexOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string[] alphaBet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphaBet.Length; j++)
                {
                    if (input[i].ToString().Contains(alphaBet[j]))
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                    }
                }
            }
        }
    }
}
