using System;

namespace fox
{
    public class fox
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int starCount = 1;
            int dashCount = n * 2 - 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*',starCount) + "\\" + new string('-', dashCount) + "/" + new string('*', starCount));
                starCount++;
                dashCount -= 2;
            }

            starCount = n /2;
            int midStar = n;
            for (int i = 0; i < n/3; i++)
            {
                Console.WriteLine("|" + new string('*', starCount) + "\\" + new string('*',midStar) + "/" + new string('*', starCount) + "|");
                starCount++;
                midStar -= 2;
            }

            starCount = 1;
            dashCount = n * 2 - 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('-', starCount) + "\\" + new string('*', dashCount) + "/" + new string('-', starCount));
                starCount++;
                dashCount -= 2;
            }

        }
    }
}
