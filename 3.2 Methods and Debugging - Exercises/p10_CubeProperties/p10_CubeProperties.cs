using System;

namespace p10_CubeProperties
{
    class p10_CubeProperties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string properties = Console.ReadLine();

            output(side, properties);
        }

        private static void output(double side, string properties)
        {
            if (properties.Equals("face"))
            {
                Console.WriteLine($"{Math.Sqrt(2 * side * side):f2}");
            }
            else if (properties.Equals("space"))
            {
                Console.WriteLine($"{Math.Sqrt(3 * side * side):f2}");
            }
            else if (properties.Equals("volume"))
            {
                Console.WriteLine($"{side * side * side:f2}");
            }
            else if (properties.Equals("area"))
            {
                Console.WriteLine($"{side * side * 6:f2}");
            }
        }
    }
}
