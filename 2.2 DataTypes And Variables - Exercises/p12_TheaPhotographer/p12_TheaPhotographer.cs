using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12_TheaPhotographer
{
    class p12_TheaPhotographer
    {
        static void Main(string[] args)
        {
            long totalPictures = long.Parse(Console.ReadLine()); // in lt
            long filterTime = long.Parse(Console.ReadLine());// in seconds
            long filterFactor = long.Parse(Console.ReadLine());// in lentage
            long uploadTime = long.Parse(Console.ReadLine());// in seconds

            double picsToUpload = Math.Ceiling((double)totalPictures * filterFactor / 100);
            long timeForFiltered = totalPictures * filterTime;// in seconds
            long timeForUpload = (long)picsToUpload * uploadTime;// in seconds

            long fullWorkTime = timeForFiltered + timeForUpload;

            TimeSpan fullTime = TimeSpan.FromSeconds(fullWorkTime);

            Console.WriteLine($"{fullTime.Days:d1}:{fullTime.Hours:d2}:{fullTime.Minutes:d2}:{fullTime.Seconds:d2}");

            //int milSec = int.MaxValue;

            //TimeSpan otherTime = TimeSpan.FromMilliseconds(milSec);

            //Console.WriteLine(milSec);
            
            //Console.WriteLine("days {0}",otherTime.Days);
            //Console.WriteLine("hours {0}",otherTime.Hours);
            //Console.WriteLine("mins: {0}", otherTime.Minutes);
            //Console.WriteLine("sec: {0}", otherTime.Seconds);
            //Console.WriteLine("miliseconds {0}",otherTime.Milliseconds);
        }
    }
}
