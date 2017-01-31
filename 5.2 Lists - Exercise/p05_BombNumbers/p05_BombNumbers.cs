using System;
using System.Linq;

namespace p05_BombNumbers
{
    class p05_BombNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var actions = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNum = actions[0];
            int powerNum = actions[1];

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == bombNum)
                {
                    int left = Math.Max(i - powerNum, 0);

                    int right = Math.Min(i + powerNum, input.Count - 1);

                    int lenght = right - left + 1;
                    //int lenght = powerNum * 2 + 1;
                    input.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            //d'Eba Ma'amu
            //Console.WriteLine(string.Join(" ", input));
            //sum = input.Sum();
            Console.WriteLine(input.Sum());
        }
    }
}
