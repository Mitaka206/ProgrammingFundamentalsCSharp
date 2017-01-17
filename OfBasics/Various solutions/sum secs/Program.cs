using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_secs
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());

            var sumSec = (sec1 + sec2 + sec3);
            
            var secs = (sumSec % 60).ToString("00");
            var mins = sumSec / 60;

            Console.WriteLine("{0}:{1}", mins, secs);

        }
    }
}
