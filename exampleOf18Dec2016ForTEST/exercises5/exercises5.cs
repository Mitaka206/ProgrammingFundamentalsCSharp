using System;

namespace exercises5
{
    public class exercises5
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int point = 2 * n - 1;
            repeadString(".", point); Console.Write("/|\\"); repeadString(".", point);
            Console.WriteLine();
            repeadString(".", point); Console.Write("\\|/"); repeadString(".", point);
            Console.WriteLine();
            repeadString(".", point); Console.Write("***"); repeadString(".", point);
            Console.WriteLine();

            int dash = 1;
            point = 2 * n - 2;

            for (int i = 1; i <= 2 * n - 1; i++)
            {
                repeadString(".", point); Console.Write("*"); repeadString("-", dash); Console.Write("*"); repeadString("-", dash); Console.Write("*"); repeadString(".", point);

                point--;
                dash++;
                Console.WriteLine();
            }
            repeadString("*", 4 * n + 1);
            Console.WriteLine();
            repeadString("*.", 2 * n); Console.Write("*");
            Console.WriteLine();
            repeadString("*", 4 * n + 1);
            Console.WriteLine();

        }
        private static void repeadString(string character, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Console.Write(character);
            }
        }
    }
}


