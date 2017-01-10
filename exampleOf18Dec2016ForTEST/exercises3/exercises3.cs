using System;

namespace exercises3
{
    public class exercises3
    {
        public static void Main(string[] args)
        {

            double chrizantems = double.Parse(Console.ReadLine());
            double rouses = double.Parse(Console.ReadLine());
            double tulips = double.Parse(Console.ReadLine());

            string season = Console.ReadLine().ToLower();
            string holidayOrNot = Console.ReadLine().ToLower();

            double bonusSevenUp = 0.95;//5% spring
            double bonusTenUp = 0.9;//10% winter
            double bonusTwentyUp = 0.8;//20% all seasons

            double holidayIncreast = 1.15;//15% for holidays

            double allFlower = chrizantems + rouses + tulips;
            double priceAllFlowers = 0;
            

            switch (season)
            {
                case "spring":
                    priceAllFlowers = 2 * chrizantems + 4.1 * rouses + 2.5 * tulips;
                    switch (holidayOrNot)
                    {
                        case "y":
                            priceAllFlowers *= holidayIncreast;
                            break;
                        case "n":
                            priceAllFlowers *= 1;
                            break;
                    }
                    if (tulips>=7)
                    {
                        priceAllFlowers *= bonusSevenUp;
                    }
                    
                    break;
                case "summer":
                    priceAllFlowers = 2 * chrizantems + 4.1 * rouses + 2.5 * tulips;
                    switch (holidayOrNot)
                    {
                        case "y":
                            priceAllFlowers *= holidayIncreast;
                            break;
                        case "n":
                            priceAllFlowers *= 1;
                            break;
                    }
                    break;
                case "autumn":
                    priceAllFlowers = 3.75 * chrizantems + 4.5 * rouses + 4.15 * tulips;
                    switch (holidayOrNot)
                    {
                        case "y":
                            priceAllFlowers *= holidayIncreast;
                            break;
                        case "n":
                            priceAllFlowers *= 1;
                            break;
                    }
                    break;
                case "winter":
                    priceAllFlowers = 3.75 * chrizantems + 4.5 * rouses + 4.15 * tulips;
                    switch (holidayOrNot)
                    {
                        case "y":
                            priceAllFlowers *= holidayIncreast;
                            break;
                        case "n":
                            priceAllFlowers *= 1;
                            break;
                    }
                    if (rouses >= 10)
                    {
                        priceAllFlowers *= bonusTenUp;
                    }
                    break;
            }
            
            if (allFlower>=20)
            {
                priceAllFlowers *= bonusTwentyUp;
            }
            priceAllFlowers += 2;
            Console.WriteLine("{0:f2}", priceAllFlowers);


        }
    }
}
