using System;

namespace exercises1
{
    public class exercises1
    {
        public static void Main(string[] args)
        {
            double speedKMh = double.Parse(Console.ReadLine());

            double firstTime = double.Parse(Console.ReadLine());
            double midleTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            
            double firstDistance = speedKMh * firstTime/60;

            double nextUpSpeed = speedKMh * 1.1;
            double midleDistance = nextUpSpeed * midleTime/60;

            double secondDounSpeed = nextUpSpeed * 0.95;
            double secondDistance = secondDounSpeed * secondTime/60;

            double sumKM = firstDistance+midleDistance+secondDistance;

            Console.WriteLine("{0:f2}",sumKM);
        }
    }
}
