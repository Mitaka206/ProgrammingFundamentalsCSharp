using System;

namespace exercises2
{
    public class exercises2
    {
        public static void Main(string[] args)
        {

            double safeMoney = double.Parse(Console.ReadLine());
            double flourWidth = double.Parse(Console.ReadLine());
            double flourLong = double.Parse(Console.ReadLine());
            double aTriangle = double.Parse(Console.ReadLine());
            double hTriangle = double.Parse(Console.ReadLine());
            double priceOfPlate= double.Parse(Console.ReadLine());
            double masterPrice = double.Parse(Console.ReadLine());

            double flourArea = flourLong * flourWidth;
            double triangleArea = (aTriangle * hTriangle) / 2;

            double necesaryPlate = Math.Ceiling(flourArea / triangleArea) + 5;

            double sumPrice = necesaryPlate * priceOfPlate + masterPrice;

            if (safeMoney>=sumPrice)
            {
                double differens = safeMoney - sumPrice;
                Console.WriteLine("{0:f2} lv left. ", differens);
            }
            else
            {
                double differens = sumPrice - safeMoney;
                Console.WriteLine("You'll need");
                Console.WriteLine("{0:f2} lv more.", differens);
            }

        }
    }
}
