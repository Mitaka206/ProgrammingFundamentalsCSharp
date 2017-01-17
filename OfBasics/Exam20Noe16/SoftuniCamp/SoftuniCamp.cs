using System;

namespace SoftuniCamp
{
    public class SoftuniCamp
    {
        public static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double car = 0;
            double microbus = 0;
            double litleBus = 0;
            double bigBus = 0;
            double train = 0;
            double sumPeople = 0;

            for (int i = 0; i < groups; i++)
            {
                double people = double.Parse(Console.ReadLine());
                sumPeople += people;

                if (people <= 5)
                {
                    car+=people; 
                }
                else if (people >= 6 && people <= 12)
                {
                    microbus+=people;
                }
                else if (people >= 13 && people <= 25)
                {
                    litleBus+=people;
                }
                else if (people >= 26 && people <= 40)
                {
                    bigBus+=people;
                }
                else if (people >= 41)
                {
                    train+=people;
                }
            }

            Console.WriteLine ("{0:f2}%", (car / sumPeople )* 100);
            Console.WriteLine ("{0:f2}%", (microbus / sumPeople) * 100);
            Console.WriteLine ("{0:f2}%", (litleBus / sumPeople) * 100);
            Console.WriteLine ("{0:f2}%", (bigBus / sumPeople) * 100);
            Console.WriteLine ("{0:f2}%", (train / sumPeople) * 100);
        }
    }
}
