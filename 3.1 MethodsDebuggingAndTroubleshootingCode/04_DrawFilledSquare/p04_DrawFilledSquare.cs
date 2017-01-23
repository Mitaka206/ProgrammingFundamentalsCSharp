using System;

namespace _04_DrawFilledSquare
{
    class p04_DrawFilledSquare
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());

            FilledSquare(index);
        }

        public static void FilledSquare(int index)
        {
            RepaedString("-", index * 2);
            Console.WriteLine();

            for (int i = 0; i < index - 2; i++)
            {
                Console.Write("-");
                RepaedString("\\/", index - 1);
                Console.WriteLine("-");
            }

            RepaedString("-", index * 2);
        }

        public static void RepaedString(string symbol, int index)
        {
            for (int i = 0; i < index; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
