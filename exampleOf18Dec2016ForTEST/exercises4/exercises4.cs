using System;

namespace exercises4
{
    public class exercises4
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//count of students

            double studTwo = 0;
            double studthree = 0;
            double studfour = 0;
            double studfive = 0;
            double avarage = 0;
            
            for (int i = 0; i < n; i++)
            {
                double evaluation = double.Parse(Console.ReadLine());

                avarage += evaluation;
                if (evaluation >= 2 && evaluation <= 2.99)
                {
                    studTwo++;
                }
                else if (evaluation >= 3 && evaluation <= 3.99)
                {
                    studthree++;
                }
                else if (evaluation >= 4 && evaluation <= 4.99)
                {
                    studfour++;
                }
                else if (evaluation >= 5)
                {
                    studfive++;
                }
            }
            studTwo = (studTwo / n) * 100;
            studthree = (studthree / n) * 100;
            studfour = (studfour / n) * 100;
            studfive = (studfive / n) * 100;
            avarage = (avarage) / n;

            Console.WriteLine("Top students: {0:f2} %", studfive);//5+
            Console.WriteLine("Between 4.00 and 4.99: {0:f2} %", studfour);//4+
            Console.WriteLine("Between 3.00 and 3.99: {0:f2} %", studthree);//3+
            Console.WriteLine("Fail: {0:f2} %", studTwo);//2+
            Console.WriteLine("Average: {0:f2}", avarage);
        }
    }
}
