using System;
using System.Linq;

namespace p02._1_appEndDouleReverce
{
    class p02.1_appEndDouleReverce
    {
        static void Main(string[] args)
        {
            var input = "1 2 3 |4 5 6 |  7  8".Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();

            var int1 = RevString(input[0]).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var int2 = RevString(input[1]).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var int3 = RevString(input[2]).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.Write(string.Join(" ", int1) + " ");
            Console.Write(string.Join(" ", int2) + " ");
            Console.Write(string.Join(" ", int3));
            Console.WriteLine();
        }

        private static string RevString(string v)
        {
            char[] cArray = v.ToCharArray();
            string reverse = String.Empty;

            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
