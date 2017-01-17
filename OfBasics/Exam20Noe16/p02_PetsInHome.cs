using System;

namespace PetsInHome
{
    public class PetsInHome
    {
        public static void Main(string[] args)
        {
            int dayOfHolyday = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFoodGr = double.Parse(Console.ReadLine());

            double turtleFood = turtleFoodGr / 1000;


            double dogForHoluday = dayOfHolyday * dogFood;
            double catForHoluday = dayOfHolyday * catFood;
            double turtleForHoluday = dayOfHolyday * turtleFood;

            double sumFood = Math.Ceiling(dogForHoluday + catForHoluday + turtleForHoluday);

            if (sumFood>foodKg)
            {
                double ostat = sumFood - foodKg;
                Console.WriteLine("{0} more kilos of food are needed.", ostat);
            }
            else 
            {
                double ostat = foodKg - sumFood;
                Console.WriteLine("{0} kilos of food left.", ostat);
            }


        }
    }
}
