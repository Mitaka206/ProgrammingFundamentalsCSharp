using System;
using System.Diagnostics;
using System.Text;

namespace p00_demo
{
    class p00_demo
    {
        static void Main(string[] args)
        {
            var result = string.Empty;
            int testNum = 50000;

            var stopWatch = Stopwatch.StartNew();

            for (int i = 0; i < testNum; i++)
            {
                result += i;// if is INT is faster
            }

            stopWatch.Stop();
            
            Console.WriteLine($"'+     ' - {stopWatch.Elapsed}");

            result = string.Empty;

            stopWatch = Stopwatch.StartNew();

            for (int i = 0; i < testNum; i++)
            {
                string.Concat(result, i);// if is STRING is faster
            }

            stopWatch.Stop();
            
            Console.WriteLine($"'concat' - {stopWatch.Elapsed}");

            result = string.Empty;

            var sb = new StringBuilder(testNum);// if first capacity hold 
                                                // sb is faster (for STRING)
            stopWatch = Stopwatch.StartNew();

            for (int i = 0; i < testNum; i++)
            {
                sb.Append(i);
            }

            stopWatch.Stop();

            Console.WriteLine($"'SubStr' - {stopWatch.Elapsed}");
        }
    }
}
