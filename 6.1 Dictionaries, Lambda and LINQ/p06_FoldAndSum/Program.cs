using System;
using System.Linq;

namespace p06_FoldAndSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = arr.Length / 4;
            
            var leftNums = arr.Take(k).Reverse().ToArray();
            var rightNums = arr.Reverse().Take(k).ToArray();
            var row1 = leftNums.Concat(rightNums).ToArray();
            var row2 = arr.Skip(k).Take(2 * k).ToArray();

            var output = row1.Zip(row2, (x, y) => (x + y));

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
