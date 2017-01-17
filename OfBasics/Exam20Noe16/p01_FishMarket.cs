using System;

namespace Exam20Noe16
{
    public class Exam20Noe16
    {
        public static void Main(string[] args)
        {
            double skumriaPriceKg = double.Parse(Console.ReadLine());
            double cacaPriceKg = double.Parse(Console.ReadLine());
            double kgPlamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            double kgMidi = double.Parse(Console.ReadLine());

            double palamudPricekg = kgPlamud * skumriaPriceKg * 1.6;
            double safridPriceKg = kgSafrid * cacaPriceKg * 1.8;
            double midiPriceKg = kgMidi * 7.5;

            double sum = palamudPricekg + safridPriceKg + midiPriceKg;
            Console.WriteLine("{0:f2}",sum);
        }
    }
}
