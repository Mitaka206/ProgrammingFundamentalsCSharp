using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string dayOrNight = Console.ReadLine();

        double transportPrice = 0d;

        if (n >= 100)
        {
            transportPrice = n * 0.06;
        }
        else if (n >= 20 && n < 100)
        {
            transportPrice = n * 0.9;
        }
        else
        {
            switch (dayOrNight)
            {
                case "day":
                    transportPrice = 0.7 + n * 0.79; break;
                case "night":
                    transportPrice = 0.7 + n * 0.90; break;
            }
        }
        Console.WriteLine("{0:f2}", transportPrice);

    }
}
